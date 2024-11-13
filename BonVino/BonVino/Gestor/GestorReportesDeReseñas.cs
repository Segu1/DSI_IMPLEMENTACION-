using BonVino.Entidades;
using BonVino.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data.SQLite;
using System.Configuration;

namespace BonVino.Gestor
{
    public class GestorReportesDeReseñas : IAgregado
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["MyDatabaseContext"].ConnectionString;

        private DateTime fechaDesdeSeleccionada;
        private DateTime fechaHastaSeleccionada;
        private string tipoReseñasSeleccionada;
        private string tipoVisualizacionSeleccionada;
        private bool confirmacion;
        private PantallaReportesDeReseñas pantallaReportesDeReseñas;
        private List<Vino> vinos;
        private List<(string, float, string, string, string, List<(string, float)>, float)> datosDeVinosConPromedio;
        private InterfazExcel interfazExcel;

        //private string archivoExcel;
        public GestorReportesDeReseñas(PantallaReportesDeReseñas pantallaReportesDeReseñas)
        {
            this.pantallaReportesDeReseñas = pantallaReportesDeReseñas;
            this.vinos = new List<Vino>();
            this.interfazExcel = new InterfazExcel();
            this.datosDeVinosConPromedio = new List<(string, float, string, string, string, List<(string, float)>, float)>();
        }

        public DateTime getFechaDesdeSeleccionada { get { return fechaDesdeSeleccionada; } }


        public void tomarOpcionGenerarRankingVinos()
        {
            // da comienzo a la solicitud de ingreso de periodo
            pantallaReportesDeReseñas.solicitarFechaDesdeYHasta();
        }
        public void tomarFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            // toma y guarda el periodo y da comienzo a la solictud de un tipo de reseña.
            this.fechaDesdeSeleccionada = fechaDesde;
            this.fechaHastaSeleccionada = fechaHasta;

            pantallaReportesDeReseñas.solicitarTipoReseña();
        }

        public void tomarTipoReseña(string tipoReseña)
        {
            //toma y guarda el tipo de reseña seleccionada y da comienzo a la solictud de un tipo de visualización.
            this.tipoReseñasSeleccionada = tipoReseña;
            pantallaReportesDeReseñas.solicitarTipoVisualizacionReporte();
        }

        public void tomarTipoVisualizacionReporte(string tipoVisualizacion)
        {
            //toma y guarda el tipo de visualización y da comienzo a la solicitud de confimación.
            this.tipoVisualizacionSeleccionada = tipoVisualizacion;
            pantallaReportesDeReseñas.solicitarConfirmacion();
        }

        public void tomarConfirmacion(bool confirmado)
        {
            // toma y guarda la confirmacion y realiza da comienzo a la generacion del ranking.

            this.confirmacion = confirmado;
            buscarVinosConReseñasEnPeriodo();

            //en caso de que no existan reseñas en periodo cargadas por sommeliers, se le notifica al usuario
            if (datosDeVinosConPromedio.Count() == 0)
            {
                pantallaReportesDeReseñas.informarFaltaReseñas();
                return;
            }

            ordenarVinosPorPromedioYFiltrarPrimeros10();
            generarArchivo();
            pantallaReportesDeReseñas.informarGeneracionExitosaDeArchivo();

            finCU();
        }

        public DateTime getFechaHastaSeleccionada { get { return fechaHastaSeleccionada; } }

        public string getTipoReseñaSeleccionada { get { return tipoReseñasSeleccionada; } }

        public string getTipoVisualizacion { get { return tipoVisualizacionSeleccionada; } }

        public bool getConfirmacion { get { return confirmacion; } }

        public void buscarVinosConReseñasEnPeriodo()
        {
            ObtenerVinos();

            string nombres = string.Join("\n", vinos.Select(v => v.Nombre));

            IIterador iteradorDeVinos = CrearIterador(vinos.Cast<object>().ToList());
            iteradorDeVinos.primero();  // Asumiendo que esto mueve el iterador al primer elemento
            while (!iteradorDeVinos.haTerminado())  // Iterar hasta el final
            {
                Vino vinoActual = (Vino)iteradorDeVinos.actual();
                if (vinoActual is not null)
                {

                    //estamso en un vino qu ecumple el filtro
                    float promedioDeReseñasEnPeriodo = vinoActual.calcularPromedioDeReseñasEnPeriodo(this.fechaDesdeSeleccionada, this.fechaHastaSeleccionada);
                    if (promedioDeReseñasEnPeriodo  != -1) {
                        (string nombre, float precioARS, string bodega, string region, string pais, List<(string tipoUva, float porcentaje)> varietales) = vinoActual.obtenerTodosLosDatos();
                        datosDeVinosConPromedio.Add((nombre, precioARS, bodega, region, pais, varietales, promedioDeReseñasEnPeriodo));
                    }

                    iteradorDeVinos.siguiente();  // Mover al siguiente elemento

                }
            }

        }

        public IIterador CrearIterador(List<Object> elements)
        {
            // Crea y devuelve una instancia de IteradorVinos con la lista de vinos y las fechas
            return new IteradorVinos(elements.OfType<Vino>().ToList(), new List<DateTime> { fechaDesdeSeleccionada, fechaHastaSeleccionada });
        }

        public void ordenarVinosPorPromedioYFiltrarPrimeros10()
        {
            // ordena todos los vinos segun el promedio de calificaciones de mayor a menor, y luego filtra los primeros 10.

            datosDeVinosConPromedio.Sort((x, y) => y.Item7.CompareTo(x.Item7));
            if (datosDeVinosConPromedio.Count > 10)
            {
                datosDeVinosConPromedio.RemoveRange(10, this.datosDeVinosConPromedio.Count - 10);
            }
        }
        public void generarArchivo()
        {
            // da comienzo a la generacion del archivo con los resultados del ranking.

            // archivoExcel = gestorExcel.generarArchivo()
            interfazExcel.exportarAExcel(datosDeVinosConPromedio);
        }

        public void finCU()
        {
            pantallaReportesDeReseñas.WindowState = FormWindowState.Minimized;
        }


        public void ObtenerVinos()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Vino";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Vino vino = new Vino()
                        {
                            IdVino = int.Parse(dr["id"].ToString()),
                            Nombre = dr["nombre"].ToString(),
                            PrecioARS = float.Parse(dr["precioARS"].ToString()),
                            Añada = int.Parse(dr["añada"].ToString()),
                            ImagenEtiqueta = dr["imagen_etiqueta"].ToString(),
                            FechaActualizacion = dr.IsDBNull(dr.GetOrdinal("fecha_actualizacion")) ? DateTime.MinValue : dr.GetDateTime(dr.GetOrdinal("fecha_actualizacion")),
                            NotaDeCataBodega = float.Parse(dr["nota_de_cata_bodega"].ToString()),
                        };

                        vino.Reseñas = ObtenerReseñasPorVino(vino.IdVino, conexion);
                        vino.Bodega = ObtenerBodegaDeVino(vino.IdVino, conexion);
                        vino.Varietales = ObtenerVarietalesDeVino(vino.IdVino, conexion);
                        vinos.Add(vino);
                    }
                }

            }
        }
        private List<Reseña> ObtenerReseñasPorVino(int idVino, SQLiteConnection conexion)
        {
            List<Reseña> reseñas = new List<Reseña>();
            string queryReseña = "SELECT * FROM Reseña WHERE id_vino = @IdVino";
            SQLiteCommand cmdReseña = new SQLiteCommand(queryReseña, conexion);
            cmdReseña.Parameters.AddWithValue("@IdVino", idVino);

            using (SQLiteDataReader drReseña = cmdReseña.ExecuteReader())
            {
                while (drReseña.Read())
                {
                    reseñas.Add(new Reseña()
                    {
                        IdReseña = drReseña.IsDBNull(drReseña.GetOrdinal("id")) ? 0 : int.Parse(drReseña["id"].ToString()),
                        EsPremium = !drReseña.IsDBNull(drReseña.GetOrdinal("es_premium")) && drReseña.GetBoolean(drReseña.GetOrdinal("es_premium")),
                        FechaReseña = drReseña.IsDBNull(drReseña.GetOrdinal("fecha_reseña")) ? DateTime.MinValue : drReseña.GetDateTime(drReseña.GetOrdinal("fecha_reseña")),
                        Puntaje = drReseña.IsDBNull(drReseña.GetOrdinal("puntaje")) ? 0 : float.Parse(drReseña["puntaje"].ToString()),
                        Comentario = drReseña["comentario"]?.ToString() ?? string.Empty,
                        IdVino = idVino,
                    });
                }
            }
            return reseñas;
        }
        private Bodega ObtenerBodegaDeVino(int idVino, SQLiteConnection conexion)
        {
            Bodega bodega = null;
            string query = "SELECT * FROM Bodega WHERE id = (SELECT id_bodega FROM Vino WHERE id = @IdVino)";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdVino", idVino);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    bodega = new Bodega()
                    {
                        Descripcion = dr["descripcion"].ToString(),
                        IdBodega = int.Parse(dr["id"].ToString()),
                        Nombre = dr["nombre"].ToString(),
                        IdRegion = int.Parse(dr["id_region_vitivinicola"].ToString())
                    };
                }
            }
            bodega.RegionVitivinicola = ObtenerRegionDeBodega(bodega.IdBodega, conexion);
            return bodega;
        }
        private RegionVitivinicola ObtenerRegionDeBodega(int idBodega, SQLiteConnection conexion)
        {
            RegionVitivinicola region = null;
            string query = "SELECT * FROM RegionVitivinicola WHERE id = (SELECT id_region_vitivinicola FROM Bodega WHERE id = @IdBodega)";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdBodega", idBodega);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    region = new RegionVitivinicola()
                    {
                        IdRegionVitivinicola = int.Parse(dr["id"].ToString()),
                        Nombre = dr["nombre"].ToString(),
                        IdProvincia = int.Parse(dr["id_provincia"].ToString())
                    };
                }
            }
            region.Provincia = ObtenerProvinciaDeRegion(region.IdRegionVitivinicola, conexion);
            return region;
        }
        private Provincia ObtenerProvinciaDeRegion(int idRegion, SQLiteConnection conexion)
        {
            Provincia provincia = null;
            string query = "SELECT * FROM Provincia WHERE id = (SELECT id_provincia FROM RegionVitivinicola WHERE id = @IdRegion)";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdRegion", idRegion);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    provincia = new Provincia()
                    {
                        IdProvincia = int.Parse(dr["id"].ToString()),
                        Nombre = dr["nombre"].ToString(),
                        IdPais = int.Parse(dr["pais_id"].ToString())
                    };
                }
            }
            provincia.Pais = ObtenerPaisDeProvincia(provincia.IdProvincia, conexion);
            return provincia;
        }
        private Pais ObtenerPaisDeProvincia(int idProvincia, SQLiteConnection conexion)
        {
            Pais pais = null;
            string query = "SELECT * FROM Pais WHERE id = (SELECT pais_id FROM Provincia WHERE id = @IdProvincia)";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdProvincia", idProvincia);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    pais = new Pais()
                    {
                        IdPais = int.Parse(dr["id"].ToString()),
                        Nombre = dr["nombre"].ToString()
                    };
                }
            }
            return pais;
        }

        private List<Varietal> ObtenerVarietalesDeVino(int idVino, SQLiteConnection conexion)
        {
            List<Varietal> varietales = new List<Varietal>();
            string query = "SELECT * FROM Varietal WHERE id IN (SELECT id_varietal FROM VarietalXVino WHERE id_vino = @IdVino)";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdVino", idVino);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Varietal varietal = new Varietal()
                    {
                        IdVarietal = int.Parse(dr["id"].ToString()),
                        Descripcion = dr["descripcion"].ToString()
                    };

                    // Obtener el TipoUva para este varietal
                    varietal.TipoUva = ObtenerTipoDeUvaDeVarietal(varietal.IdVarietal, conexion);

                    // Añadir el varietal con su TipoUva
                    varietales.Add(varietal);
                }
            }
            return varietales;
        }

        private TipoUva ObtenerTipoDeUvaDeVarietal(int idVarietal, SQLiteConnection conexion)
        {
            TipoUva tipoUva = null;
            string query = "SELECT * FROM TipoUva WHERE id = (SELECT id_tipo_uva FROM Varietal WHERE id = @IdVarietal)";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdVarietal", idVarietal);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    tipoUva = new TipoUva()
                    {
                        IdTipoUva = int.Parse(dr["id"].ToString()),
                        Nombre = dr["nombre"].ToString()
                    };
                }
            }
            return tipoUva;
        }

    }
}
