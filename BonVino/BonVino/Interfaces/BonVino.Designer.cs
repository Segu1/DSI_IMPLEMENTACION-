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
            comboBox1 = new ComboBox();
            txtTipoDeArchivo = new Label();
            timePickerFechaDesde = new DateTimePicker();
            timePickerFechaHasta = new DateTimePicker();
            txtFechaHasta = new Label();
            txtFechaDesde = new Label();
            txtPeriodoNoValido = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = true;
            btnConfirmar.BackColor = Color.FromArgb(255, 192, 255);
            btnConfirmar.Cursor = Cursors.AppStarting;
            btnConfirmar.Location = new Point(27, 502);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(125, 47);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Aceptar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\"Excel\"", "\"Word\"", "\"Pdf\"" });
            comboBox1.Location = new Point(27, 474);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 22);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTipoDeArchivo
            // 
            txtTipoDeArchivo.AutoSize = true;
            txtTipoDeArchivo.FlatStyle = FlatStyle.System;
            txtTipoDeArchivo.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTipoDeArchivo.Location = new Point(27, 451);
            txtTipoDeArchivo.Name = "txtTipoDeArchivo";
            txtTipoDeArchivo.Size = new Size(237, 22);
            txtTipoDeArchivo.TabIndex = 2;
            txtTipoDeArchivo.Text = "Seleccione archivo a exportar";
            txtTipoDeArchivo.Click += label1_Click;
            // 
            // timePickerFechaDesde
            // 
            timePickerFechaDesde.Location = new Point(27, 47);
            timePickerFechaDesde.Name = "timePickerFechaDesde";
            timePickerFechaDesde.Size = new Size(244, 21);
            timePickerFechaDesde.TabIndex = 4;
            timePickerFechaDesde.ValueChanged += timePickerFechaDesde_ValueChanged_1;
            // 
            // timePickerFechaHasta
            // 
            timePickerFechaHasta.Location = new Point(27, 104);
            timePickerFechaHasta.Name = "timePickerFechaHasta";
            timePickerFechaHasta.Size = new Size(244, 21);
            timePickerFechaHasta.TabIndex = 5;
            timePickerFechaHasta.ValueChanged += timePickerHasta_ValueChanged;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.AutoSize = true;
            txtFechaHasta.FlatStyle = FlatStyle.System;
            txtFechaHasta.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaHasta.Location = new Point(27, 80);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(101, 22);
            txtFechaHasta.TabIndex = 6;
            txtFechaHasta.Text = "Fecha Hasta";
            txtFechaHasta.Click += label1_Click_1;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.AutoSize = true;
            txtFechaDesde.BackColor = Color.MediumSlateBlue;
            txtFechaDesde.FlatStyle = FlatStyle.System;
            txtFechaDesde.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaDesde.Location = new Point(27, 23);
            txtFechaDesde.Margin = new Padding(500);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(103, 22);
            txtFechaDesde.TabIndex = 7;
            txtFechaDesde.Text = "Fecha Desde";
            txtFechaDesde.Click += label2_Click;
            // 
            // txtPeriodoNoValido
            // 
            txtPeriodoNoValido.AutoSize = true;
            txtPeriodoNoValido.BackColor = SystemColors.Control;
            txtPeriodoNoValido.ForeColor = SystemColors.Desktop;
            txtPeriodoNoValido.Location = new Point(27, 128);
            txtPeriodoNoValido.Name = "txtPeriodoNoValido";
            txtPeriodoNoValido.Size = new Size(220, 14);
            txtPeriodoNoValido.TabIndex = 8;
            txtPeriodoNoValido.Text = "*Ingrese un periodo de fechas valido";
            txtPeriodoNoValido.Visible = false;
            txtPeriodoNoValido.Click += txtPeriodoNoValido_Click;
            // 
            // habilitarPantalla
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MediumPurple;
            BackgroundImage = Properties.Resources.modern_colorful_wavy_line_background_design_wave_curve_abstract_background_for_business_landing_page_flyers_website_banner_and_presentation_free_vector;
            ClientSize = new Size(984, 961);
            Controls.Add(txtPeriodoNoValido);
            Controls.Add(txtFechaDesde);
            Controls.Add(txtFechaHasta);
            Controls.Add(timePickerFechaHasta);
            Controls.Add(timePickerFechaDesde);
            Controls.Add(txtTipoDeArchivo);
            Controls.Add(comboBox1);
            Controls.Add(btnConfirmar);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "habilitarPantalla";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BonVino: Generar Ranking";
            TransparencyKey = Color.Gray;
            Load += ventanaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnConfirmar;
        private ComboBox comboBox1;
        private Label txtTipoDeArchivo;
        private DateTimePicker timePickerFechaDesde;
        private DateTimePicker timePickerFechaHasta;
        private Label txtFechaHasta;
        private Label txtFechaDesde;
        private Label txtPeriodoNoValido;
    }


}
