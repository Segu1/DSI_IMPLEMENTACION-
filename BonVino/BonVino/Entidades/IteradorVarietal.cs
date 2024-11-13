using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    internal class IteradorVarietal : IIterador
    {
        private List<Varietal> varietales;
        private int posicionActual = 0;

        public IteradorVarietal(List<Varietal> varietales)
        {
            this.varietales = varietales;
        }
        public object actual()
        {
            return varietales[posicionActual];
        }

        public bool haTerminado()
        {
            if(posicionActual < varietales.Count)
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
    }
}
