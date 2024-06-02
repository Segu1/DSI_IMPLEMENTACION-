using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BonVino.Entidades
{
    public class Vino
    {
        private string nombre;
        private Bodega bodega;
        private float precioARS;
        private List<Reseña> reseñas; 
        private List<Varietal> varietal;
        private int añada;
        private DateTime fechaActualizacion;

        public Vino(string nombre, Bodega bodega, float precioARS, List<Varietal> varietal)
        {
            this.nombre = nombre;
            this.bodega = bodega;
            this.precioARS = precioARS;
            this.reseñas = new List<Reseña>();
            this.varietal = varietal; //a chequear

        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public float getPrecioARS  { get { return precioARS; } }
        public float setPrecioARS { set { precioARS = value; } }

        

        public void agregarReseña(Reseña res)
        {
            reseñas.Add(res);
        }

        public void eliminarReseña(Reseña res){
            reseñas.Remove(res);
        }


        public void AgregarVarietal(Varietal var)
        {
            varietal.Add(var);
        }

        public void eliminarReseña(Varietal var)
        {
            varietal.Remove(var);
        }



        public float calcularPromedioDeReseñasEnPeriodo(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            float contador = 0;
            float acumulador = 0;
            foreach (Reseña res in reseñas) {
                if(res.estaEnPeriodo(fechaDesdeSeleccionada, fechaHastaSeleccionada) && res.sosDeSommelier())
                {
                    contador++;
                    acumulador += res.getPuntaje;
                };
            
            }

            if (contador > 0)
            {
                return (acumulador / contador);
            }
            else
            {
                return -1; 
            }
        }

        public (string, float, string, string,string, List<(string, float)>) obtenerTodosLosDatos()
        {
            (string nombreBodega, string nombreRegion, string nombrePais) = this.obtenerDatosBodegaRegionPais();

            return (this.getNombre, this.getPrecioARS, nombreBodega, nombreRegion, nombrePais, this.obtenerDatosVarietal());
        }

        public (string, string, string) obtenerDatosBodegaRegionPais()
        {
            return this.bodega.getDatosBodega();

        }

        public List<(string, float)> obtenerDatosVarietal()
        {
            List<(string, float)> varietales = [];

            foreach (Varietal var in this.varietal)
            {
                varietales.Add(var.getDatosVarietal());
            }
            return varietales;
        }
    }
}