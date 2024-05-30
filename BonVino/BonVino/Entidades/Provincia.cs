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
        public Provincia(string nombre, List<Region> region) {
            this.nombre = nombre;
            this.region = region;
        }

       public string getNombre { get { return nombre; } }
       public List<Region> getRegion { get { return region; } }

       public string setNombre { set { nombre = value; } }

    }
}
