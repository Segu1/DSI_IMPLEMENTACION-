using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BonVino.Entidades
{
    public class TipoUva
    {
        private int IdTipoUva;
        private string Nombre;

        public int getIdTipoUva() { return IdTipoUva; }
        public void setIdTipoUva(int value) { IdTipoUva = value; }
        public string getNombre() { return Nombre; }
        public void setNombre(string value) { Nombre = value; }

        public TipoUva() { }

        public TipoUva(int idTipoUva, string nombre)
        {
            IdTipoUva = idTipoUva;
            Nombre = nombre;
        }
    }
}
