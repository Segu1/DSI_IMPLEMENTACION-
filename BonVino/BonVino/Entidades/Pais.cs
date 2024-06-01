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
        private string nombre;
        private List<Provincia> provincia;

        public Pais(string nombre, List<Provincia> provincia)
        {
            this.nombre = nombre;
            this.provincia = provincia;
        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }
        
        public string getDatosPais(Provincia prov) {
            string nombrePais = ""; //situacion que nunca va a ocurrir

            foreach (Provincia p in provincia)
            {
                if(p.getNombre == prov.getNombre)
                {
                    nombrePais = this.nombre;
                    break;
                };
            }
            return nombrePais;
        }

    }
}
