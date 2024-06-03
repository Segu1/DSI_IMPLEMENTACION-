using BonVino.Entidades;
using BonVino.Gestor;
using System.DirectoryServices.ActiveDirectory;

namespace BonVino
{
    public partial class PantallaReportesDeRese�as : Form
    {
        bool periodoValido = false;
        bool confirmacion;
        DateTime fechaDesdeSeleccionada;
        DateTime fechaHastaSeleccionada;
        string tipoVisualizacionSeleccionada;
        string tipoRese�aSeleccionada;

        GestorReportesDeRese�as gestorReportesDeRese�a;

        public PantallaReportesDeRese�as()
        {
            InitializeComponent();
            gestorReportesDeRese�a = new GestorReportesDeRese�as(this);
            centrarTodosLosComponentes();
        }

        private void CenterControlInForm(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }

        public void tomarOpcionGenerarRankingVinos()
        {
            habilitarPantalla();
            gestorReportesDeRese�a.tomarOpcionGenerarRankingVinos();
        }

        private void habilitarPantalla()
        {
            this.Show();
        }

        public void solicitarFechaDesdeYHasta()
        {
            timePickerFechaDesde.Enabled = true;
        }

        public void solicitarTipoRese�a()
        {
            cbTipoRese�a.Enabled = true;
            txtTipoRese�a.Enabled = true;
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
            cbTipoRese�a.Items.Add("Sommelier");
            cbTipoRese�a.Items.Add("Amigos");
            cbTipoRese�a.Items.Add("Normal");

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
                cbTipoRese�a.SelectedIndex = -1;
                cbArchivoAExportar.SelectedIndex = -1;
                txtPeriodoNoValido.Visible = true;
                cbTipoRese�a.Enabled = false;
                cbArchivoAExportar.Enabled = false;
                txtTipoRese�a.Enabled = false;
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
                gestorReportesDeRese�a.tomarFechaDesdeYHasta(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
                cbTipoRese�a.Enabled = true;
                txtTipoRese�a.Enabled = true;
                if (cbArchivoAExportar.Enabled)
                {
                    btnConfirmar.Enabled = true;
                }
            }
            else
            {
                cbTipoRese�a.SelectedIndex = -1;
                cbArchivoAExportar.SelectedIndex = -1;
                cbArchivoAExportar.Enabled = false;
                txtPeriodoNoValido.Visible = true;
                cbTipoRese�a.Enabled = false;
                txtTipoRese�a.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }
        private void tomarTipoRese�a(object sender, EventArgs e)
        {
            if (cbTipoRese�a.SelectedItem != null)
            {
                tipoRese�aSeleccionada = cbTipoRese�a.SelectedItem as string;
                gestorReportesDeRese�a.tomarTipoRese�a(tipoRese�aSeleccionada);

            }
        }

        private void tomarTipoVisualizacionReporte(object sender, EventArgs e)
        {
            if (cbArchivoAExportar.SelectedItem != null)
            {
                tipoVisualizacionSeleccionada = cbArchivoAExportar.SelectedItem as string;
                gestorReportesDeRese�a.tomarTipoVisualizacionReporte(tipoVisualizacionSeleccionada);
            }
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            confirmacion = true;
            gestorReportesDeRese�a.tomarConfirmacion(confirmacion);

        }

        public void informarGeneracionExitosaDeArchivo()
        {
            DialogResult resultado = MessageBox.Show("El archivo se gener� exitosamente.", "Alerta", MessageBoxButtons.OKCancel);

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
        private void txtTipoRese�a_Click(object sender, EventArgs e)
        {
            cbTipoRese�a.Focus();
        }

        private void txtFechaDesde_Click(object sender, EventArgs e)
        {
            timePickerFechaDesde.Focus();

        }

        private void txtTipoRese�a_Click_1(object sender, EventArgs e)
        {
            cbTipoRese�a.Focus();
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
            CenterControlInForm(txtTipoRese�a);
            CenterControlInForm(txtArchivoAExportar);

            CenterControlInForm(timePickerFechaDesde);
            CenterControlInForm(timePickerFechaHasta);
            CenterControlInForm(cbArchivoAExportar);
            CenterControlInForm(cbTipoRese�a);
            CenterControlInForm(btnConfirmar);
            CenterControlInForm(btnCancelar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

