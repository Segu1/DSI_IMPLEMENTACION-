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
            label1 = new Label();
            txtArchivoAExportar = new Label();
            cbArchivoAExportar = new ComboBox();
            txtTipoReseña = new Label();
            cbTipoReseña = new ComboBox();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = true;
            btnConfirmar.BackColor = Color.FromArgb(255, 192, 255);
            btnConfirmar.Cursor = Cursors.AppStarting;
            btnConfirmar.Location = new Point(27, 568);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(153, 47);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Aceptar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // timePickerFechaDesde
            // 
            timePickerFechaDesde.Location = new Point(27, 47);
            timePickerFechaDesde.Name = "timePickerFechaDesde";
            timePickerFechaDesde.Size = new Size(244, 21);
            timePickerFechaDesde.TabIndex = 4;
            timePickerFechaDesde.ValueChanged += timePicker_ValueChanged;
            // 
            // timePickerFechaHasta
            // 
            timePickerFechaHasta.Location = new Point(27, 152);
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
            txtPeriodoNoValido.Location = new Point(27, 176);
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
            txtFechaDesde.ForeColor = Color.Beige;
            txtFechaDesde.Location = new Point(27, 30);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(82, 14);
            txtFechaDesde.TabIndex = 9;
            txtFechaDesde.Text = "Fecha desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(27, 135);
            label1.Name = "label1";
            label1.Size = new Size(77, 14);
            label1.TabIndex = 10;
            label1.Text = "Fecha hasta";
            label1.Click += label1_Click_1;
            // 
            // txtArchivoAExportar
            // 
            txtArchivoAExportar.AutoSize = true;
            txtArchivoAExportar.BackColor = Color.Transparent;
            txtArchivoAExportar.ForeColor = Color.AliceBlue;
            txtArchivoAExportar.Location = new Point(27, 402);
            txtArchivoAExportar.Name = "txtArchivoAExportar";
            txtArchivoAExportar.Size = new Size(111, 14);
            txtArchivoAExportar.TabIndex = 11;
            txtArchivoAExportar.Text = "Archivo a generar";
            // 
            // cbArchivoAExportar
            // 
            cbArchivoAExportar.FormattingEnabled = true;
            cbArchivoAExportar.Location = new Point(27, 419);
            cbArchivoAExportar.Name = "cbArchivoAExportar";
            cbArchivoAExportar.Size = new Size(121, 22);
            cbArchivoAExportar.TabIndex = 12;
            // 
            // txtTipoReseña
            // 
            txtTipoReseña.AutoSize = true;
            txtTipoReseña.BackColor = Color.Transparent;
            txtTipoReseña.ForeColor = Color.AliceBlue;
            txtTipoReseña.Location = new Point(27, 278);
            txtTipoReseña.Name = "txtTipoReseña";
            txtTipoReseña.Size = new Size(94, 14);
            txtTipoReseña.TabIndex = 13;
            txtTipoReseña.Text = "Tipo de reseña";
            txtTipoReseña.Click += txtTipoReseña_Click;
            // 
            // cbTipoReseña
            // 
            cbTipoReseña.Location = new Point(27, 295);
            cbTipoReseña.Name = "cbTipoReseña";
            cbTipoReseña.Size = new Size(125, 22);
            cbTipoReseña.TabIndex = 14;
            // 
            // habilitarPantalla
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MediumPurple;
            BackgroundImage = Properties.Resources.modern_colorful_wavy_line_background_design_wave_curve_abstract_background_for_business_landing_page_flyers_website_banner_and_presentation_free_vector;
            ClientSize = new Size(984, 689);
            Controls.Add(cbTipoReseña);
            Controls.Add(txtTipoReseña);
            Controls.Add(cbArchivoAExportar);
            Controls.Add(txtArchivoAExportar);
            Controls.Add(label1);
            Controls.Add(txtFechaDesde);
            Controls.Add(timePickerFechaDesde);
            Controls.Add(txtPeriodoNoValido);
            Controls.Add(timePickerFechaHasta);
            Controls.Add(btnConfirmar);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "habilitarPantalla";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BonVino: Generar Ranking";
            TransparencyKey = Color.Silver;
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
        private Label label1;
        private Label txtArchivoAExportar;
        private ComboBox cbArchivoAExportar;
        private Label txtTipoReseña;
        private ComboBox cbTipoReseña;
    }


}
