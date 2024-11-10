using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonVino.Entidades;

namespace BonVino.Gestor
{
    internal interface IAgregadoGestor
    {
        public IIterador crearIterador(List<object> elements);
    }
}
