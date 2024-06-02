using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Reseña
    {
        private string comentario;
        private bool esPremium;
        private DateTime fechaReseña;
        private float puntaje;
        private Vino vino;

        public Reseña(string comentario, bool premium, DateTime fecha, int puntajerec, Vino vino)
        {
            this.comentario = comentario;
            this.esPremium = premium;
            this.fechaReseña = fecha;
            this.puntaje = puntajerec;
            this.vino = vino;
        }

        public string getComentario { get { return comentario; } }
        public string setComentario { set { comentario = value; } }

        public bool getEsPremium { get { return esPremium; } }
        public bool setEsPremium { set { esPremium = value; } }
        public DateTime getFechaReseña { get { return fechaReseña; } }
        public DateTime setFechaReseña { set { fechaReseña = value; } }
        public float getPuntaje { get { return puntaje; } }
        public float setPuntaje { set { puntaje = value; } }
        public Vino getVino { get { return vino; } }

        // hace falta un set vino?
        public Vino setVino { set { vino = value; } }

        public bool estaEnPeriodo(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            return (this.fechaReseña >= fechaDesdeSeleccionada && this.fechaReseña <= fechaHastaSeleccionada);
           
        }

        public bool sosDeSommelier()
        {
            return (this.esPremium);
        }



    }
}
