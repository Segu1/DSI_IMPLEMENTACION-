using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    internal class IteradorVinos : IIterador
    {
        private List<Vino> vinos;
        private List<DateTime> filtros;
        private int posicionActual = 0;

        public IteradorVinos(List<Vino> vinos, List<DateTime> filtros)
        {
            this.vinos = vinos;
            this.filtros = filtros;
        }

        public object actual()
        {
            while (posicionActual < vinos.Count)
            {
                if (!cumpleFiltros(vinos[posicionActual]))
                {
                    posicionActual++; //lo deja en uno que cumple
                }
                else
                {
                    return vinos[posicionActual];
                }
            }
            return null; //en caso que ninguno cumpla
        }

        public bool haTerminado()
        {
            if (posicionActual < vinos.Count)
            {
                return false;
            }
            return true;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }

        public bool cumpleFiltros(Vino vin)
        {
            return vin.tieneReseñasEnPeriodo(filtros);
        }

        /*
        public IteradorVinos(List<Vino> vinos, List<DateTime> filtros)
        {
            this.vinos = vinos;
            this.filtros = filtros;
        }

        public object actual()
        {
            return vinos[posicionActual];
        }

        public bool haTerminado()
        {
            if (posicionActual < vinos.Count)
            {
                while (posicionActual < vinos.Count && !cumpleFiltros(vinos[posicionActual]))
                {
                    posicionActual++;
                }
                return true;
            }
            return false;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            while(posicionActual < vinos.Count && !cumpleFiltros(vinos[posicionActual]))
            {
                posicionActual++; //lo deja en uno que cumple
            }
        }

        public bool cumpleFiltros(Vino vin)
        {
            return vin.tieneReseñasEnPeriodo(filtros[0], filtros[1]);
        }
        */
    }
}
