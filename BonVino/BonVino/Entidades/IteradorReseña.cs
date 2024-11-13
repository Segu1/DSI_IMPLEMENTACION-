using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    internal class IteradorReseña : IIterador
    {
        private List<Reseña> reseña;
        private List<DateTime> filtros;
        private int posicionActual = 0;
        public IteradorReseña(List<Reseña> reseña, List<DateTime> filtros)
        {
            this.reseña = reseña;
            this.filtros = filtros;
        }

        public object actual()
        {
            while (posicionActual < reseña.Count)
            {
                if (!cumpleFiltros(reseña[posicionActual]))
                {
                    posicionActual++; //lo deja en uno que cumple
                }
                else
                {
                    return reseña[posicionActual];
                }
            }
            return null; //en caso que ninguno cumpla
        }

        public bool haTerminado()
        {
            if (posicionActual < reseña.Count)
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

        public bool cumpleFiltros(Reseña reseña)
        {
            return reseña.estaEnPeriodo(filtros[0], filtros[1]) && reseña.sosDeSommelier();
        }
    }
}
