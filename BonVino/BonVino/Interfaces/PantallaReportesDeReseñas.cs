using BonVino.Entidades;
using BonVino.Gestor;

namespace BonVino
{
    public partial class habilitarPantalla : Form
    {
        Boolean periodoValido;
        GestorReportesDeRese�as gestor;
        public habilitarPantalla(GestorReportesDeRese�as Gestor)
        {
            InitializeComponent();
            Boolean periodoValido = false;
            GestorReportesDeRese�as gestor = Gestor;
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            cbArchivoAExportar.Items.Add("Excel");
            cbArchivoAExportar.Items.Add("Pantalla");
            cbArchivoAExportar.Items.Add("PDF");
            cbTipoRese�a.Items.Add("Sommelier");
            cbTipoRese�a.Items.Add("Amigos");
            cbTipoRese�a.Items.Add("Normal");

        }

        private Boolean validar_periodo(DateTime fechaDesde, DateTime fechaHasta)
        //valida que las fechas ingresadas esten en un periodo valido
        {
            if (fechaDesde >= fechaHasta || fechaHasta > DateTime.Now)
            {
                periodoValido = false;

            }
            else if (fechaHasta >= fechaDesde && fechaHasta < DateTime.Now)
            {
                periodoValido = true;

            }
            return periodoValido;
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

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            periodoValido = validar_periodo(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
            if (periodoValido)
            {
                txtPeriodoNoValido.Visible = false;
                gestor.setFechaHastaSeleccionada = timePickerFechaHasta.Value;


            }
            else {
                txtPeriodoNoValido.Visible = true;
            }

        }

        private void txtPeriodoNoValido_Click(object sender, EventArgs e)
        {

        }
        private void txtTipoRese�a_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoRese�a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
