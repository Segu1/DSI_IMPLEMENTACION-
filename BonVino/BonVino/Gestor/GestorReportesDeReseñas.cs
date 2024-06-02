using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonVino.Entidades;
using BonVino.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;

namespace BonVino.Gestor
{
    public class GestorReportesDeReseñas
    {
        private DateTime fechaDesdeSeleccionada;
        private DateTime fechaHastaSeleccionada;
        private string tipoReseñaSeleccionada;
        private string tipoVisualizacionSeleccionada;
        private bool confirmacion;
        private PantallaReportesDeReseñas pantallaReportesDeReseñas;
        private List<Vino> vinos;
        private List<(string, float, string, string, string, List<(string, float)>, float)> datosDeVinosConPromedio;

        public GestorReportesDeReseñas(PantallaReportesDeReseñas pantallaReportesDeReseñas)
        {
            this.pantallaReportesDeReseñas = pantallaReportesDeReseñas;
        }

        public DateTime getFechaDesdeSeleccionada { get { return fechaDesdeSeleccionada; } }

        public void tomarFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesdeSeleccionada = fechaDesde;
            this.fechaHastaSeleccionada = fechaHasta;
        }

        public void tomarTipoReseña(string tipoReseña)
        {
            this.tipoReseñaSeleccionada = tipoReseña;
        }

        public void tomarTipoVisualizacionReporte(string tipoVisualizacion)
        {
            this.tipoVisualizacionSeleccionada = tipoVisualizacion;
        }

        public void tomarConfirmacion(bool confirmado)
        {
            this.confirmacion = confirmado;
            buscarVinosConReseñasEnPeriodo();
            ordenarVinosPorPromedioYFiltrarPrimeros10();
        }

        public DateTime getFechaHastaSeleccionada { get { return fechaHastaSeleccionada; } }

        public string getTipoReseñaSeleccionada { get { return tipoReseñaSeleccionada; } }

        public string getTipoVisualizacion { get { return tipoVisualizacionSeleccionada; } }

        public bool getConfirmacion { get { return confirmacion; } }

        public void buscarVinosConReseñasEnPeriodo()
        {

            // carga vinos al gestor desde un json

            //CAMBIAR A RUTA RELATIVAAAAAAAAAAAAAAAAAAAA!
            string filePath = "..\\..\\..\\Resources\\jsonVinos.json";
            string jsonContent = File.ReadAllText(filePath);
            // se convierte el string JSON a una lista de objetos de tipo "Vino"
            vinos = JsonConvert.DeserializeObject<List<Vino>>(jsonContent);

            foreach (Vino vin in vinos)
            {
                float promedioDeReseñasEnPeriodo = vin.calcularPromedioDeReseñasEnPeriodo(this.fechaDesdeSeleccionada, this.fechaHastaSeleccionada);
                if (promedioDeReseñasEnPeriodo == -1) { return; }

                (string nombre, float precioARS, string bodega, string region, string pais, List<(string tipoUva, float porcentaje)> varietales) = vin.obtenerTodosLosDatos();
                datosDeVinosConPromedio.Add((nombre, precioARS, bodega, region, pais, varietales, promedioDeReseñasEnPeriodo));
               
            }
        }
        public void ordenarVinosPorPromedioYFiltrarPrimeros10() 
        {
            //datosDeVinosConPromedio.Sort((x, y) => x.Item7.CompareTo(y.Item7));
            //datosDeVinosConPromedio.RemoveRange(10, this.datosDeVinosConPromedio.Count - 10);
            this.mostrarDatos();
        }
        public void mostrarDatos()
        {
            this.buscarVinosConReseñasEnPeriodo();
            string resultado = "";

            //ERROR AQUI
            foreach ( (string, float, string, string, string, List<(string, float)>, float) item in datosDeVinosConPromedio)
            {
                resultado += item.Item1;
            }

            
            pantallaReportesDeReseñas.mostrarDatos(resultado);

        }
    }
}
