using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class RegionVitivinicola
    {
        public int IdRegionVitivinicola { get; set; }
        public string Nombre { get; set; }
        public int IdProvincia { get; set; }
        public Provincia Provincia { get; set; }

        public RegionVitivinicola() { }

        public RegionVitivinicola(int idRegionVitivincola, string nombre, int idProvincia)
        {
            IdRegionVitivinicola = idRegionVitivincola;
            Nombre = nombre;
            IdProvincia = idProvincia;
        }

        public (string, string) getDatosRegion()
        {

            // da comienzo a la busqueda de datos de ubicacion y retorna el resultado de la busqueda y el nombre de la Region.

            return (this.Nombre, this.Provincia.getDatosProvincia(this));
        }

    }
}
