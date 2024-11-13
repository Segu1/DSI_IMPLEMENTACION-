using BonVino.Gestor;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidades
{
    public class Vino : IAgregado
    {
        public int IdVino { get; set; }
        public float PrecioARS { get; set; }
        public string Nombre { get; set; }
        public int Añada { get; set; }
        public string ImagenEtiqueta { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public float NotaDeCataBodega { get; set; }
        public Bodega Bodega { get; set; }
        public List<Reseña> Reseñas { get; set; }
        public List<Varietal> Varietales { get; set; }

        public float promedioDeVinoEnPeriodo = 0;

        public Vino() { }

        public Vino(int idVino, float precioARS, string nombre, int añada, string imagenEtiqueta, DateTime fechaActualizacion, float notaDeCataBodega)
        {
            IdVino = idVino;
            PrecioARS = precioARS;
            Nombre = nombre;
            Añada = añada;
            ImagenEtiqueta = imagenEtiqueta;
            FechaActualizacion = fechaActualizacion;
            NotaDeCataBodega = notaDeCataBodega;
        }

        public float calcularPromedioDeReseñasEnPeriodo(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            // calcula si esta en periodo y si la reseña es de somelier

            int contador = 0;
            float acumulador = 0;

            IIterador iteradorReseña = CrearIterador(Reseñas.Cast<object>().ToList(), fechaDesdeSeleccionada, fechaHastaSeleccionada);
            iteradorReseña.primero();  // Asumiendo que esto mueve el iterador al primer elemento

            while (!iteradorReseña.haTerminado())  // Iterar hasta el final
            {
                Reseña reseñaActual = (Reseña)iteradorReseña.actual();
                // estamos en una reseña que cumple el filtro
                if (reseñaActual is not null)
                {
                    contador++;
                    acumulador += reseñaActual.Puntaje;
                }
                iteradorReseña.siguiente();
            }

            if (contador > 0)
            {
                return promedioDeVinoEnPeriodo = (acumulador / contador);
            }
            else
            {
                return -1;
            }
        }
        public IIterador CrearIterador(List<Object> elements, DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            // Crea y devuelve una instancia de IteradorReseña con la lista de reseñas y las fechas
            return new IteradorReseña(elements.OfType<Reseña>().ToList(), new List<DateTime> { fechaDesdeSeleccionada, fechaHastaSeleccionada });
        }
        public bool tieneReseñasEnPeriodo(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada)
        {
            // calcula y devuelve si tiene reseñas de vino.

            foreach (Reseña res in Reseñas)
            {
                if (res.estaEnPeriodo(fechaDesdeSeleccionada, fechaHastaSeleccionada) && res.sosDeSommelier())
                {
                    return true;
                }
            }
            return false;
        }


        public (string, float, string, string, string, List<(string, float)>) obtenerTodosLosDatos()
        {
            //obtiene los datos propios del vino y da comienzo a la busqueda de datos de ubicacion y varietales. 

            (string nombreBodega, string nombreRegion, string nombrePais) = this.Bodega.getDatosBodega(); ;

            return (this.Nombre, this.PrecioARS, nombreBodega, nombreRegion, nombrePais, this.obtenerDatosVarietal());
        }

        public List<(string, float)> obtenerDatosVarietal()
        {
            //da comienzo al loop "buscar varitales" y devuelve la lista de varietales

            List<(string, float)> varietales = [];

            IIterador iteradorVarietal = CrearIterador(Varietales.Cast<object>().ToList());
            iteradorVarietal.primero();

            while (!iteradorVarietal.haTerminado())  // Iterar hasta el final
            {
                Varietal varietalActual = (Varietal)iteradorVarietal.actual();
                if (varietalActual is not null)
                {
                    varietales.Add(varietalActual.getDatosVarietal());
                }
                iteradorVarietal.siguiente();
            }
            
            return varietales;
        }

        public IIterador CrearIterador(List<object> elements)
        {
            return new IteradorVarietal(elements.OfType<Varietal>().ToList());
        }
    }
}