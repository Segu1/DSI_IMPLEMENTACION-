using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BonVino.Entidades
{
    public class Provincia
    {
        private int IdProvincia;
        private string Nombre;
        private int IdPais;
        public  Pais Pais { get; set; }

        public int getIdProvincia() { return IdProvincia; }
        public void setIdProvincia(int value) { IdProvincia = value; }
        public string getNombre() { return Nombre; }
        public void setNombre(string value) { Nombre = value; }
        public int getIdPais() { return IdPais; }
        public void setIdPais(int value) { IdPais = value; }
        public List<RegionVitivinicola> Region { get; set; }

        public Provincia() { }

        public Provincia(int idProvincia, string nombre, int idPais)
        {
            IdProvincia = idProvincia;
            Nombre = nombre;
            IdPais = idPais;
        }

        public string getDatosProvincia(RegionVitivinicola region)
        {
                //busca el nombre del Pais y devuelve ese resultado.

                string nombrePais = "";
   
                nombrePais = this.Pais.getDatosPais(this);

                return nombrePais;
            
        }
    }
}
