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

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public string getNotaPresentacion { get { return notaPresentacion; } }
        public string setNotaPresentacion { set { notaPresentacion = value; } }

        public DateTime getFechaValidacion { get { return fechaValidacion; } }
        public DateTime setFechaValidacion { set { fechaValidacion = value; } }

        public List<Reseña> GetReseñas { get { return reseñas; } }
        public void setReseña(Reseña rese){ reseñas.Add(rese);}


        //opcional
        public void removerReseña(Reseña rese)
        {
            reseñas.Remove(rese);
        }
    }

 
}
