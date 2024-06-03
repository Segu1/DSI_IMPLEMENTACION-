using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Reseña
    {
        private bool esPremium;
        private DateTime fechaReseña;
        private float puntaje;
        private Vino vino;

        public Reseña( bool esPremium, DateTime fechaReseña, int puntaje)
        {
            this.esPremium = esPremium;
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
        }
        public bool getEsPremium { get { return esPremium; } }
        public bool setEsPremium { set { esPremium = value; } }
        public DateTime getFechaReseña { get { return fechaReseña; } }
        public DateTime setFechaReseña { set { fechaReseña = value; } }
        public float getPuntaje { get { return puntaje; } }
        public float setPuntaje { set { puntaje = value; } }
        public Vino getVino { get { return vino; } }
        public Vino setVino { set { vino = value; } }

        public bool estaEnPeriodo(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            //devuelve true si la fecha en la que se realizo la reseña esta en el periodo seleccionado.
            return this.fechaReseña >= fechaDesdeSeleccionada && this.fechaReseña <= fechaHastaSeleccionada;
        }
        public bool sosDeSommelier()
        {
            // toda reseña que es premium, implica que fue hecha por un sommelier
            return this.getEsPremium;
        }



    }
}
