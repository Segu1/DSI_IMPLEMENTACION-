using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BonVino.Entidades
{
    public class RegionVitivinicola
    {
        private int IdRegionVitivinicola;
        private string Nombre;
        private int IdProvincia;
        public Provincia Provincia { get; set; }

        public int getIdRegionVitivinicola() { return IdRegionVitivinicola; }
        public void setIdRegionVitivinicola(int value) { IdRegionVitivinicola = value; }

        public string getNombre() { return Nombre; }
        public void setNombre(string value) { Nombre = value; }

        public int getIdProvincia() { return IdProvincia; }
        public void setIdProvincia(int value) { IdProvincia = value; }
        public RegionVitivinicola() { }

        public RegionVitivinicola(int idRegionVitivincola, string nombre, int idProvincia)
        {
            IdRegionVitivinicola = idRegionVitivincola;
            Nombre = nombre;
            IdProvincia = idProvincia;
        }

        public (string, string) getDatosRegionVitivinicola()
        {

            // da comienzo a la busqueda de datos de ubicacion y retorna el resultado de la busqueda y el nombre de la Region.

            return (this.Nombre, this.Provincia.getDatosProvincia(this));
        }

    }
}
