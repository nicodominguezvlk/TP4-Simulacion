namespace Colas
{
    partial class Metricas
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.picX = new System.Windows.Forms.PictureBox();
            this.imgArrow = new System.Windows.Forms.PictureBox();
            this.imgX = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblCantMetros = new System.Windows.Forms.Label();
            this.lblCantidadAutosProm = new System.Windows.Forms.Label();
            this.lblCantidadAutosPromedio = new System.Windows.Forms.Label();
            this.lblTiempoPromedioColaEntrada = new System.Windows.Forms.Label();
            this.lblTiempoPromedioEntrada = new System.Windows.Forms.Label();
            this.lblTiempoPromedioEnColaComida = new System.Windows.Forms.Label();
            this.lblTiempoPromedioComida = new System.Windows.Forms.Label();
            this.lblTiempoEnConseguirEntrada = new System.Windows.Forms.Label();
            this.lblTiempoEnConseguirE = new System.Windows.Forms.Label();
            this.lblCantidadPromedioGente = new System.Windows.Forms.Label();
            this.lblCantidadGente = new System.Windows.Forms.Label();
            this.lblTiempoDespuesEstacionar = new System.Windows.Forms.Label();
            this.lblTiempoDespEstacionar = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Tomato;
            this.pnlTitulo.Controls.Add(this.picArrow);
            this.pnlTitulo.Controls.Add(this.picX);
            this.pnlTitulo.Controls.Add(this.imgArrow);
            this.pnlTitulo.Controls.Add(this.imgX);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1064, 90);
            this.pnlTitulo.TabIndex = 4;
            // 
            // picArrow
            // 
            this.picArrow.BackgroundImage = global::Colas.Properties.Resources.Arrow2;
            this.picArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrow.Location = new System.Drawing.Point(903, 11);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(65, 65);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 4;
            this.picArrow.TabStop = false;
            this.picArrow.Click += new System.EventHandler(this.picArrow_Click);
            // 
            // picX
            // 
            this.picX.BackgroundImage = global::Colas.Properties.Resources.X2;
            this.picX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picX.Location = new System.Drawing.Point(987, 11);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(65, 65);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picX.TabIndex = 3;
            this.picX.TabStop = false;
            this.picX.Click += new System.EventHandler(this.picX_Click);
            // 
            // imgArrow
            // 
            this.imgArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgArrow.Location = new System.Drawing.Point(1208, 21);
            this.imgArrow.Name = "imgArrow";
            this.imgArrow.Size = new System.Drawing.Size(50, 50);
            this.imgArrow.TabIndex = 2;
            this.imgArrow.TabStop = false;
            // 
            // imgX
            // 
            this.imgX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgX.Location = new System.Drawing.Point(1278, 21);
            this.imgX.Name = "imgX";
            this.imgX.Size = new System.Drawing.Size(50, 50);
            this.imgX.TabIndex = 1;
            this.imgX.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 61);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Métricas";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMetros.Location = new System.Drawing.Point(55, 137);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(441, 23);
            this.lblMetros.TabIndex = 7;
            this.lblMetros.Text = "Metros Promedio Necesarios Para Aparcamiento:";
            // 
            // lblCantMetros
            // 
            this.lblCantMetros.AutoSize = true;
            this.lblCantMetros.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCantMetros.Location = new System.Drawing.Point(603, 137);
            this.lblCantMetros.Name = "lblCantMetros";
            this.lblCantMetros.Size = new System.Drawing.Size(260, 23);
            this.lblCantMetros.TabIndex = 8;
            this.lblCantMetros.Text = "[Cantidad Metros Promedio]";
            // 
            // lblCantidadAutosProm
            // 
            this.lblCantidadAutosProm.AutoSize = true;
            this.lblCantidadAutosProm.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAutosProm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCantidadAutosProm.Location = new System.Drawing.Point(55, 193);
            this.lblCantidadAutosProm.Name = "lblCantidadAutosProm";
            this.lblCantidadAutosProm.Size = new System.Drawing.Size(355, 23);
            this.lblCantidadAutosProm.TabIndex = 9;
            this.lblCantidadAutosProm.Text = "Cantidad Promedio Autos En Cola Park:";
            // 
            // lblCantidadAutosPromedio
            // 
            this.lblCantidadAutosPromedio.AutoSize = true;
            this.lblCantidadAutosPromedio.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAutosPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCantidadAutosPromedio.Location = new System.Drawing.Point(603, 193);
            this.lblCantidadAutosPromedio.Name = "lblCantidadAutosPromedio";
            this.lblCantidadAutosPromedio.Size = new System.Drawing.Size(249, 23);
            this.lblCantidadAutosPromedio.TabIndex = 10;
            this.lblCantidadAutosPromedio.Text = "[Cantidad Autos Promedio]";
            // 
            // lblTiempoPromedioColaEntrada
            // 
            this.lblTiempoPromedioColaEntrada.AutoSize = true;
            this.lblTiempoPromedioColaEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromedioColaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromedioColaEntrada.Location = new System.Drawing.Point(55, 252);
            this.lblTiempoPromedioColaEntrada.Name = "lblTiempoPromedioColaEntrada";
            this.lblTiempoPromedioColaEntrada.Size = new System.Drawing.Size(315, 23);
            this.lblTiempoPromedioColaEntrada.TabIndex = 11;
            this.lblTiempoPromedioColaEntrada.Text = "Tiempo Promedio En Cola Entrada:";
            // 
            // lblTiempoPromedioEntrada
            // 
            this.lblTiempoPromedioEntrada.AutoSize = true;
            this.lblTiempoPromedioEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromedioEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromedioEntrada.Location = new System.Drawing.Point(603, 252);
            this.lblTiempoPromedioEntrada.Name = "lblTiempoPromedioEntrada";
            this.lblTiempoPromedioEntrada.Size = new System.Drawing.Size(296, 23);
            this.lblTiempoPromedioEntrada.TabIndex = 12;
            this.lblTiempoPromedioEntrada.Text = "[Tiempo Promedio Cola Entrada]";
            // 
            // lblTiempoPromedioEnColaComida
            // 
            this.lblTiempoPromedioEnColaComida.AutoSize = true;
            this.lblTiempoPromedioEnColaComida.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromedioEnColaComida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromedioEnColaComida.Location = new System.Drawing.Point(55, 316);
            this.lblTiempoPromedioEnColaComida.Name = "lblTiempoPromedioEnColaComida";
            this.lblTiempoPromedioEnColaComida.Size = new System.Drawing.Size(316, 23);
            this.lblTiempoPromedioEnColaComida.TabIndex = 13;
            this.lblTiempoPromedioEnColaComida.Text = "Tiempo Promedio En Cola Comida:";
            // 
            // lblTiempoPromedioComida
            // 
            this.lblTiempoPromedioComida.AutoSize = true;
            this.lblTiempoPromedioComida.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromedioComida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromedioComida.Location = new System.Drawing.Point(603, 316);
            this.lblTiempoPromedioComida.Name = "lblTiempoPromedioComida";
            this.lblTiempoPromedioComida.Size = new System.Drawing.Size(297, 23);
            this.lblTiempoPromedioComida.TabIndex = 14;
            this.lblTiempoPromedioComida.Text = "[Tiempo Promedio Cola Comida]";
            // 
            // lblTiempoEnConseguirEntrada
            // 
            this.lblTiempoEnConseguirEntrada.AutoSize = true;
            this.lblTiempoEnConseguirEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoEnConseguirEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoEnConseguirEntrada.Location = new System.Drawing.Point(55, 373);
            this.lblTiempoEnConseguirEntrada.Name = "lblTiempoEnConseguirEntrada";
            this.lblTiempoEnConseguirEntrada.Size = new System.Drawing.Size(279, 23);
            this.lblTiempoEnConseguirEntrada.TabIndex = 15;
            this.lblTiempoEnConseguirEntrada.Text = "Tiempo En Conseguir Entrada: ";
            // 
            // lblTiempoEnConseguirE
            // 
            this.lblTiempoEnConseguirE.AutoSize = true;
            this.lblTiempoEnConseguirE.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoEnConseguirE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoEnConseguirE.Location = new System.Drawing.Point(603, 373);
            this.lblTiempoEnConseguirE.Name = "lblTiempoEnConseguirE";
            this.lblTiempoEnConseguirE.Size = new System.Drawing.Size(281, 23);
            this.lblTiempoEnConseguirE.TabIndex = 16;
            this.lblTiempoEnConseguirE.Text = "[Tiempo En Conseguir Entrada]";
            // 
            // lblCantidadPromedioGente
            // 
            this.lblCantidadPromedioGente.AutoSize = true;
            this.lblCantidadPromedioGente.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPromedioGente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCantidadPromedioGente.Location = new System.Drawing.Point(55, 427);
            this.lblCantidadPromedioGente.Name = "lblCantidadPromedioGente";
            this.lblCantidadPromedioGente.Size = new System.Drawing.Size(384, 23);
            this.lblCantidadPromedioGente.TabIndex = 17;
            this.lblCantidadPromedioGente.Text = "Cantidad Promedio Gente En Cola Entrada:";
            // 
            // lblCantidadGente
            // 
            this.lblCantidadGente.AutoSize = true;
            this.lblCantidadGente.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadGente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCantidadGente.Location = new System.Drawing.Point(603, 427);
            this.lblCantidadGente.Name = "lblCantidadGente";
            this.lblCantidadGente.Size = new System.Drawing.Size(249, 23);
            this.lblCantidadGente.TabIndex = 18;
            this.lblCantidadGente.Text = "[Cantidad Gente Promedio]";
            // 
            // lblTiempoDespuesEstacionar
            // 
            this.lblTiempoDespuesEstacionar.AutoSize = true;
            this.lblTiempoDespuesEstacionar.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoDespuesEstacionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoDespuesEstacionar.Location = new System.Drawing.Point(55, 482);
            this.lblTiempoDespuesEstacionar.Name = "lblTiempoDespuesEstacionar";
            this.lblTiempoDespuesEstacionar.Size = new System.Drawing.Size(385, 23);
            this.lblTiempoDespuesEstacionar.TabIndex = 19;
            this.lblTiempoDespuesEstacionar.Text = "Tiempo De Entrada Despues de Estacionar:";
            // 
            // lblTiempoDespEstacionar
            // 
            this.lblTiempoDespEstacionar.AutoSize = true;
            this.lblTiempoDespEstacionar.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoDespEstacionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoDespEstacionar.Location = new System.Drawing.Point(603, 482);
            this.lblTiempoDespEstacionar.Name = "lblTiempoDespEstacionar";
            this.lblTiempoDespEstacionar.Size = new System.Drawing.Size(293, 23);
            this.lblTiempoDespEstacionar.TabIndex = 20;
            this.lblTiempoDespEstacionar.Text = "[Tiempo Despues De Estacionar]";
            // 
            // Metricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 559);
            this.Controls.Add(this.lblTiempoDespEstacionar);
            this.Controls.Add(this.lblTiempoDespuesEstacionar);
            this.Controls.Add(this.lblCantidadGente);
            this.Controls.Add(this.lblCantidadPromedioGente);
            this.Controls.Add(this.lblTiempoEnConseguirE);
            this.Controls.Add(this.lblTiempoEnConseguirEntrada);
            this.Controls.Add(this.lblTiempoPromedioComida);
            this.Controls.Add(this.lblTiempoPromedioEnColaComida);
            this.Controls.Add(this.lblTiempoPromedioEntrada);
            this.Controls.Add(this.lblTiempoPromedioColaEntrada);
            this.Controls.Add(this.lblCantidadAutosPromedio);
            this.Controls.Add(this.lblCantidadAutosProm);
            this.Controls.Add(this.lblCantMetros);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Metricas";
            this.Text = "Form1";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.PictureBox imgArrow;
        private System.Windows.Forms.PictureBox imgX;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblCantMetros;
        private System.Windows.Forms.Label lblCantidadAutosProm;
        private System.Windows.Forms.Label lblCantidadAutosPromedio;
        private System.Windows.Forms.Label lblTiempoPromedioColaEntrada;
        private System.Windows.Forms.Label lblTiempoPromedioEntrada;
        private System.Windows.Forms.Label lblTiempoPromedioEnColaComida;
        private System.Windows.Forms.Label lblTiempoPromedioComida;
        private System.Windows.Forms.Label lblTiempoEnConseguirEntrada;
        private System.Windows.Forms.Label lblTiempoEnConseguirE;
        private System.Windows.Forms.Label lblCantidadPromedioGente;
        private System.Windows.Forms.Label lblCantidadGente;
        private System.Windows.Forms.Label lblTiempoDespuesEstacionar;
        private System.Windows.Forms.Label lblTiempoDespEstacionar;
    }
}