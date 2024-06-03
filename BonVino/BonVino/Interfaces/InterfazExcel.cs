using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonVino.Interfaces
{
    public partial class InterfazExcel : Form
    {
        public InterfazExcel()
        {
            InitializeComponent();
        }

        public void exportarAExcel(List<(string, float, string, string, string, List<(string, float)>, float)> datosAExportar)
        {
            // recorre cada dato de los vinos y los agrega a una fila. Luego, muestra la tabla con los resultados.
            foreach ((string, float, string, string, string, List<(string, float)>, float) datosVino in datosAExportar)
            {
                (string nombre, float precioARS, string bodega, string region, string pais, List<(string , float )> listaVarietales, float promedioCalificacion) = datosVino;
                string varietales = string.Join(", ", listaVarietales);
                listaRanking.Rows.Add(nombre, promedioCalificacion.ToString(), precioARS.ToString(), bodega, varietales, region, pais);
            }

            this.Show();
        }

        private void InterfazExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
