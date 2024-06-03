using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Bodega
    {
        private string descripcion;
        private string nombre;
        private RegionVitivinicola regionVitivinicola;

        public Bodega(string descripcion, string nombre, RegionVitivinicola regionVitivinicola)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
            this.regionVitivinicola = regionVitivinicola;
        }
        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } }

        public RegionVitivinicola getRegionVitivinicola { get { return regionVitivinicola; } }
        public void setRegionVitivinicola(RegionVitivinicola value) 
        { 
            this.regionVitivinicola = value;  
        }

        public (string, string, string) getDatosBodega(){

            (string nombreRegion, string nombrePais) = this.regionVitivinicola.getDatosRegion();

            return (this.getNombre, nombreRegion, nombrePais);
        }

    }
}
