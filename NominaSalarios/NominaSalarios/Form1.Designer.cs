namespace NominaSalarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHilo = new System.Windows.Forms.Label();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.dgvMenorMillon = new System.Windows.Forms.DataGridView();
            this.dgvHombres = new System.Windows.Forms.DataGridView();
            this.dgvMujeres = new System.Windows.Forms.DataGridView();
            this.dgvMayorMillon = new System.Windows.Forms.DataGridView();
            this.dgvMayorTres = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCargarPanel = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenorMillon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMujeres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayorMillon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayorTres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHilo
            // 
            this.lblHilo.AutoSize = true;
            this.lblHilo.Location = new System.Drawing.Point(2, 9);
            this.lblHilo.Name = "lblHilo";
            this.lblHilo.Size = new System.Drawing.Size(85, 13);
            this.lblHilo.TabIndex = 0;
            this.lblHilo.Text = "Procesando Hilo";
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.AllowUserToAddRows = false;
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Location = new System.Drawing.Point(15, 44);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.ReadOnly = true;
            this.dgvGeneral.Size = new System.Drawing.Size(326, 214);
            this.dgvGeneral.TabIndex = 1;
            // 
            // dgvMenorMillon
            // 
            this.dgvMenorMillon.AllowUserToAddRows = false;
            this.dgvMenorMillon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenorMillon.Location = new System.Drawing.Point(15, 284);
            this.dgvMenorMillon.Name = "dgvMenorMillon";
            this.dgvMenorMillon.ReadOnly = true;
            this.dgvMenorMillon.Size = new System.Drawing.Size(326, 214);
            this.dgvMenorMillon.TabIndex = 2;
            // 
            // dgvHombres
            // 
            this.dgvHombres.AllowUserToAddRows = false;
            this.dgvHombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHombres.Location = new System.Drawing.Point(382, 28);
            this.dgvHombres.Name = "dgvHombres";
            this.dgvHombres.ReadOnly = true;
            this.dgvHombres.Size = new System.Drawing.Size(326, 214);
            this.dgvHombres.TabIndex = 3;
            // 
            // dgvMujeres
            // 
            this.dgvMujeres.AllowUserToAddRows = false;
            this.dgvMujeres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMujeres.Location = new System.Drawing.Point(753, 28);
            this.dgvMujeres.Name = "dgvMujeres";
            this.dgvMujeres.ReadOnly = true;
            this.dgvMujeres.Size = new System.Drawing.Size(326, 214);
            this.dgvMujeres.TabIndex = 4;
            // 
            // dgvMayorMillon
            // 
            this.dgvMayorMillon.AllowUserToAddRows = false;
            this.dgvMayorMillon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayorMillon.Location = new System.Drawing.Point(382, 261);
            this.dgvMayorMillon.Name = "dgvMayorMillon";
            this.dgvMayorMillon.ReadOnly = true;
            this.dgvMayorMillon.Size = new System.Drawing.Size(326, 214);
            this.dgvMayorMillon.TabIndex = 5;
            // 
            // dgvMayorTres
            // 
            this.dgvMayorTres.AllowUserToAddRows = false;
            this.dgvMayorTres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayorTres.Location = new System.Drawing.Point(753, 261);
            this.dgvMayorTres.Name = "dgvMayorTres";
            this.dgvMayorTres.ReadOnly = true;
            this.dgvMayorTres.Size = new System.Drawing.Size(326, 214);
            this.dgvMayorTres.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(93, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(159, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Listado General de Funcionarios";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(480, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 13);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Listado de Hombres";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(874, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(96, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Listado de Mujeres";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(115, 261);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(91, 13);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Menor a un Millón";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(456, 245);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(190, 13);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Mayor a un Millón y Menor a 3 Millones";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(850, 245);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(129, 13);
            this.lbl6.TabIndex = 12;
            this.lbl6.Text = "Mayor o igual a 3 Millones";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(753, 496);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(92, 31);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.Text = "Cargar Archivos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCargarPanel
            // 
            this.btnCargarPanel.Enabled = false;
            this.btnCargarPanel.Location = new System.Drawing.Point(853, 496);
            this.btnCargarPanel.Name = "btnCargarPanel";
            this.btnCargarPanel.Size = new System.Drawing.Size(92, 31);
            this.btnCargarPanel.TabIndex = 14;
            this.btnCargarPanel.Text = "Cargar <>";
            this.btnCargarPanel.UseVisualStyleBackColor = true;
            this.btnCargarPanel.Click += new System.EventHandler(this.btnCargarPanel_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(970, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 31);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 539);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarPanel);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvMayorTres);
            this.Controls.Add(this.dgvMayorMillon);
            this.Controls.Add(this.dgvMujeres);
            this.Controls.Add(this.dgvHombres);
            this.Controls.Add(this.dgvMenorMillon);
            this.Controls.Add(this.dgvGeneral);
            this.Controls.Add(this.lblHilo);
            this.Name = "Form1";
            this.Text = "Nomina de Salarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenorMillon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMujeres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayorMillon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayorTres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHilo;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.DataGridView dgvMenorMillon;
        private System.Windows.Forms.DataGridView dgvHombres;
        private System.Windows.Forms.DataGridView dgvMujeres;
        private System.Windows.Forms.DataGridView dgvMayorMillon;
        private System.Windows.Forms.DataGridView dgvMayorTres;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCargarPanel;
        private System.Windows.Forms.Button btnSalir;
    }
}

