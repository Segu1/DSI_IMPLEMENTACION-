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
            
        }




        private void InterfazExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
