using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class TipoUva
    {
        private string nombre;

        public TipoUva(string nombre) {
            this.nombre = nombre;
        }
        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }
    }
}
