using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    internal class IteradorVarietal : IIterador
    {
        private List<Varietal> varietal;
        private int posicionActual = 0;

        public IteradorVarietal(List<Varietal> varietal)
        {
            this.varietal = varietal;
        }
        public object actual()
        {
            return varietal[posicionActual];
        }

        public bool haTerminado()
        {
            if(posicionActual < varietal.Count)
            {
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
            posicionActual++;
        }
    }
}
