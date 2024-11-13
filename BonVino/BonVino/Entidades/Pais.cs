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
        private int IdPais;
        private string Nombre;
        public List<Provincia> Provincia { get; set; }

        public int getIdPais() { return IdPais; }
        public void setIdPais(int value) { IdPais = value; }
        public string getNombre() { return Nombre; }
        public void setNombre(string value) { Nombre = value; }
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
