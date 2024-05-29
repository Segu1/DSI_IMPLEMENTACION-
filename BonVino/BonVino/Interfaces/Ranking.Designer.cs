using BonVino.Entidades;
namespace BonVino
{
    partial class Ranking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


        // Método para establecer el título de la ventana


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            txtRankingGenerado = new Label();
            SuspendLayout();
            // 
            // txtRankingGenerado
            // 
            txtRankingGenerado.AutoSize = true;
            txtRankingGenerado.Cursor = Cursors.PanSouth;
            txtRankingGenerado.Location = new Point(338, 9);
            txtRankingGenerado.Name = "txtRankingGenerado";
            txtRankingGenerado.Size = new Size(104, 15);
            txtRankingGenerado.TabIndex = 0;
            txtRankingGenerado.Text = "Ranking Generado";
            txtRankingGenerado.TextAlign = ContentAlignment.TopCenter;
            txtRankingGenerado.Click += label1_Click;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRankingGenerado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ranking";
            Text = "BonVino: Ranking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRankingGenerado;
    }
}