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
        private DateTime fechHastaSeleccionada;

        public GestorReportesDeReseñas()
        {

        }

        public DateTime getFechaDesdeSeleccionada { get { return fechaDesdeSeleccionada; } }
        public DateTime setFechaHastaSeleccionada { set { fechHastaSeleccionada = value; } }

    }


}
