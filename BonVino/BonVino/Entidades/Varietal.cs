using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Varietal
    {
        private int IdVarietal;
        private string Descripcion;
        private float PorcentajeComposicion;
        private int IdTipoUva;
        public TipoUva TipoUva { get; set; }

        public int getIdTipoUva() { return IdTipoUva; }
        public void setIdTipoUva(int value) { IdTipoUva = value; }
        public int getIdVarietal() { return IdVarietal; }
        public void setIdVarietal(int value) { IdVarietal = value; }
        public string etDescripcion() { return Descripcion; }
        public void setDescripcion(string value) { Descripcion = value; }
        public float getPorcentajeComposicion() { return PorcentajeComposicion; }
        public void setPorcentajeComposicion(float value) { PorcentajeComposicion = value; }

        public Varietal() { }
        public Varietal(int idVarietal, string descripcion, float porcentajeComposion, int idTipoUva)
        {
            IdVarietal = idVarietal;
            Descripcion = descripcion;
            PorcentajeComposicion = porcentajeComposion;
            IdTipoUva = idTipoUva;
        }

        public (string, float) getDatosVarietal()
        {
            return (this.TipoUva.getNombre(), this.PorcentajeComposicion);
        }
    }
}
