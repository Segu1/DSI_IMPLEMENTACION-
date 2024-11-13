using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Reseña
    {
        private int IdReseña;
        private bool EsPremium;
        private DateTime FechaReseña;
        private float Puntaje;
        private string Comentario;
        private int IdVino;
        public Vino Vino { get; set; }
        public int getIdReseña() { return IdReseña; }
        public void setIdReseña(int value) { IdReseña = value; }
        public bool getEsPremium() { return EsPremium; }
        public void setEsPremium(bool value) { EsPremium = value; }
        public DateTime getFechaReseña() { return FechaReseña; }
        public void setFechaReseña(DateTime value) { FechaReseña = value; }
        public float getPuntaje() { return Puntaje; }
        public void setPuntaje(float value) { Puntaje = value; }

        public string getComentario() { return Comentario; }
        public void setComentario(string value) { Comentario = value; }
        public int getIdVino() { return IdVino; }
        public void setIdVino(int value) { IdVino = value; }

        public Reseña(int idReseña, bool esPremium, DateTime fechaReseña, float puntaje, string comentario, int idVino)
        {
            IdReseña = idReseña;
            EsPremium = esPremium;
            FechaReseña = fechaReseña;
            Puntaje = puntaje;
            Comentario = comentario;
            IdVino = idVino;
        }

        public Reseña()
        {
        }

        public bool estaEnPeriodo(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            return this.FechaReseña >= fechaDesdeSeleccionada && this.FechaReseña <= fechaHastaSeleccionada;
        }
        public bool sosDeSommelier()
        {
            // toda reseña que es premium, implica que fue hecha por un sommelier
            return this.EsPremium;
        }

    }
}
