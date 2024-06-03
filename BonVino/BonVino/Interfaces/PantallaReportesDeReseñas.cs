using BonVino.Entidades;
using BonVino.Gestor;
using System.DirectoryServices.ActiveDirectory;

namespace BonVino
{
    public partial class PantallaReportesDeReseñas : Form
    {
        bool periodoValido = false;
        bool confirmacion;
        DateTime fechaDesdeSeleccionada;
        DateTime fechaHastaSeleccionada;
        string tipoVisualizacionSeleccionada;
        string tipoReseñaSeleccionada;

        GestorReportesDeReseñas gestorReportesDeReseña;

        public PantallaReportesDeReseñas()
        {
            InitializeComponent();
            gestorReportesDeReseña = new GestorReportesDeReseñas(this);
            centrarTodosLosComponentes();
        }

        private void CenterControlInForm(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }

        public void tomarOpcionGenerarRankingVinos()
        {
            habilitarPantalla();
            gestorReportesDeReseña.tomarOpcionGenerarRankingVinos();
        }

        private void habilitarPantalla()
        {
            this.Show();
        }

        public void solicitarFechaDesdeYHasta()
        {
            timePickerFechaDesde.Enabled = true;
        }

        public void solicitarTipoReseña()
        {
            cbTipoReseña.Enabled = true;
            txtTipoReseña.Enabled = true;
        }

        public void solicitarTipoVisualizacionReporte()
        {
            cbArchivoAExportar.Enabled = true;
            txtArchivoAExportar.Enabled = true;
        }

        public void solicitarConfirmacion()
        {
            btnConfirmar.Enabled = true;
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

        private Boolean validarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
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

        private void tomarFechaDesde(object sender, EventArgs e)
        {
            timePickerFechaHasta.Enabled = true;
            fechaDesdeSeleccionada = timePickerFechaDesde.Value;
            fechaHastaSeleccionada = timePickerFechaHasta.Value;
            periodoValido = validarPeriodo(fechaDesdeSeleccionada, fechaHastaSeleccionada);
            if (periodoValido)
            {
                txtPeriodoNoValido.Visible = false;
                if (cbArchivoAExportar.Enabled)
                {
                    btnConfirmar.Enabled = true;
                }

            }
            else
            {
                cbTipoReseña.SelectedIndex = -1;
                cbArchivoAExportar.SelectedIndex = -1;
                txtPeriodoNoValido.Visible = true;
                cbTipoReseña.Enabled = false;
                cbArchivoAExportar.Enabled = false;
                txtTipoReseña.Enabled = false;
                btnConfirmar.Enabled = false;

            }
        }

        private void tomarFechaHasta(object sender, EventArgs e)
        {
            fechaDesdeSeleccionada = timePickerFechaDesde.Value;
            fechaHastaSeleccionada = timePickerFechaHasta.Value;
            periodoValido = validarPeriodo(fechaDesdeSeleccionada, fechaHastaSeleccionada);

            if (periodoValido)
            {
                txtPeriodoNoValido.Visible = false;
                gestorReportesDeReseña.tomarFechaDesdeYHasta(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
                cbTipoReseña.Enabled = true;
                txtTipoReseña.Enabled = true;
                if (cbArchivoAExportar.Enabled)
                {
                    btnConfirmar.Enabled = true;
                }
            }
            else
            {
                cbTipoReseña.SelectedIndex = -1;
                cbArchivoAExportar.SelectedIndex = -1;
                cbArchivoAExportar.Enabled = false;
                txtPeriodoNoValido.Visible = true;
                cbTipoReseña.Enabled = false;
                txtTipoReseña.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }
        private void tomarTipoReseña(object sender, EventArgs e)
        {
            if (cbTipoReseña.SelectedItem != null)
            {
                tipoReseñaSeleccionada = cbTipoReseña.SelectedItem as string;
                gestorReportesDeReseña.tomarTipoReseña(tipoReseñaSeleccionada);

            }
        }

        private void tomarTipoVisualizacionReporte(object sender, EventArgs e)
        {
            if (cbArchivoAExportar.SelectedItem != null)
            {
                tipoVisualizacionSeleccionada = cbArchivoAExportar.SelectedItem as string;
                gestorReportesDeReseña.tomarTipoVisualizacionReporte(tipoVisualizacionSeleccionada);
            }
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            confirmacion = true;
            gestorReportesDeReseña.tomarConfirmacion(confirmacion);

        }

        public void informarGeneracionExitosaDeArchivo()
        {
            DialogResult resultado = MessageBox.Show("El archivo se generó exitosamente.", "Alerta", MessageBoxButtons.OKCancel);

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

        private void label1_Click_1(object sender, EventArgs e)
        {
            timePickerFechaHasta.Focus();
        }
        private void txtPeriodoNoValido_Click(object sender, EventArgs e)
        {

        }
        private void txtTipoReseña_Click(object sender, EventArgs e)
        {
            cbTipoReseña.Focus();
        }

        private void txtFechaDesde_Click(object sender, EventArgs e)
        {
            timePickerFechaDesde.Focus();

        }

        private void txtTipoReseña_Click_1(object sender, EventArgs e)
        {
            cbTipoReseña.Focus();
        }

        private void txtArchivoAExportar_Click(object sender, EventArgs e)
        {
            cbArchivoAExportar.Focus();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void centrarTodosLosComponentes()
        {
            CenterControlInForm(txtFechaDesde);
            CenterControlInForm(txtFechaHasta);
            CenterControlInForm(txtPeriodoNoValido);
            CenterControlInForm(txtTipoReseña);
            CenterControlInForm(txtArchivoAExportar);

            CenterControlInForm(timePickerFechaDesde);
            CenterControlInForm(timePickerFechaHasta);
            CenterControlInForm(cbArchivoAExportar);
            CenterControlInForm(cbTipoReseña);
            CenterControlInForm(btnConfirmar);
            CenterControlInForm(btnCancelar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

