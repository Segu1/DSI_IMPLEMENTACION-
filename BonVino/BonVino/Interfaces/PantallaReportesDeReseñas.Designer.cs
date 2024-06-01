using System.Drawing.Text;

namespace BonVino
{
    partial class habilitarPantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(habilitarPantalla));
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
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = true;
            btnConfirmar.BackColor = Color.FromArgb(128, 128, 255);
            btnConfirmar.Cursor = Cursors.AppStarting;
            btnConfirmar.Enabled = false;
            btnConfirmar.Location = new Point(27, 414);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(173, 68);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // timePickerFechaDesde
            // 
            timePickerFechaDesde.CalendarForeColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarMonthBackground = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarTitleBackColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarTitleForeColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.CalendarTrailingForeColor = Color.FromArgb(46, 45, 77);
            timePickerFechaDesde.Location = new Point(27, 47);
            timePickerFechaDesde.Name = "timePickerFechaDesde";
            timePickerFechaDesde.Size = new Size(244, 21);
            timePickerFechaDesde.TabIndex = 4;
            timePickerFechaDesde.ValueChanged += timePicker_ValueChanged;
            // 
            // timePickerFechaHasta
            // 
            timePickerFechaHasta.Location = new Point(27, 115);
            timePickerFechaHasta.Name = "timePickerFechaHasta";
            timePickerFechaHasta.Size = new Size(244, 21);
            timePickerFechaHasta.TabIndex = 5;
            timePickerFechaHasta.ValueChanged += timePicker_ValueChanged;
            // 
            // txtPeriodoNoValido
            // 
            txtPeriodoNoValido.AutoSize = true;
            txtPeriodoNoValido.BackColor = Color.Transparent;
            txtPeriodoNoValido.ForeColor = SystemColors.Desktop;
            txtPeriodoNoValido.Location = new Point(27, 139);
            txtPeriodoNoValido.Name = "txtPeriodoNoValido";
            txtPeriodoNoValido.Size = new Size(220, 14);
            txtPeriodoNoValido.TabIndex = 8;
            txtPeriodoNoValido.Text = "*Ingrese un periodo de fechas valido";
            txtPeriodoNoValido.Visible = false;
            txtPeriodoNoValido.Click += txtPeriodoNoValido_Click;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.AutoSize = true;
            txtFechaDesde.BackColor = Color.Transparent;
            txtFechaDesde.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaDesde.ForeColor = Color.FromArgb(228, 227, 211);
            txtFechaDesde.Location = new Point(27, 20);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Padding = new Padding(5);
            txtFechaDesde.Size = new Size(85, 24);
            txtFechaDesde.TabIndex = 9;
            txtFechaDesde.Text = "Fecha desde";
            txtFechaDesde.Click += txtFechaDesde_Click;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.AutoSize = true;
            txtFechaHasta.BackColor = Color.Transparent;
            txtFechaHasta.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaHasta.ForeColor = Color.FromArgb(228, 227, 211);
            txtFechaHasta.Location = new Point(27, 88);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Padding = new Padding(5);
            txtFechaHasta.Size = new Size(84, 24);
            txtFechaHasta.TabIndex = 10;
            txtFechaHasta.Text = "Fecha hasta";
            txtFechaHasta.Click += label1_Click_1;
            // 
            // txtArchivoAExportar
            // 
            txtArchivoAExportar.AutoSize = true;
            txtArchivoAExportar.BackColor = Color.Transparent;
            txtArchivoAExportar.Enabled = false;
            txtArchivoAExportar.ForeColor = Color.AliceBlue;
            txtArchivoAExportar.Location = new Point(27, 279);
            txtArchivoAExportar.Name = "txtArchivoAExportar";
            txtArchivoAExportar.Size = new Size(111, 14);
            txtArchivoAExportar.TabIndex = 11;
            txtArchivoAExportar.Text = "Archivo a generar";
            txtArchivoAExportar.Click += txtArchivoAExportar_Click;
            // 
            // cbArchivoAExportar
            // 
            cbArchivoAExportar.Enabled = false;
            cbArchivoAExportar.FormattingEnabled = true;
            cbArchivoAExportar.Location = new Point(27, 296);
            cbArchivoAExportar.Name = "cbArchivoAExportar";
            cbArchivoAExportar.Size = new Size(121, 22);
            cbArchivoAExportar.TabIndex = 12;
            cbArchivoAExportar.SelectedIndexChanged += cbArchivoAExportar_SelectedIndexChanged;
            // 
            // txtTipoReseña
            // 
            txtTipoReseña.AutoSize = true;
            txtTipoReseña.BackColor = Color.Transparent;
            txtTipoReseña.Enabled = false;
            txtTipoReseña.ForeColor = Color.AliceBlue;
            txtTipoReseña.Location = new Point(27, 196);
            txtTipoReseña.Name = "txtTipoReseña";
            txtTipoReseña.Size = new Size(94, 14);
            txtTipoReseña.TabIndex = 13;
            txtTipoReseña.Text = "Tipo de reseña";
            txtTipoReseña.Click += txtTipoReseña_Click_1;
            // 
            // cbTipoReseña
            // 
            cbTipoReseña.Enabled = false;
            cbTipoReseña.FormattingEnabled = true;
            cbTipoReseña.Location = new Point(27, 213);
            cbTipoReseña.Name = "cbTipoReseña";
            cbTipoReseña.Size = new Size(121, 22);
            cbTipoReseña.TabIndex = 14;
            cbTipoReseña.SelectedIndexChanged += cbTipoReseña_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 334);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 15;
            label1.Click += label1_Click_2;
            // 
            // habilitarPantalla
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.GhostWhite;
            BackgroundImage = Properties.Resources.modern_colorful_wavy_line_background_design_wave_curve_abstract_background_for_business_landing_page_flyers_website_banner_and_presentation_free_vector;
            ClientSize = new Size(1016, 543);
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
            Name = "habilitarPantalla";
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
    }


}
