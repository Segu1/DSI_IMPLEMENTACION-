using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonVino.Entidades;


namespace BonVino.Entidades
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public List<Provincia> Provincia { get; set; }

        public Pais() { }
        public Pais(int idPais, string nombre)
        {
            IdPais = idPais;
            Nombre = nombre;
        }

        public string getDatosPais(Provincia prov) {

            // obtiene y retorna el nombre del Pais.

            string nombrePais = "";

            nombrePais = this.Nombre;
            return nombrePais;
        }

    }
}
