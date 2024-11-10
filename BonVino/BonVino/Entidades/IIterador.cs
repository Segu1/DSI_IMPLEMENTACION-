using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public interface IIterador
    {
        public void siguiente();

        public bool haTerminado();

        public void primero();

        public object actual();

        // public bool cumpleFiltros(Object elemento);
    }
}
