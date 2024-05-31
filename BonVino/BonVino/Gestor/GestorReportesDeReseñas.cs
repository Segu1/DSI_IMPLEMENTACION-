using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void tomarTipoVisualizacionReporte(string tipoVisualizacion){
            this.tipoVisualizacionSeleccionada = tipoVisualizacion;
        }

        public void tomarConfirmacion(bool confirmado) {
            this.confirmacion = confirmado;
        }

        public DateTime getFechaHastaSeleccionada { get { return fechaHastaSeleccionada; } }

        public string getTipoReseñaSeleccionada { get { return tipoReseñaSeleccionada; } }

        public string getTipoVisualizacion { get { return tipoVisualizacionSeleccionada; } }

        public bool getConfirmacion { get { return confirmacion;} }

    }
}
