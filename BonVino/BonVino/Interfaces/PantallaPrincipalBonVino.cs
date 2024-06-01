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
    public partial class PantallaPrincipalBonVino : Form
    {
        public PantallaPrincipalBonVino()
        {
            InitializeComponent();
        }

        private void btnGenerarRanking_Click(object sender, EventArgs e)
        {
            PantallaReportesDeReseñas pantallaPrincipalBonVino = new PantallaReportesDeReseñas();
            pantallaPrincipalBonVino.tomarOpcionGenerarRankingVinos();
            this.Hide();
        }

        private void PantallaPrincipalBonVino_Load(object sender, EventArgs e)
        {

        }
    }
}
