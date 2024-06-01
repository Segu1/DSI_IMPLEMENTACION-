using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BonVino.Entidades
{
    public class Provincia { 
        private string nombre;
        private List<Region> region;
        private readonly Pais _pais;
        public Provincia(string nombre, List<Region> region) {
            this.nombre = nombre;
            this.region = region;
           
        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public List<Region> getRegion { get { return region; } } //Cambi ocar

        public string getDatosProvincia(Region region) { //Cambiar a region vitivinicola
        {
            string nombreProvincia = ""; //situacion que nunca va a ocurrir
            foreach (Region reg in this.region)
            {
                if (reg == region)
                {
                    nombreProvincia = this.nombre;
                    break;
                };

            }
            
            return nombreProvincia;
        }
    }
}
