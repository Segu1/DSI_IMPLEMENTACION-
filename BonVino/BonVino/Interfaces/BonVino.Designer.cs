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
            vScrollBar1 = new VScrollBar();
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
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Cursor = Cursors.AppStarting;
            btnConfirmar.Location = new Point(551, 476);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(109, 50);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Aceptar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\"Excel\"", "\"Word\"", "\"Pdf\"" });
            comboBox1.Location = new Point(470, 428);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTipoDeArchivo
            // 
            txtTipoDeArchivo.AutoSize = true;
            txtTipoDeArchivo.FlatStyle = FlatStyle.System;
            txtTipoDeArchivo.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTipoDeArchivo.Location = new Point(441, 403);
            txtTipoDeArchivo.Name = "txtTipoDeArchivo";
            txtTipoDeArchivo.Size = new Size(237, 22);
            txtTipoDeArchivo.TabIndex = 2;
            txtTipoDeArchivo.Text = "Seleccione archivo a exportar";
            txtTipoDeArchivo.Click += label1_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(681, 21);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(12, 467);
            vScrollBar1.TabIndex = 3;
            // 
            // timePickerFechaDesde
            // 
            timePickerFechaDesde.Location = new Point(23, 46);
            timePickerFechaDesde.Name = "timePickerFechaDesde";
            timePickerFechaDesde.Size = new Size(214, 23);
            timePickerFechaDesde.TabIndex = 4;
            timePickerFechaDesde.ValueChanged += timePickerFechaDesde_ValueChanged_1;
            // 
            // timePickerFechaHasta
            // 
            timePickerFechaHasta.Location = new Point(23, 107);
            timePickerFechaHasta.Name = "timePickerFechaHasta";
            timePickerFechaHasta.Size = new Size(214, 23);
            timePickerFechaHasta.TabIndex = 5;
            timePickerFechaHasta.ValueChanged += timePickerHasta_ValueChanged;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.AutoSize = true;
            txtFechaHasta.FlatStyle = FlatStyle.System;
            txtFechaHasta.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaHasta.Location = new Point(23, 82);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(101, 22);
            txtFechaHasta.TabIndex = 6;
            txtFechaHasta.Text = "Fecha Hasta";
            txtFechaHasta.Click += label1_Click_1;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.AutoSize = true;
            txtFechaDesde.FlatStyle = FlatStyle.System;
            txtFechaDesde.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaDesde.Location = new Point(23, 21);
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
            txtPeriodoNoValido.Location = new Point(23, 133);
            txtPeriodoNoValido.Name = "txtPeriodoNoValido";
            txtPeriodoNoValido.Size = new Size(199, 15);
            txtPeriodoNoValido.TabIndex = 8;
            txtPeriodoNoValido.Text = "*Ingrese un periodo de fechas valido";
            txtPeriodoNoValido.Visible = false;
            txtPeriodoNoValido.Click += txtPeriodoNoValido_Click;
            // 
            // habilitarPantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(702, 538);
            Controls.Add(txtPeriodoNoValido);
            Controls.Add(txtFechaDesde);
            Controls.Add(txtFechaHasta);
            Controls.Add(timePickerFechaHasta);
            Controls.Add(timePickerFechaDesde);
            Controls.Add(vScrollBar1);
            Controls.Add(txtTipoDeArchivo);
            Controls.Add(comboBox1);
            Controls.Add(btnConfirmar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "habilitarPantalla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BonVino: Generar Ranking";
            Load += ventanaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnConfirmar;
        private ComboBox comboBox1;
        private Label txtTipoDeArchivo;
        private VScrollBar vScrollBar1;
        private DateTimePicker timePickerFechaDesde;
        private DateTimePicker timePickerFechaHasta;
        private Label txtFechaHasta;
        private Label txtFechaDesde;
        private Label txtPeriodoNoValido;
    }


}
