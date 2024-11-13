using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class TipoUva
    {
        public int IdTipoUva { get; set; }
        public string Nombre { get; set; }

        public TipoUva() { }

        public TipoUva(int idTipoUva, string nombre)
        {
            IdTipoUva = idTipoUva;
            Nombre = nombre;
        }
    }
}
