using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Reseña
    {
        public int IdReseña { get; set; }
        public bool EsPremium { get; set; }
        public DateTime FechaReseña { get; set; }
        public float Puntaje { get; set; }
        public string Comentario { get; set; }
        public Vino Vino { get; set; }
        public int IdVino { get; set; }

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
