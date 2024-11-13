using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Varietal
    {
        public int IdVarietal { get; set; }
        public string Descripcion { get; set; }
        public float PorcentajeComposion { get; set; }
        public int IdTipoUva { get; set; }
        public TipoUva TipoUva { get; set; }

        public Varietal() { }
        public Varietal(int idVarietal, string descripcion, float porcentajeComposion, int idTipoUva)
        {
            IdVarietal = idVarietal;
            Descripcion = descripcion;
            PorcentajeComposion = porcentajeComposion;
            IdTipoUva = idTipoUva;
        }

        public (string, float) getDatosVarietal()
        {
            return (this.TipoUva.Nombre, this.PorcentajeComposion);
        }
    }
}
