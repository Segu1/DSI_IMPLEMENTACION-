namespace BonVino
{
    partial class ventanaPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            btnConfirmar = new Button();
            comboBox1 = new ComboBox();
            txtTipoDeArchivo = new Label();
            notifyIcon1 = new NotifyIcon(components);
            vScrollBar1 = new VScrollBar();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = true;
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Cursor = Cursors.AppStarting;
            btnConfirmar.Location = new Point(32, 377);
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
            comboBox1.Location = new Point(32, 324);
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
            txtTipoDeArchivo.Location = new Point(32, 299);
            txtTipoDeArchivo.Name = "txtTipoDeArchivo";
            txtTipoDeArchivo.Size = new Size(237, 22);
            txtTipoDeArchivo.TabIndex = 2;
            txtTipoDeArchivo.Text = "Seleccione archivo a exportar";
            txtTipoDeArchivo.Click += label1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(681, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(12, 467);
            vScrollBar1.TabIndex = 3;
            // 
            // ventanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(702, 538);
            Controls.Add(vScrollBar1);
            Controls.Add(txtTipoDeArchivo);
            Controls.Add(comboBox1);
            Controls.Add(btnConfirmar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ventanaPrincipal";
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
        private NotifyIcon notifyIcon1;
        private VScrollBar vScrollBar1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
