﻿using System;
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
        public int getPuntaje { get { return puntaje; } }
        public int setPuntaje { set { puntaje = value; } }
        public Vino getVino { get { return vino; } }

        // hace falta un set vino?
        public Vino setVino { set { vino = value; } }

    }
}
