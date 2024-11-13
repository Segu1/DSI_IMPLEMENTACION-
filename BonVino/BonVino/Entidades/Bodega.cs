using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Bodega
    {
        public string Descripcion { get; set; }
        public int IdBodega { get; set; }
        public string Nombre { get; set; }

        public int IdRegion { get; set; }
        public RegionVitivinicola RegionVitivinicola { get; set; }

        public Bodega() { }
        public Bodega(string descripcion, int idBodega, string nombre, int idRegion)
        {
            Descripcion = descripcion;
            IdBodega = idBodega;
            Nombre = nombre;
            IdRegion = idRegion;
        }

        public (string, string, string) getDatosBodega(){
            // da comienzo la busqueda de datos de ubicacion y devuelve el resultado y el nombre de la bodega.

            (string nombreRegion, string nombrePais) = this.RegionVitivinicola.getDatosRegion();

            return (this.Nombre, nombreRegion, nombrePais);
        }

    }
}
