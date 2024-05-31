using BonVino.Entidades;
using BonVino.Gestor;

namespace BonVino
{
    public partial class habilitarPantalla : Form
    {
        Boolean periodoValido;
        Boolean confirmacion;
        GestorReportesDeRese�as gestorReportesDeRese�a;
        public habilitarPantalla()
        {
            InitializeComponent();
            Boolean periodoValido = false;
            gestorReportesDeRese�a = new GestorReportesDeRese�as();

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
            DialogResult resultado = MessageBox.Show("Confirmar generacion", "Alerta", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                confirmacion = true;
                gestorReportesDeRese�a.tomarConfirmacion(confirmacion);
            }
            else {

            }
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

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            periodoValido = validar_periodo(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
            if (periodoValido)
            {
                txtPeriodoNoValido.Visible = false;
                gestorReportesDeRese�a.tomarFechaDesdeYHasta(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
                cbTipoRese�a.Enabled = true;
                txtTipoRese�a.Enabled = true;
            }
            else
            {
                txtPeriodoNoValido.Visible = true;
                cbTipoRese�a.Enabled = false;
                txtTipoRese�a.Enabled = false;
            }

        }

        private void cbTipoRese�a_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbTipoRese�a.SelectedItem != null)
            {
                string tipoRese�a = cbTipoRese�a.SelectedItem as string;
                gestorReportesDeRese�a.tomarTipoRese�a(tipoRese�a);
                // MessageBox.Show("Tipo: " + gestorReportesDeRese�a.getTipoRese�aSeleccionada + " Desde: " + gestorReportesDeRese�a.getFechaDesdeSeleccionada.ToString() + "Hasta: " + gestorReportesDeRese�a.getFechaHastaSeleccionada.ToString());
                cbArchivoAExportar.Enabled = true;
                txtArchivoAExportar.Enabled = true;
            }
        }

        private void cbArchivoAExportar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArchivoAExportar.SelectedItem != null)
            {
                string tipoArchivo = cbArchivoAExportar.SelectedItem as string;
                gestorReportesDeRese�a.tomarTipoVisualizacionReporte(tipoArchivo);
                cbArchivoAExportar.Enabled = true;
                txtArchivoAExportar.Enabled = true;
                btnConfirmar.Enabled = true;
            }
        }
    }
}

