namespace Colas
{
    partial class Menu
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCostoAve = new System.Windows.Forms.TextBox();
            this.lblCostoAve = new System.Windows.Forms.Label();
            this.txtCostoRev = new System.Windows.Forms.TextBox();
            this.lblCostoRev = new System.Windows.Forms.Label();
            this.txtDiasRev = new System.Windows.Forms.TextBox();
            this.lblDiasRev = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblParametros = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(217)))), ((int)(((byte)(130)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(784, 113);
            this.pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(52, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(675, 71);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Simulador de Montecarlo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.txtCostoAve);
            this.panel1.Controls.Add(this.lblCostoAve);
            this.panel1.Controls.Add(this.txtCostoRev);
            this.panel1.Controls.Add(this.lblCostoRev);
            this.panel1.Controls.Add(this.txtDiasRev);
            this.panel1.Controls.Add(this.lblDiasRev);
            this.panel1.Controls.Add(this.txtDesde);
            this.panel1.Controls.Add(this.lblDesde);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.lblN);
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 275);
            this.panel1.TabIndex = 5;
            // 
            // txtCostoAve
            // 
            this.txtCostoAve.BackColor = System.Drawing.Color.White;
            this.txtCostoAve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoAve.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoAve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtCostoAve.Location = new System.Drawing.Point(438, 224);
            this.txtCostoAve.Name = "txtCostoAve";
            this.txtCostoAve.Size = new System.Drawing.Size(167, 34);
            this.txtCostoAve.TabIndex = 15;
            this.txtCostoAve.Text = "1500";
            // 
            // lblCostoAve
            // 
            this.lblCostoAve.AutoSize = true;
            this.lblCostoAve.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoAve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCostoAve.Location = new System.Drawing.Point(228, 228);
            this.lblCostoAve.Name = "lblCostoAve";
            this.lblCostoAve.Size = new System.Drawing.Size(187, 26);
            this.lblCostoAve.TabIndex = 14;
            this.lblCostoAve.Text = "Costo de arreglo:";
            // 
            // txtCostoRev
            // 
            this.txtCostoRev.BackColor = System.Drawing.Color.White;
            this.txtCostoRev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoRev.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoRev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtCostoRev.Location = new System.Drawing.Point(438, 175);
            this.txtCostoRev.Name = "txtCostoRev";
            this.txtCostoRev.Size = new System.Drawing.Size(167, 34);
            this.txtCostoRev.TabIndex = 13;
            this.txtCostoRev.Text = "800";
            // 
            // lblCostoRev
            // 
            this.lblCostoRev.AutoSize = true;
            this.lblCostoRev.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoRev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCostoRev.Location = new System.Drawing.Point(222, 179);
            this.lblCostoRev.Name = "lblCostoRev";
            this.lblCostoRev.Size = new System.Drawing.Size(193, 26);
            this.lblCostoRev.TabIndex = 12;
            this.lblCostoRev.Text = "Costo de revisión:";
            // 
            // txtDiasRev
            // 
            this.txtDiasRev.BackColor = System.Drawing.Color.White;
            this.txtDiasRev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasRev.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasRev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtDiasRev.Location = new System.Drawing.Point(438, 126);
            this.txtDiasRev.Name = "txtDiasRev";
            this.txtDiasRev.Size = new System.Drawing.Size(167, 34);
            this.txtDiasRev.TabIndex = 11;
            this.txtDiasRev.Text = "5";
            // 
            // lblDiasRev
            // 
            this.lblDiasRev.AutoSize = true;
            this.lblDiasRev.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasRev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDiasRev.Location = new System.Drawing.Point(91, 130);
            this.lblDiasRev.Name = "lblDiasRev";
            this.lblDiasRev.Size = new System.Drawing.Size(324, 26);
            this.lblDiasRev.TabIndex = 10;
            this.lblDiasRev.Text = "Cantidad de días para revisión:";
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.Color.White;
            this.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtDesde.Location = new System.Drawing.Point(438, 76);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(167, 34);
            this.txtDesde.TabIndex = 9;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDesde.Location = new System.Drawing.Point(118, 80);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(297, 26);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Visualizar desde simulación:";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.Color.White;
            this.txtN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtN.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtN.Location = new System.Drawing.Point(438, 26);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(167, 34);
            this.txtN.TabIndex = 7;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblN.Location = new System.Drawing.Point(136, 30);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(279, 26);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "Cantidad de simulaciones:";
            // 
            // lblParametros
            // 
            this.lblParametros.AutoSize = true;
            this.lblParametros.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblParametros.Location = new System.Drawing.Point(307, 135);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(129, 26);
            this.lblParametros.TabIndex = 6;
            this.lblParametros.Text = "Parámetros";
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(217)))), ((int)(((byte)(130)))));
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.ForeColor = System.Drawing.Color.White;
            this.btnSimular.Location = new System.Drawing.Point(525, 491);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(247, 58);
            this.btnSimular.TabIndex = 7;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCerrar.Location = new System.Drawing.Point(12, 491);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(247, 58);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.lblParametros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menú";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCostoAve;
        private System.Windows.Forms.Label lblCostoAve;
        private System.Windows.Forms.TextBox txtCostoRev;
        private System.Windows.Forms.Label lblCostoRev;
        private System.Windows.Forms.TextBox txtDiasRev;
        private System.Windows.Forms.Label lblDiasRev;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblParametros;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnCerrar;
    }
}

