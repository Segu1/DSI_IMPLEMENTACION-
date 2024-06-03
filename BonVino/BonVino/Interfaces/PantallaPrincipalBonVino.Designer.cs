namespace BonVino.Interfaces
{
    partial class PantallaPrincipalBonVino
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipalBonVino));
            btnGenerarRanking = new Button();
            SuspendLayout();
            // 
            // btnGenerarRanking
            // 
            btnGenerarRanking.AccessibleRole = AccessibleRole.Caret;
            btnGenerarRanking.BackColor = Color.WhiteSmoke;
            btnGenerarRanking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarRanking.Location = new Point(0, 0);
            btnGenerarRanking.Margin = new Padding(3, 4, 3, 4);
            btnGenerarRanking.Name = "btnGenerarRanking";
            btnGenerarRanking.Size = new Size(190, 81);
            btnGenerarRanking.TabIndex = 0;
            btnGenerarRanking.Text = "Generar Ranking";
            btnGenerarRanking.UseVisualStyleBackColor = false;
            btnGenerarRanking.Click += btnGenerarRanking_Click;
            // 
            // PantallaPrincipalBonVino
            // 
            AcceptButton = btnGenerarRanking;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImage = Properties.Resources.modern_colorful_wavy_line_background_design_wave_curve_abstract_background_for_business_landing_page_flyers_website_banner_and_presentation_free_vector;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnGenerarRanking);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PantallaPrincipalBonVino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaPrincipalBonVino";
            Load += PantallaPrincipalBonVino_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerarRanking;
    }
}