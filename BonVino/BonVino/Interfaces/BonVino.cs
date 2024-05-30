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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vino nuevoVino = new Vino("OtroLocoMas", "DonBosco");
            nuevoVino.NombreVino = "OtraLocaMas";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public string GetSelectedComboBoxItem()
        {
            if (comboBox1.SelectedItem != null)
            {
                return (String)comboBox1.SelectedItem;
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
            else if(timePickerFechaHasta.Value >= timePickerFechaDesde.Value)
            {
                txtPeriodoNoValido.Visible = false;
                periodoActivo = true;
            };
        }
    }
}
