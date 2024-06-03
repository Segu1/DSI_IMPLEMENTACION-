using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BonVino.Interfaces
{
    public partial class PantallaPrincipalBonVino : Form
    {
        public PantallaPrincipalBonVino()
        {
            InitializeComponent();
            CenterControlInForm(btnGenerarRanking);  // Centrar el botón


        }

        private void CenterControlInForm(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
            control.Top = (this.ClientSize.Height - control.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnGenerarRanking_Click(object sender, EventArgs e)
        {
            PantallaReportesDeReseñas pantallaPrincipalBonVino = new PantallaReportesDeReseñas();
            pantallaPrincipalBonVino.tomarOpcionGenerarRankingVinos();
            // para volver a la pantalla principal en caso de cancelar o de que no hay resñas hay q cambiar aca

            this.Hide();
        }

        private void PantallaPrincipalBonVino_Load(object sender, EventArgs e)
        {

        }
    }
}
