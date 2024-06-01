using BonVino.Entidades;
using BonVino.Gestor;
using System.DirectoryServices.ActiveDirectory;

namespace BonVino
{
    public partial class PantallaReportesDeRese�as : Form
    {
        bool periodoValido = false;
        bool confirmacion;
        GestorReportesDeRese�as gestorReportesDeRese�a;



        public PantallaReportesDeRese�as()
        {
            InitializeComponent();
            gestorReportesDeRese�a = new GestorReportesDeRese�as(this);
        }

        public void tomarOpcionGenerarRankingVinos()
        {
            habilitarPantalla();
            //gestorReportesDeRese�a.tomarOpcionGenerarRankingVinos();
        }

        private void habilitarPantalla()
        {
            this.Show();
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
            else
            {
                
                this.Close();
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

        private void cbTipoRese�a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void timePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    periodoValido = validar_periodo(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
        //    if (periodoValido)
        //    {
        //        txtPeriodoNoValido.Visible = false;
        //        gestorReportesDeRese�a.tomarFechaDesdeYHasta(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
        //        cbTipoRese�a.Enabled = true;
        //        txtTipoRese�a.Enabled = true;
        //    }
        //    else
        //    {
        //        txtPeriodoNoValido.Visible = true;
        //        cbTipoRese�a.Enabled = false;
        //        txtTipoRese�a.Enabled = false;
        //    }

        //}

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
                btnConfirmar.Enabled = true;
            }            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtTipoRese�a_Click_1(object sender, EventArgs e)
        {
            cbTipoRese�a.Focus();
        }

        private void txtArchivoAExportar_Click(object sender, EventArgs e)
        {
            cbArchivoAExportar.Focus();
        }

        private void timePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            {
                timePickerFechaHasta.Enabled = true;
                periodoValido = validar_periodo(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
                if (periodoValido)
                {
                    txtPeriodoNoValido.Visible = false;
                    if (cbArchivoAExportar.Enabled) {
                        btnConfirmar.Enabled = true;
                    } //encapsular en funcion

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
        }

        private void timePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            periodoValido = validar_periodo(timePickerFechaDesde.Value, timePickerFechaHasta.Value);
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
    }
}

