using System.Drawing.Text;

namespace BonVino
{
    partial class PantallaReportesDeReseñas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaReportesDeReseñas));
            btnConfirmar = new Button();
            timePickerFechaDesde = new DateTimePicker();
            timePickerFechaHasta = new DateTimePicker();
            txtPeriodoNoValido = new Label();
            txtFechaDesde = new Label();
            txtFechaHasta = new Label();
            txtArchivoAExportar = new Label();
            cbArchivoAExportar = new ComboBox();
            txtTipoReseña = new Label();
            cbTipoReseña = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = true;
            btnConfirmar.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmar.Cursor = Cursors.AppStarting;
            btnConfirmar.Enabled = false;
            btnConfirmar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ActiveCaptionText;
            btnConfirmar.Location = new Point(27, 430);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(173, 68);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += tomarConfirmacion;
            // 
            // timePickerFechaDesde
            // 
            timePickerFechaDesde.CalendarForeColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarMonthBackground = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarTitleBackColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarTitleForeColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarTrailingForeColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.Location = new Point(27, 69);
            timePickerFechaDesde.Name = "timePickerFechaDesde";
            timePickerFechaDesde.Size = new Size(300, 25);
            timePickerFechaDesde.TabIndex = 4;
            timePickerFechaDesde.ValueChanged += tomarFechaDesde;
            // 
            // timePickerFechaHasta
            // 
            timePickerFechaHasta.Enabled = false;
            timePickerFechaHasta.Location = new Point(27, 150);
            timePickerFechaHasta.Name = "timePickerFechaHasta";
            timePickerFechaHasta.Size = new Size(300, 25);
            timePickerFechaHasta.TabIndex = 5;
            timePickerFechaHasta.ValueChanged += tomarFechaHasta;
            // 
            // txtPeriodoNoValido
            // 
            txtPeriodoNoValido.AutoSize = true;
            txtPeriodoNoValido.BackColor = Color.Transparent;
            txtPeriodoNoValido.ForeColor = SystemColors.GradientActiveCaption;
            txtPeriodoNoValido.Location = new Point(27, 190);
            txtPeriodoNoValido.Name = "txtPeriodoNoValido";
            txtPeriodoNoValido.Size = new Size(275, 17);
            txtPeriodoNoValido.TabIndex = 8;
            txtPeriodoNoValido.Text = "*Ingrese un periodo de fechas valido";
            txtPeriodoNoValido.Visible = false;
            txtPeriodoNoValido.Click += txtPeriodoNoValido_Click;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.AutoSize = true;
            txtFechaDesde.BackColor = Color.Transparent;
            txtFechaDesde.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaDesde.ForeColor = Color.White;
            txtFechaDesde.Location = new Point(27, 43);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(136, 23);
            txtFechaDesde.TabIndex = 9;
            txtFechaDesde.Text = "Fecha desde";
            txtFechaDesde.Click += txtFechaDesde_Click;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.AutoSize = true;
            txtFechaHasta.BackColor = Color.Transparent;
            txtFechaHasta.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaHasta.ForeColor = Color.White;
            txtFechaHasta.Location = new Point(27, 124);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(129, 23);
            txtFechaHasta.TabIndex = 10;
            txtFechaHasta.Text = "Fecha hasta";
            txtFechaHasta.Click += label1_Click_1;
            // 
            // txtArchivoAExportar
            // 
            txtArchivoAExportar.AutoSize = true;
            txtArchivoAExportar.BackColor = Color.Transparent;
            txtArchivoAExportar.Enabled = false;
            txtArchivoAExportar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArchivoAExportar.ForeColor = Color.White;
            txtArchivoAExportar.Location = new Point(27, 290);
            txtArchivoAExportar.Name = "txtArchivoAExportar";
            txtArchivoAExportar.Size = new Size(186, 23);
            txtArchivoAExportar.TabIndex = 11;
            txtArchivoAExportar.Text = "Archivo a generar";
            txtArchivoAExportar.Click += txtArchivoAExportar_Click;
            // 
            // cbArchivoAExportar
            // 
            cbArchivoAExportar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArchivoAExportar.Enabled = false;
            cbArchivoAExportar.FormattingEnabled = true;
            cbArchivoAExportar.Location = new Point(27, 326);
            cbArchivoAExportar.Name = "cbArchivoAExportar";
            cbArchivoAExportar.Size = new Size(300, 25);
            cbArchivoAExportar.TabIndex = 12;
            cbArchivoAExportar.SelectedIndexChanged += tomarTipoVisualizacionReporte;
            // 
            // txtTipoReseña
            // 
            txtTipoReseña.AutoSize = true;
            txtTipoReseña.BackColor = Color.Transparent;
            txtTipoReseña.Enabled = false;
            txtTipoReseña.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoReseña.ForeColor = Color.White;
            txtTipoReseña.Location = new Point(27, 225);
            txtTipoReseña.Name = "txtTipoReseña";
            txtTipoReseña.Size = new Size(156, 23);
            txtTipoReseña.TabIndex = 13;
            txtTipoReseña.Text = "Tipo de reseña";
            txtTipoReseña.Click += txtTipoReseña_Click_1;
            // 
            // cbTipoReseña
            // 
            cbTipoReseña.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoReseña.Enabled = false;
            cbTipoReseña.FormattingEnabled = true;
            cbTipoReseña.Location = new Point(27, 251);
            cbTipoReseña.Name = "cbTipoReseña";
            cbTipoReseña.Size = new Size(300, 25);
            cbTipoReseña.TabIndex = 14;
            cbTipoReseña.SelectedIndexChanged += tomarTipoReseña;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 334);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 15;
            label1.Click += label1_Click_2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PeachPuff;
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(64, 531);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // PantallaReportesDeReseñas
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 653);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(cbTipoReseña);
            Controls.Add(txtTipoReseña);
            Controls.Add(cbArchivoAExportar);
            Controls.Add(txtArchivoAExportar);
            Controls.Add(txtFechaHasta);
            Controls.Add(txtFechaDesde);
            Controls.Add(timePickerFechaDesde);
            Controls.Add(txtPeriodoNoValido);
            Controls.Add(timePickerFechaHasta);
            Controls.Add(btnConfirmar);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaReportesDeReseñas";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BonVino: Generar Ranking";
            TransparencyKey = Color.IndianRed;
            Load += ventanaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnConfirmar;
        private DateTimePicker timePickerFechaDesde;
        private DateTimePicker timePickerFechaHasta;
        private Label txtPeriodoNoValido;
        private Label txtFechaDesde;
        private Label txtFechaHasta;
        private Label txtArchivoAExportar;
        private ComboBox cbArchivoAExportar;
        private Label txtTipoReseña;
        private ComboBox cbTipoReseña;
        private Label label1;
        private Button btnCancelar;
    }


}
