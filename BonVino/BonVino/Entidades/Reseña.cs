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
        private int puntaje;

        public Reseña(string comentario, bool premium, DateTime fecha, int puntajerec)
        {
            this.comentario = comentario;
            this.esPremium = premium;
            this.fechaReseña = fecha;
            this.puntaje = puntajerec;
            //Vino.
        }

        public string Comentario
        {
            get => comentario;
            set => comentario = value;
        }

        public bool EsPremium
        {
            get => esPremium;
            set => esPremium = value;
        }
    }
}
