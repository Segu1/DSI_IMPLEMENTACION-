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
using System.Drawing;
using System.Collections;

namespace BonVino.Gestor
{
    public class GestorReportesDeReseñas
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
            pantallaReportesDeReseñas.solicitarFechaDesdeYHasta();
        }
        public void tomarFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesdeSeleccionada = fechaDesde;
            this.fechaHastaSeleccionada = fechaHasta;

            pantallaReportesDeReseñas.solicitarTipoReseña();
        }

        public void tomarTipoReseña(string tipoReseña)
        {
            this.tipoReseñasSeleccionada = tipoReseña;
            pantallaReportesDeReseñas.solicitarTipoVisualizacionReporte();
        }

        public void tomarTipoVisualizacionReporte(string tipoVisualizacion)
        {
            this.tipoVisualizacionSeleccionada = tipoVisualizacion;
            pantallaReportesDeReseñas.solicitarConfirmacion();
        }

        public void tomarConfirmacion(bool confirmado)
        {
            this.confirmacion = confirmado;
            buscarVinosConReseñasEnPeriodo();

            if (datosDeVinosConPromedio.Count() == 0)
            {
                MessageBox.Show("No hay reseñas creadas por sommeliers");
                pantallaReportesDeReseñas.Close();
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

            generarObjetos();


            foreach (Vino vin in vinos)
            {
                float promedioDeReseñasEnPeriodo = vin.calcularPromedioDeReseñasEnPeriodo(this.fechaDesdeSeleccionada, this.fechaHastaSeleccionada, pantallaReportesDeReseñas);
                if (promedioDeReseñasEnPeriodo == -1) {
                    return; 
                }
                (string nombre, float precioARS, string bodega, string region, string pais, List<(string tipoUva, float porcentaje)> varietales) = vin.obtenerTodosLosDatos();
                datosDeVinosConPromedio.Add((nombre, precioARS, bodega, region, pais, varietales, promedioDeReseñasEnPeriodo));
            }
        }
        public void ordenarVinosPorPromedioYFiltrarPrimeros10() 
        {
            datosDeVinosConPromedio.Sort((x, y) => y.Item7.CompareTo(x.Item7));
            if(datosDeVinosConPromedio.Count > 10)
            {
                datosDeVinosConPromedio.RemoveRange(10, this.datosDeVinosConPromedio.Count - 10);
            }
        }
        public void generarArchivo()
        {
            //archivoExcel = gestoExcel.generarArchivo()
            interfazExcel.exportarAExcel(datosDeVinosConPromedio);
        }

        public void finCU()
        {
            pantallaReportesDeReseñas.WindowState = FormWindowState.Minimized;
        }

        public void generarObjetos()
        {
            string filePathUbicaciones = "..\\..\\..\\Resources\\jsonUbicacion.json";
            string jsonContentUbicaciones = File.ReadAllText(filePathUbicaciones);
            List<Pais> paises = JsonConvert.DeserializeObject<List<Pais>>(jsonContentUbicaciones);

            // carga vinos al gestor desde un json
            string filePath = "..\\..\\..\\Resources\\jsonVinos.json";
            string jsonContent = File.ReadAllText(filePath);
            // se convierte el string JSON a una lista de objetos de tipo "Vino"
            vinos = JsonConvert.DeserializeObject<List<Vino>>(jsonContent);

            foreach (Vino vin in vinos)
            {
                foreach (Pais pais in paises)
                { 
                    //corregir aca
                    List<Provincia> todasLasProvincias = pais.getProvincia;

                
                    foreach (Provincia prov in todasLasProvincias)
                    {

                        Random random = new Random();
                        int indiceAleatorio = random.Next(prov.getRegion.Count);
                        RegionVitivinicola elementoAleatorio = prov.getRegion[indiceAleatorio];

                        Bodega bodega = vin.getBodega;
                        bodega.setRegionVitivinicola(elementoAleatorio);

                    }
                }
            }
        }
    }
}
