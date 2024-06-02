namespace BonVino.Interfaces
{
    partial class InterfazExcel
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
            listaRanking = new DataGridView();
            nombreVino = new DataGridViewTextBoxColumn();
            calificacion = new DataGridViewTextBoxColumn();
            precioARS = new DataGridViewTextBoxColumn();
            nombreBodega = new DataGridViewTextBoxColumn();
            varietal = new DataGridViewTextBoxColumn();
            region = new DataGridViewTextBoxColumn();
            nombrePais = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listaRanking).BeginInit();
            SuspendLayout();
            // 
            // listaRanking
            // 
            listaRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaRanking.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listaRanking.BackgroundColor = SystemColors.Window;
            listaRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaRanking.Columns.AddRange(new DataGridViewColumn[] { nombreVino, calificacion, precioARS, nombreBodega, varietal, region, nombrePais });
            listaRanking.Dock = DockStyle.Fill;
            listaRanking.Location = new Point(0, 0);
            listaRanking.Name = "listaRanking";
            listaRanking.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            listaRanking.Size = new Size(1194, 450);
            listaRanking.TabIndex = 0;
            // 
            // nombreVino
            // 
            nombreVino.HeaderText = "Nombre Vino";
            nombreVino.MinimumWidth = 6;
            nombreVino.Name = "nombreVino";
            // 
            // calificacion
            // 
            calificacion.HeaderText = "Calificación Promedio";
            calificacion.MinimumWidth = 6;
            calificacion.Name = "calificacion";
            // 
            // precioARS
            // 
            precioARS.HeaderText = "Precio Sugerido";
            precioARS.MinimumWidth = 6;
            precioARS.Name = "precioARS";
            // 
            // nombreBodega
            // 
            nombreBodega.HeaderText = "Nombre Bodega";
            nombreBodega.MinimumWidth = 6;
            nombreBodega.Name = "nombreBodega";
            // 
            // varietal
            // 
            varietal.HeaderText = "Composición";
            varietal.MinimumWidth = 6;
            varietal.Name = "varietal";
            // 
            // region
            // 
            region.HeaderText = "Nombre Región";
            region.MinimumWidth = 6;
            region.Name = "region";
            // 
            // nombrePais
            // 
            nombrePais.HeaderText = "Nombre País";
            nombrePais.MinimumWidth = 6;
            nombrePais.Name = "nombrePais";
            // 
            // InterfazExcel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1194, 450);
            Controls.Add(listaRanking);
            Name = "InterfazExcel";
            Text = "InterfazExcel";
            WindowState = FormWindowState.Maximized;
            Load += InterfazExcel_Load;
            ((System.ComponentModel.ISupportInitialize)listaRanking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listaRanking;
        private DataGridViewTextBoxColumn nombreVino;
        private DataGridViewTextBoxColumn calificacion;
        private DataGridViewTextBoxColumn precioARS;
        private DataGridViewTextBoxColumn nombreBodega;
        private DataGridViewTextBoxColumn varietal;
        private DataGridViewTextBoxColumn region;
        private DataGridViewTextBoxColumn nombrePais;
    }
}