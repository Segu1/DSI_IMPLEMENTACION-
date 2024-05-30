using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BonVino.Entidades
{
    public class Vino
    {
        private string nombre;
        private Bodega bodega;
        private float precioARS;
        private List<Reseña> reseñas;
        private List<Varietal> varietal;

        public Vino(string nombre, Bodega bodega, float precioARS, List<Varietal> varietal)
        {
            this.nombre = nombre;
            this.bodega = bodega;
            this.precioARS = precioARS;
            this.reseñas = new List<Reseña>();
            this.varietal = varietal; //a chequear

        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public void agregarReseña(Reseña res)
        {
            reseñas.Add(res);
        }

        public void eliminarReseña(Reseña res){
            reseñas.Remove(res);
        }


        public void AgregarVarietal(Varietal var)
        {
            varietal.Add(var);
        }

        public void eliminarReseña(Varietal var)
        {
            varietal.Remove(var);
        }

    }
}