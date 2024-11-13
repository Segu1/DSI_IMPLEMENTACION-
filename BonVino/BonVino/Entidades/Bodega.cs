using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BonVino.Entidades
{
    public class Bodega
    {
        private string Descripcion;
        private int IdBodega;
        private string Nombre;
        private int IdRegion;
        public RegionVitivinicola RegionVitivinicola { get; set; }

        public int getIdBodega() { return IdBodega; }
        public void setIdBodega(int value) { IdBodega = value; }
        public string getDescripcion() { return Descripcion; }
        public void setDescripcion(string value) { Descripcion = value; }
        public string getNombre() { return Nombre; }
        public void setNombre(string value) { Nombre = value; }
        public int getIdRegion() { return IdRegion; }
        public void setIdRegion(int value) { IdRegion = value; }

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

            (string nombreRegion, string nombrePais) = this.RegionVitivinicola.getDatosRegionVitivinicola();

            return (this.Nombre, nombreRegion, nombrePais);
        }

    }
}
