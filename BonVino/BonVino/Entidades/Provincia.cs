using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BonVino.Entidades
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public  Pais Pais { get; set; }
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
                //foreach (RegionVitivinicola reg in this.Region)
                //{
                //    if (reg == Region)
                //    {
                //        nombrePais = this.Pais.getDatosPais(this);
                //        break;
                //    };

                //}
                nombrePais = this.Pais.getDatosPais(this);

                return nombrePais;
            
        }
    }
}
