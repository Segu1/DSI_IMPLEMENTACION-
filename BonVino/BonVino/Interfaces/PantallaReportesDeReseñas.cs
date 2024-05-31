using BonVino.Entidades;
using BonVino.Gestor;

namespace BonVino
{
    public partial class habilitarPantalla : Form
    {
        Boolean periodoValido;
        Boolean confirmacion;
        GestorReportesDeReseñas gestorReportesDeReseña;
        public habilitarPantalla()
        {
            InitializeComponent();
            Boolean periodoValido = false;
            gestorReportesDeReseña = new GestorReportesDeReseñas();

        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            cbArchivoAExportar.Items.Add("Excel");
            cbArchivoAExportar.Items.Add("Pantalla");
            cbArchivoAExportar.Items.Add("PDF");
            cbTipoReseña.Items.Add("Sommelier");
            cbTipoReseña.Items.Add("Amigos");
            cbTipoReseña.Items.Add("Normal");

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
                gestorReportesDeReseña.tomarConfirmacion(confirmacion);
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
        private void txtTipoReseña_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoReseña_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            periodoValido = validar_periodo(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
            if (periodoValido)
            {
                txtPeriodoNoValido.Visible = false;
                gestorReportesDeReseña.tomarFechaDesdeYHasta(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
                cbTipoReseña.Enabled = true;
                txtTipoReseña.Enabled = true;
            }
            else
            {
                txtPeriodoNoValido.Visible = true;
                cbTipoReseña.Enabled = false;
                txtTipoReseña.Enabled = false;
            }

        }

        private void cbTipoReseña_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbTipoReseña.SelectedItem != null)
            {
                string tipoReseña = cbTipoReseña.SelectedItem as string;
                gestorReportesDeReseña.tomarTipoReseña(tipoReseña);
                // MessageBox.Show("Tipo: " + gestorReportesDeReseña.getTipoReseñaSeleccionada + " Desde: " + gestorReportesDeReseña.getFechaDesdeSeleccionada.ToString() + "Hasta: " + gestorReportesDeReseña.getFechaHastaSeleccionada.ToString());
                cbArchivoAExportar.Enabled = true;
                txtArchivoAExportar.Enabled = true;
            }
        }

        private void cbArchivoAExportar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArchivoAExportar.SelectedItem != null)
            {
                string tipoArchivo = cbArchivoAExportar.SelectedItem as string;
                gestorReportesDeReseña.tomarTipoVisualizacionReporte(tipoArchivo);
                cbArchivoAExportar.Enabled = true;
                txtArchivoAExportar.Enabled = true;
                btnConfirmar.Enabled = true;
            }
        }
    }
}

