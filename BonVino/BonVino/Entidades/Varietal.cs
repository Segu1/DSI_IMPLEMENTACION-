using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Varietal
    {
        private string descripcion;
        private float porcentajeComposion;
        private TipoUva tipoUva;

        public Varietal(string descripcion, float porcentajeComposicion, TipoUva tipoUva)
        {
            this.descripcion = descripcion;
            this.porcentajeComposion = porcentajeComposicion;
            this.tipoUva = tipoUva;
        }

        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } } //cambiar en todos. 

        public string getPorcentajeComposion { get { return descripcion; } }
        public float setPorcentajeComposicion { set { porcentajeComposion = value; } }

        public (string, float) getDatosVarietal()
        {
            return (this.tipoUva.getNombre, this.porcentajeComposion);
        }
    }
}
