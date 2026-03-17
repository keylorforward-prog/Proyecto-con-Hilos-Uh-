namespace NominaSalarios
{
    partial class Form2
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
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.dgvMenor = new System.Windows.Forms.DataGridView();
            this.dgvMayor = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(122, 25);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(156, 13);
            this.lblMenor.TabIndex = 0;
            this.lblMenor.Text = "Listado de los Menores Salarios";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(556, 25);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(155, 13);
            this.lblMayor.TabIndex = 1;
            this.lblMayor.Text = "Listado de los Mayores Salarios";
            // 
            // dgvMenor
            // 
            this.dgvMenor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenor.Location = new System.Drawing.Point(30, 65);
            this.dgvMenor.Name = "dgvMenor";
            this.dgvMenor.Size = new System.Drawing.Size(382, 381);
            this.dgvMenor.TabIndex = 2;
            // 
            // dgvMayor
            // 
            this.dgvMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayor.Location = new System.Drawing.Point(455, 65);
            this.dgvMayor.Name = "dgvMayor";
            this.dgvMayor.Size = new System.Drawing.Size(382, 381);
            this.dgvMayor.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(714, 475);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvMayor);
            this.Controls.Add(this.dgvMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblMenor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.DataGridView dgvMenor;
        private System.Windows.Forms.DataGridView dgvMayor;
        private System.Windows.Forms.Button btnCerrar;
    }
}