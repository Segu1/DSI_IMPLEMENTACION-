using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BonVino.Entidades
{
    public class Vino
    {
        private string nombreVino;  
        private string nombreBodega;
        //Bodega, Varietal, *Reseña

        public Vino(string vino, string bodega)
        {
            this.nombreVino = vino;
            this.nombreBodega = bodega;
        }

        public string NombreVino
        {
            get => nombreVino;
            set => nombreVino = value;
        }

        public string NombreBodega
        {
            get => nombreBodega;
            set => nombreBodega = value;
        }
    }
}