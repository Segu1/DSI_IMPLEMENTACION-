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
        private int periodoActualizacion;
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

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
