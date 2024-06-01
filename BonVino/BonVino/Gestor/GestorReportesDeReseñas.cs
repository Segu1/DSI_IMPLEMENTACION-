using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonVino.Entidades;
using BonVino.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        }

        public DateTime getFechaHastaSeleccionada { get { return fechaHastaSeleccionada; } }

        public string getTipoReseñaSeleccionada { get { return tipoReseñaSeleccionada; } }

        public string getTipoVisualizacion { get { return tipoVisualizacionSeleccionada; } }

        public bool getConfirmacion { get { return confirmacion; } }

        public void buscarVinosConReseñasEnPeriodo()
        {
            foreach (Vino vin in vinos)
            {
                float promedioDeReseñasEnPeriodo = vin.calcularPromedioDeReseñasEnPeriodo(this.fechaDesdeSeleccionada, this.fechaHastaSeleccionada);
                if (promedioDeReseñasEnPeriodo != -1)
                {

                    List<(string, float, float, string, string, string, List<(string, float)>)> datosDeVinosConPromedio = new List<(string, float, float, string, string, string, List<(string, float)>)>();
                
                    //[ (  (ombre, prom, ())  ,  (vino2)  ]

                    //(string bodega, string region, string pais) = vin.obtenerDatosBodegaRegionPais();


                    datosDeVinosConPromedio.Add((vin.getNombre, promedioDeReseñasEnPeriodo,  ));




                    //List<(nombre string, promedio float, precio float, nombreBodega string, NombrePais string, Nombrregion string, varietales List<string>)>
                }
            }
        }

    }
}
