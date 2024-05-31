using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Pais
    {
        private string nombre;
        private List<Provincia> provincia;

        public Pais(string nombre, List<Provincia> provincia)
        {
            this.nombre = nombre;
            this.provincia = provincia;
        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }
        


    }
}
