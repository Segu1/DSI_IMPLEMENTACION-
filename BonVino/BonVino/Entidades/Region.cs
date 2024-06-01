using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class RegionVitivinicola
    {
        private string nombre;
        private string descripcion;
        private readonly Provincia _provincia;
        
        public RegionVitivinicola(string nombre, string descripcion, Provincia provincia)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            _provincia = provincia;
        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }


        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } }

        public (string, string) getDatosRegion() {

            return (this.getNombre, this._provincia.getDatosProvincia(this));
        }

    }
}
