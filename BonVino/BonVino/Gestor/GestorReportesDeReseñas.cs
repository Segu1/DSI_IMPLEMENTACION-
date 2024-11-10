using BonVino.Entidades;
using BonVino.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BonVino.Gestor
{
    public class GestorReportesDeReseñas : IAgregadoGestor
    {
        private DateTime fechaDesdeSeleccionada;
        private DateTime fechaHastaSeleccionada;
        private string tipoReseñasSeleccionada;
        private string tipoVisualizacionSeleccionada;
        private bool confirmacion;
        private PantallaReportesDeReseñas pantallaReportesDeReseñas;
        private List<Vino> vinos;
        private List<(string, float, string, string, string, List<(string, float)>, float)> datosDeVinosConPromedio;
        private InterfazExcel interfazExcel;
        //private string archivoExcel;
        public GestorReportesDeReseñas(PantallaReportesDeReseñas pantallaReportesDeReseñas)
        {
            this.pantallaReportesDeReseñas = pantallaReportesDeReseñas;
            this.vinos = new List<Vino>();
            this.interfazExcel = new InterfazExcel();
            this.datosDeVinosConPromedio = new List<(string, float, string, string, string, List<(string, float)>, float)>();
        }

        public DateTime getFechaDesdeSeleccionada { get { return fechaDesdeSeleccionada; } }


        public void tomarOpcionGenerarRankingVinos()
        {
            // da comienzo a la solicitud de ingreso de periodo
            pantallaReportesDeReseñas.solicitarFechaDesdeYHasta();
        }
        public void tomarFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            // toma y guarda el periodo y da comienzo a la solictud de un tipo de reseña.
            this.fechaDesdeSeleccionada = fechaDesde;
            this.fechaHastaSeleccionada = fechaHasta;

            pantallaReportesDeReseñas.solicitarTipoReseña();
        }

        public void tomarTipoReseña(string tipoReseña)
        {
            //toma y guarda el tipo de reseña seleccionada y da comienzo a la solictud de un tipo de visualización.
            this.tipoReseñasSeleccionada = tipoReseña;
            pantallaReportesDeReseñas.solicitarTipoVisualizacionReporte();
        }

        public void tomarTipoVisualizacionReporte(string tipoVisualizacion)
        {
            //toma y guarda el tipo de visualización y da comienzo a la solicitud de confimación.
            this.tipoVisualizacionSeleccionada = tipoVisualizacion;
            pantallaReportesDeReseñas.solicitarConfirmacion();
        }

        public void tomarConfirmacion(bool confirmado)
        {
            // toma y guarda la confirmacion y realiza da comienzo a la generacion del ranking.

            this.confirmacion = confirmado;
            buscarVinosConReseñasEnPeriodo();

            //en caso de que no existan reseñas en periodo cargadas por sommeliers, se le notifica al usuario
            if (datosDeVinosConPromedio.Count() == 0)
            {
                pantallaReportesDeReseñas.informarFaltaReseñas();
                return;
            }

            ordenarVinosPorPromedioYFiltrarPrimeros10();
            generarArchivo();
            pantallaReportesDeReseñas.informarGeneracionExitosaDeArchivo();

            finCU();
        }

        public DateTime getFechaHastaSeleccionada { get { return fechaHastaSeleccionada; } }

        public string getTipoReseñaSeleccionada { get { return tipoReseñasSeleccionada; } }

        public string getTipoVisualizacion { get { return tipoVisualizacionSeleccionada; } }

        public bool getConfirmacion { get { return confirmacion; } }

        public void buscarVinosConReseñasEnPeriodo()
        {
            //busca y guarda todos los datos de cada vino, incluyendo el promedio de las calificaciones de sus reseñas.

            // carga vinos al gestor desde un json
            string filePath = "..\\..\\..\\Resources\\jsonVinos.json";
            string jsonContent = File.ReadAllText(filePath);
            // se convierte el string JSON a una lista de objetos de tipo "Vino"
            vinos = JsonConvert.DeserializeObject<List<Vino>>(jsonContent);
            /*
            foreach (Vino vin in vinos)
            {
                float promedioDeReseñasEnPeriodo = vin.calcularPromedioDeReseñasEnPeriodo(this.fechaDesdeSeleccionada, this.fechaHastaSeleccionada);
                if (promedioDeReseñasEnPeriodo == -1)
                {
                    return;
                }
                (string nombre, float precioARS, string bodega, string region, string pais, List<(string tipoUva, float porcentaje)> varietales) = vin.obtenerTodosLosDatos();
                datosDeVinosConPromedio.Add((nombre, precioARS, bodega, region, pais, varietales, promedioDeReseñasEnPeriodo));
            }*/
            if (vinos.Count > 0)
            {
                IIterador iteradorDeVinos = CrearIterador(vinos.Cast<object>().ToList());
                iteradorDeVinos.primero();  // Asumiendo que esto mueve el iterador al primer elemento

                while (!iteradorDeVinos.haTerminado())  // Iterar hasta el final
                {
                    // Lógica para procesar el elemento actual
                    Vino vinoActual = (Vino)iteradorDeVinos.actual();
                    //estamso en un vino qu ecumple el filtro
                    float promedioDeReseñasEnPeriodo = vinoActual.calcularPromedioDeReseñasEnPeriodo(this.fechaDesdeSeleccionada, this.fechaHastaSeleccionada);

                    iteradorDeVinos.siguiente();  // Mover al siguiente elemento
                }
            }

        }

        public IIterador CrearIterador(List<Object> elements)
        {
           
            // Crea y devuelve una instancia de IteradorVinos con la lista de vinos y las fechas
            return new IteradorVinos(elements.OfType<Vino>().ToList(), new List<DateTime> { fechaDesdeSeleccionada, fechaHastaSeleccionada });

            /*
            if (elements is Vino vin)
            {
                new IteradorVinos(vin, [fechaDesdeSeleccionada, fechaHastaSeleccionada]); 
            }*/
        }

        public void ordenarVinosPorPromedioYFiltrarPrimeros10()
        {
            // ordena todos los vinos segun el promedio de calificaciones de mayor a menor, y luego filtra los primeros 10.

            datosDeVinosConPromedio.Sort((x, y) => y.Item7.CompareTo(x.Item7));
            if (datosDeVinosConPromedio.Count > 10)
            {
                datosDeVinosConPromedio.RemoveRange(10, this.datosDeVinosConPromedio.Count - 10);
            }
        }
        public void generarArchivo()
        {
            // da comienzo a la generacion del archivo con los resultados del ranking.

            //archivoExcel = gestorExcel.generarArchivo()
            interfazExcel.exportarAExcel(datosDeVinosConPromedio);
        }

        public void finCU()
        {
            pantallaReportesDeReseñas.WindowState = FormWindowState.Minimized;
        }

        
    }
}
