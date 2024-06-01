using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BonVino.Entidades
{
    public class Provincia
    {
        private string nombre;
        private List<RegionVitivinicola> region;
        private readonly Pais _pais;
        public Provincia(string nombre, List<RegionVitivinicola> region, Pais pais)
        {
            this.nombre = nombre;
            this.region = region;
            _pais = pais;
        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public List<RegionVitivinicola> getRegion { get { return region; } } //Cambi ocar

        public string getDatosProvincia(RegionVitivinicola region)
        { //Cambiar a region vitivinicola
            
                string nombrePais = "";
                foreach (RegionVitivinicola reg in this.region)
                {
                    if (reg == region)
                    {
                        nombrePais = this._pais.getDatosPais(this);
                        break;
                    };

                }
                return nombrePais;
            
        }
    }
}
