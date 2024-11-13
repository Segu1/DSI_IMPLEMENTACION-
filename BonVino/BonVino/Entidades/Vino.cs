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
        private int IdVino { get; set; }

        private float PrecioARS;
        private string Nombre { get; set; }
        private int Añada { get; set; }
        private string ImagenEtiqueta { get; set; }
        private DateTime FechaActualizacion { get; set; }
        private float NotaDeCataBodega { get; set; }
        public Bodega Bodega { get; set; }
        public List<Reseña> Reseñas { get; set; }
        public List<Varietal> Varietales { get; set; }

        public int getIdVino() { return IdVino; }
        public void setIdVino(int value) { IdVino = value; }
        public float getPrecioARS() { return PrecioARS; }
        public void setPrecioARS(float value) { PrecioARS = value; }
        public string getNombre() { return Nombre; }
        public void setNombre(string value) { Nombre = value; }
        public int getAñada () { return Añada; }
        public void setAñada(int value) { Añada = value; }
        public string getImagenEtiqueta() { return ImagenEtiqueta; }
        public void setImagenEtiqueta(string value) { ImagenEtiqueta = value; }
        public float getNotaDeCataBodega() { return NotaDeCataBodega; }
        public void setNotaDeCataBodega(float value) { NotaDeCataBodega = value; }
        public DateTime getFechaActualizacion() { return FechaActualizacion; }
        public void setFechaActualizacion(DateTime value) { FechaActualizacion = value; }

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

        public float calcularPromedioDeReseñasEnPeriodo(List<DateTime> filtros)
        {
            DateTime fechaDesdeSeleccionada = filtros[0];
            DateTime fechaHastaSeleccionada = filtros[1];
            // calcula si esta en periodo y si la reseña es de somelier

            int contador = 0;
            float acumulador = 0;

            IIterador iteradorReseña = CrearIterador(Reseñas.Cast<object>().ToList(), filtros);
            iteradorReseña.primero();  // Asumiendo que esto mueve el iterador al primer elemento

            while (!iteradorReseña.haTerminado())  // Iterar hasta el final
            {
                Reseña reseñaActual = (Reseña)iteradorReseña.actual();
                // estamos en una reseña que cumple el filtro
                if (reseñaActual is not null)
                {
                    contador++;
                    acumulador += reseñaActual.getPuntaje();
                }
                iteradorReseña.siguiente();
            }

            return calcularPromedio(contador, acumulador);
        }

        public float calcularPromedio(int cantidadReseñas, float puntajeAcumulado)
        {
            if (cantidadReseñas > 0)
            {
                return (puntajeAcumulado / cantidadReseñas);
            }
            else
            {
                return -1;
            }
        }
        public IIterador CrearIterador(List<Object> elements, List<DateTime> filtros)
        {
            DateTime fechaDesdeSeleccionada = filtros[0];
            DateTime fechaHastaSeleccionada = filtros[1];
            // Crea y devuelve una instancia de IteradorReseña con la lista de reseñas y las fechas
            return new IteradorReseña(elements.OfType<Reseña>().ToList(), filtros);
        }
        public bool tieneReseñasEnPeriodo(List<DateTime> filtros)
        {
            DateTime fechaDesdeSeleccionada = filtros[0];
            DateTime fechaHastaSeleccionada = filtros[1];
            
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

            return (this.Nombre, this.PrecioARS, nombreBodega, nombreRegion, nombrePais, this.obtenerDatosVarietales());
        }

        public List<(string, float)> obtenerDatosVarietales()
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