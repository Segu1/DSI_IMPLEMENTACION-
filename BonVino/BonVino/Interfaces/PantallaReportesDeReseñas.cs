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

        public void tomarOpcionGenerarRankingVinos()
        {
            //inicializa la pantalla y dispara la secuencia del caso de uso.
            habilitarPantalla();
            gestorReportesDeRese�a.tomarOpcionGenerarRankingVinos();
        }

        private void habilitarPantalla()
        {
            this.Show();
        }

        public void solicitarFechaDesdeYHasta()
        {
            //habilita el input fecha desde.
            timePickerFechaDesde.Enabled = true;
        }

        public void solicitarTipoRese�a()
        {
            //habilita el input tipo rese�a.
            cbTipoRese�a.Enabled = true;
            txtTipoRese�a.Enabled = true;
        }

        public void solicitarTipoVisualizacionReporte()
        {
            //habilita el input tipo visualizacion.
            cbArchivoAExportar.Enabled = true;
            txtArchivoAExportar.Enabled = true;
        }

        public void solicitarConfirmacion()
        {
            //habilita el boton de confirmacion.
            btnConfirmar.Enabled = true;
        }

        private bool validarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            //valida que las fechas ingresadas esten en un periodo valido ( fecha hasta > fecha desde).

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
            // toma la fecha desde y si se valida el periodo, habilita la fecha hasta, sino la deshabilita

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
            // toma la fecha hasta y si se valida el periodo, se envia las fechas desde y hasta al gestor.

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
            //toma el tipo de rese�a y se la envia al gestor
            if (cbTipoRese�a.SelectedItem != null)
            {
                tipoRese�aSeleccionada = cbTipoRese�a.SelectedItem as string;
                gestorReportesDeRese�a.tomarTipoRese�a(tipoRese�aSeleccionada);

            }
        }

        private void tomarTipoVisualizacionReporte(object sender, EventArgs e)
        {
            //toma el tipo de visualizacion y se la envia al gestor
            if (cbArchivoAExportar.SelectedItem != null)
            {
                tipoVisualizacionSeleccionada = cbArchivoAExportar.SelectedItem as string;
                gestorReportesDeRese�a.tomarTipoVisualizacionReporte(tipoVisualizacionSeleccionada);
            }
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            //toma el la confirmacion y se la envia al gestor
            confirmacion = true;
            gestorReportesDeRese�a.tomarConfirmacion(confirmacion);

        }

        public void informarGeneracionExitosaDeArchivo()
        {
            //informa al usuario que el archivo se ha generado.
            DialogResult resultado = MessageBox.Show("El archivo se gener� exitosamente.", "Alerta", MessageBoxButtons.OKCancel);

        }

        internal void informarFaltaRese�as()
        {
            MessageBox.Show("No hay rese�as creadas por sommeliers");
            this.Close();
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
        private void CenterControlInForm(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
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

    }

}

