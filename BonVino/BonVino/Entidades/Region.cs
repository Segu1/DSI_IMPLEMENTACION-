using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class RegionVitivinicola
    {
        private string nombre;
        private string descripcion;
        
        public RegionVitivinicola(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Descricpion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
