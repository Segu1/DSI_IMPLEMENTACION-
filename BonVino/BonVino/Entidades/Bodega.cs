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
        private string descripcion;
        private string historia;
        private string nombre;
        private string coordenadasUbicacion; //a chekear
        private int periodoActualizacion; //revisar si el periodo es en dias/meses/años
        private RegionVitivinicola regionVitivinicola;

        public Bodega(string descripcion, string historia, string nombre,
            string coordenadasUbicacion, int periodoActualizacion, RegionVitivinicola regionVitivinicola)
        {
            this.descripcion = descripcion;
            this.historia = historia;
            this.nombre = nombre;
            this.coordenadasUbicacion = coordenadasUbicacion;
            this.periodoActualizacion = periodoActualizacion;
            this.regionVitivinicola = regionVitivinicola;
        }
        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } }
        public string getHistoria { get { return historia; } }
        public string setHistoria { set { historia = value; } }

        public string getCoordenadasUbicacion { get { return coordenadasUbicacion; } }
        public string setCoordenadasUbicacion { set { coordenadasUbicacion = value; } }
        public int getPeriodoActualizacion { get { return periodoActualizacion; } }
        public int setPeriodoActualizacion { set { periodoActualizacion = value; } }

        public RegionVitivinicola getRegionVitivinicola { get { return regionVitivinicola; } }

        //hace falta un set?
        public RegionVitivinicola setRegionVitivinicola { set { regionVitivinicola = value; } }

        public (string, string, string) getDatosBodega(){

            (string nombreRegion, string nombrePais) = this.regionVitivinicola.getDatosRegion();

            return (this.getNombre, nombreRegion, nombrePais);
        }

    }
}
