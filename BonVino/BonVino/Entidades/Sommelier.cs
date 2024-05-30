using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Sommelier
    {
        private DateTime fechaValidacion;
        private string nombre;
        private string notaPresentacion;
        private List<Reseña> reseñas;

        public Sommelier(DateTime fechaValidacion, string nombre, string notaPresentacion) {
            this.fechaValidacion = fechaValidacion;
            this.nombre = nombre;
            this.notaPresentacion = notaPresentacion;
            this.reseñas = new List<Reseña>();

        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public DateTime FechaValidacion
        {
            get => fechaValidacion;
            set => fechaValidacion = value;
        }

        public void añadirReseña(Reseña rese)
        {
            reseñas.Add(rese);
        }

        public void removerReseña(Reseña rese)
        {
            reseñas.Remove(rese);
        }
    }

 
}
