using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonVino.Entidades;

namespace BonVino.Gestor
{
    public interface IAgregadoGestor
    {
        public IIterador CrearIterador(List<object> elements);
    }
}
