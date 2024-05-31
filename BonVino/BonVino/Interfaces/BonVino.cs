using BonVino.Entidades;

namespace BonVino
{
    public partial class habilitarPantalla : Form
    {
        Boolean periodoActivo;
        public habilitarPantalla()
        {
            InitializeComponent();
            Boolean periodoActivo = false;
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            cbArchivoAExportar.Items.Add("Excel");
            cbArchivoAExportar.Items.Add("Pantalla");
            cbArchivoAExportar.Items.Add("PDF");
            cbTipoReseña.Items.Add("Sommelier");
            cbTipoReseña.Items.Add("Amigos");
            cbTipoReseña.Items.Add("Normales");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public string GetSelectedComboBoxItem()
        {
            if (cbArchivoAExportar.SelectedItem != null)
            {
                return (String)cbArchivoAExportar.SelectedItem;
            }
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            if (timePickerFechaDesde.Value >= timePickerFechaHasta.Value)
            {
                txtPeriodoNoValido.Visible = true;
                periodoActivo = false;
            }
            else if (timePickerFechaHasta.Value >= timePickerFechaDesde.Value)
            {
                txtPeriodoNoValido.Visible = false;
                periodoActivo = true;
            };
        }

        private void txtPeriodoNoValido_Click(object sender, EventArgs e)
        {

        }


        private void timePickerFechaDesde_ValueChanged_1(object sender, EventArgs e)
        {
            if (timePickerFechaDesde.Value >= timePickerFechaHasta.Value)
            {
                txtPeriodoNoValido.Visible = true;
                periodoActivo = false;
            }
            else if (timePickerFechaHasta.Value >= timePickerFechaDesde.Value)
            {
                txtPeriodoNoValido.Visible = false;
                periodoActivo = true;
            };
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
