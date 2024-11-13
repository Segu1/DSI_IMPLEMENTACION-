using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public interface IAgregado
    {
        public IIterador CrearIterador(List<object> elements);
    }
}
