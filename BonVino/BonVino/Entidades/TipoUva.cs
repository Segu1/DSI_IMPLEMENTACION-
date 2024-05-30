using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class TipoUva
    {
        private string descripcion;
        private string nombre;

        public TipoUva(string descripcion, string nombre) {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }


        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } } //cambiar en todos. 

        public string getNombre { get { return descripcion; } }
        public string setNombre { set { nombre = value; } }
    }
}
