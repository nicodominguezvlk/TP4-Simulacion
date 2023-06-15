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
            this.pnlParametros = new System.Windows.Forms.Panel();
            this.lblVerHasta = new System.Windows.Forms.Label();
            this.txtVerHasta = new System.Windows.Forms.TextBox();
            this.lblVerDesde = new System.Windows.Forms.Label();
            this.txtVerDesde = new System.Windows.Forms.TextBox();
            this.lblCantSimulaciones = new System.Windows.Forms.Label();
            this.txtCantSimulaciones = new System.Windows.Forms.TextBox();
            this.txtMediaControlComidaMayores = new System.Windows.Forms.TextBox();
            this.lblTiempoPromControlComidaMayores = new System.Windows.Forms.Label();
            this.txtMediaControlComida = new System.Windows.Forms.TextBox();
            this.lblTiempoPromControlComida = new System.Windows.Forms.Label();
            this.txtMediaAtenciónEntrada = new System.Windows.Forms.TextBox();
            this.lblTiempoPromAtenciónEntrada = new System.Windows.Forms.Label();
            this.txtMediaAtenciónParking = new System.Windows.Forms.TextBox();
            this.lblTiempoPromAtenciónParking = new System.Windows.Forms.Label();
            this.txtMediaLLegadaAuto = new System.Windows.Forms.TextBox();
            this.lblLlegadaAuto = new System.Windows.Forms.Label();
            this.lblParametros = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlArmando = new System.Windows.Forms.Panel();
            this.lblArmando = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlParametros.SuspendLayout();
            this.pnlArmando.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Tomato;
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
            this.lblTitulo.Size = new System.Drawing.Size(657, 71);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BETO CARRERO WORLD";
            // 
            // pnlParametros
            // 
            this.pnlParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pnlParametros.Controls.Add(this.pnlArmando);
            this.pnlParametros.Controls.Add(this.lblVerHasta);
            this.pnlParametros.Controls.Add(this.txtVerHasta);
            this.pnlParametros.Controls.Add(this.lblVerDesde);
            this.pnlParametros.Controls.Add(this.txtVerDesde);
            this.pnlParametros.Controls.Add(this.lblCantSimulaciones);
            this.pnlParametros.Controls.Add(this.txtCantSimulaciones);
            this.pnlParametros.Controls.Add(this.txtMediaControlComidaMayores);
            this.pnlParametros.Controls.Add(this.lblTiempoPromControlComidaMayores);
            this.pnlParametros.Controls.Add(this.txtMediaControlComida);
            this.pnlParametros.Controls.Add(this.lblTiempoPromControlComida);
            this.pnlParametros.Controls.Add(this.txtMediaAtenciónEntrada);
            this.pnlParametros.Controls.Add(this.lblTiempoPromAtenciónEntrada);
            this.pnlParametros.Controls.Add(this.txtMediaAtenciónParking);
            this.pnlParametros.Controls.Add(this.lblTiempoPromAtenciónParking);
            this.pnlParametros.Controls.Add(this.txtMediaLLegadaAuto);
            this.pnlParametros.Controls.Add(this.lblLlegadaAuto);
            this.pnlParametros.Location = new System.Drawing.Point(0, 180);
            this.pnlParametros.Name = "pnlParametros";
            this.pnlParametros.Size = new System.Drawing.Size(784, 393);
            this.pnlParametros.TabIndex = 5;
            // 
            // lblVerHasta
            // 
            this.lblVerHasta.AutoSize = true;
            this.lblVerHasta.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblVerHasta.Location = new System.Drawing.Point(319, 341);
            this.lblVerHasta.Name = "lblVerHasta";
            this.lblVerHasta.Size = new System.Drawing.Size(195, 23);
            this.lblVerHasta.TabIndex = 21;
            this.lblVerHasta.Text = "Ver hasta simulación:";
            // 
            // txtVerHasta
            // 
            this.txtVerHasta.BackColor = System.Drawing.Color.White;
            this.txtVerHasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerHasta.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtVerHasta.Location = new System.Drawing.Point(520, 335);
            this.txtVerHasta.Name = "txtVerHasta";
            this.txtVerHasta.Size = new System.Drawing.Size(167, 34);
            this.txtVerHasta.TabIndex = 20;
            this.txtVerHasta.Text = "500";
            this.txtVerHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblVerDesde
            // 
            this.lblVerDesde.AutoSize = true;
            this.lblVerDesde.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblVerDesde.Location = new System.Drawing.Point(313, 297);
            this.lblVerDesde.Name = "lblVerDesde";
            this.lblVerDesde.Size = new System.Drawing.Size(201, 23);
            this.lblVerDesde.TabIndex = 19;
            this.lblVerDesde.Text = "Ver desde simulación:";
            // 
            // txtVerDesde
            // 
            this.txtVerDesde.BackColor = System.Drawing.Color.White;
            this.txtVerDesde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerDesde.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtVerDesde.Location = new System.Drawing.Point(520, 291);
            this.txtVerDesde.Name = "txtVerDesde";
            this.txtVerDesde.Size = new System.Drawing.Size(167, 34);
            this.txtVerDesde.TabIndex = 18;
            this.txtVerDesde.Text = "0";
            this.txtVerDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblCantSimulaciones
            // 
            this.lblCantSimulaciones.AutoSize = true;
            this.lblCantSimulaciones.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantSimulaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCantSimulaciones.Location = new System.Drawing.Point(270, 252);
            this.lblCantSimulaciones.Name = "lblCantSimulaciones";
            this.lblCantSimulaciones.Size = new System.Drawing.Size(244, 23);
            this.lblCantSimulaciones.TabIndex = 17;
            this.lblCantSimulaciones.Text = "Cantidad de simulaciones: ";
            // 
            // txtCantSimulaciones
            // 
            this.txtCantSimulaciones.BackColor = System.Drawing.Color.White;
            this.txtCantSimulaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantSimulaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantSimulaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtCantSimulaciones.Location = new System.Drawing.Point(520, 246);
            this.txtCantSimulaciones.Name = "txtCantSimulaciones";
            this.txtCantSimulaciones.Size = new System.Drawing.Size(167, 34);
            this.txtCantSimulaciones.TabIndex = 16;
            this.txtCantSimulaciones.Text = "1000";
            this.txtCantSimulaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtMediaControlComidaMayores
            // 
            this.txtMediaControlComidaMayores.BackColor = System.Drawing.Color.White;
            this.txtMediaControlComidaMayores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaControlComidaMayores.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaControlComidaMayores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMediaControlComidaMayores.Location = new System.Drawing.Point(520, 201);
            this.txtMediaControlComidaMayores.Name = "txtMediaControlComidaMayores";
            this.txtMediaControlComidaMayores.Size = new System.Drawing.Size(167, 34);
            this.txtMediaControlComidaMayores.TabIndex = 15;
            this.txtMediaControlComidaMayores.Text = "6";
            this.txtMediaControlComidaMayores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblTiempoPromControlComidaMayores
            // 
            this.lblTiempoPromControlComidaMayores.AutoSize = true;
            this.lblTiempoPromControlComidaMayores.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromControlComidaMayores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromControlComidaMayores.Location = new System.Drawing.Point(53, 207);
            this.lblTiempoPromControlComidaMayores.Name = "lblTiempoPromControlComidaMayores";
            this.lblTiempoPromControlComidaMayores.Size = new System.Drawing.Size(461, 23);
            this.lblTiempoPromControlComidaMayores.TabIndex = 14;
            this.lblTiempoPromControlComidaMayores.Text = "Tiempo promedio de control de comida a mayores:";
            // 
            // txtMediaControlComida
            // 
            this.txtMediaControlComida.BackColor = System.Drawing.Color.White;
            this.txtMediaControlComida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaControlComida.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaControlComida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMediaControlComida.Location = new System.Drawing.Point(520, 154);
            this.txtMediaControlComida.Name = "txtMediaControlComida";
            this.txtMediaControlComida.Size = new System.Drawing.Size(167, 34);
            this.txtMediaControlComida.TabIndex = 13;
            this.txtMediaControlComida.Text = "5";
            this.txtMediaControlComida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblTiempoPromControlComida
            // 
            this.lblTiempoPromControlComida.AutoSize = true;
            this.lblTiempoPromControlComida.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromControlComida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromControlComida.Location = new System.Drawing.Point(148, 160);
            this.lblTiempoPromControlComida.Name = "lblTiempoPromControlComida";
            this.lblTiempoPromControlComida.Size = new System.Drawing.Size(366, 23);
            this.lblTiempoPromControlComida.TabIndex = 12;
            this.lblTiempoPromControlComida.Text = "Tiempo promedio de control de comida:";
            // 
            // txtMediaAtenciónEntrada
            // 
            this.txtMediaAtenciónEntrada.BackColor = System.Drawing.Color.White;
            this.txtMediaAtenciónEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaAtenciónEntrada.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaAtenciónEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMediaAtenciónEntrada.Location = new System.Drawing.Point(520, 108);
            this.txtMediaAtenciónEntrada.Name = "txtMediaAtenciónEntrada";
            this.txtMediaAtenciónEntrada.Size = new System.Drawing.Size(167, 34);
            this.txtMediaAtenciónEntrada.TabIndex = 11;
            this.txtMediaAtenciónEntrada.Text = "92";
            this.txtMediaAtenciónEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblTiempoPromAtenciónEntrada
            // 
            this.lblTiempoPromAtenciónEntrada.AutoSize = true;
            this.lblTiempoPromAtenciónEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromAtenciónEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromAtenciónEntrada.Location = new System.Drawing.Point(87, 114);
            this.lblTiempoPromAtenciónEntrada.Name = "lblTiempoPromAtenciónEntrada";
            this.lblTiempoPromAtenciónEntrada.Size = new System.Drawing.Size(427, 23);
            this.lblTiempoPromAtenciónEntrada.TabIndex = 10;
            this.lblTiempoPromAtenciónEntrada.Text = "Tiempo promedio de atención en cajas entrada:";
            // 
            // txtMediaAtenciónParking
            // 
            this.txtMediaAtenciónParking.BackColor = System.Drawing.Color.White;
            this.txtMediaAtenciónParking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaAtenciónParking.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaAtenciónParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMediaAtenciónParking.Location = new System.Drawing.Point(520, 62);
            this.txtMediaAtenciónParking.Name = "txtMediaAtenciónParking";
            this.txtMediaAtenciónParking.Size = new System.Drawing.Size(167, 34);
            this.txtMediaAtenciónParking.TabIndex = 9;
            this.txtMediaAtenciónParking.Text = "29";
            this.txtMediaAtenciónParking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblTiempoPromAtenciónParking
            // 
            this.lblTiempoPromAtenciónParking.AutoSize = true;
            this.lblTiempoPromAtenciónParking.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromAtenciónParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTiempoPromAtenciónParking.Location = new System.Drawing.Point(87, 68);
            this.lblTiempoPromAtenciónParking.Name = "lblTiempoPromAtenciónParking";
            this.lblTiempoPromAtenciónParking.Size = new System.Drawing.Size(427, 23);
            this.lblTiempoPromAtenciónParking.TabIndex = 8;
            this.lblTiempoPromAtenciónParking.Text = "Tiempo promedio de atención en cajas parking:";
            // 
            // txtMediaLLegadaAuto
            // 
            this.txtMediaLLegadaAuto.BackColor = System.Drawing.Color.White;
            this.txtMediaLLegadaAuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaLLegadaAuto.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaLLegadaAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMediaLLegadaAuto.Location = new System.Drawing.Point(520, 16);
            this.txtMediaLLegadaAuto.Name = "txtMediaLLegadaAuto";
            this.txtMediaLLegadaAuto.Size = new System.Drawing.Size(167, 34);
            this.txtMediaLLegadaAuto.TabIndex = 7;
            this.txtMediaLLegadaAuto.Text = "0,66";
            this.txtMediaLLegadaAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblLlegadaAuto
            // 
            this.lblLlegadaAuto.AutoSize = true;
            this.lblLlegadaAuto.Font = new System.Drawing.Font("Microsoft JhengHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegadaAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblLlegadaAuto.Location = new System.Drawing.Point(132, 22);
            this.lblLlegadaAuto.Name = "lblLlegadaAuto";
            this.lblLlegadaAuto.Size = new System.Drawing.Size(382, 23);
            this.lblLlegadaAuto.TabIndex = 6;
            this.lblLlegadaAuto.Text = "Tiempo promedio de llegada de los autos:";
            // 
            // lblParametros
            // 
            this.lblParametros.AutoSize = true;
            this.lblParametros.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblParametros.Location = new System.Drawing.Point(264, 135);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(278, 26);
            this.lblParametros.TabIndex = 6;
            this.lblParametros.Text = "Parámetros (en segundos)";
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.Tomato;
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.ForeColor = System.Drawing.Color.White;
            this.btnSimular.Location = new System.Drawing.Point(525, 586);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(247, 58);
            this.btnSimular.TabIndex = 7;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCerrar.Location = new System.Drawing.Point(12, 586);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(247, 58);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlArmando
            // 
            this.pnlArmando.BackColor = System.Drawing.Color.Tomato;
            this.pnlArmando.Controls.Add(this.lblArmando);
            this.pnlArmando.Location = new System.Drawing.Point(202, 130);
            this.pnlArmando.Name = "pnlArmando";
            this.pnlArmando.Size = new System.Drawing.Size(451, 100);
            this.pnlArmando.TabIndex = 9;
            this.pnlArmando.Visible = false;
            // 
            // lblArmando
            // 
            this.lblArmando.AutoSize = true;
            this.lblArmando.Font = new System.Drawing.Font("Microsoft JhengHei Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmando.ForeColor = System.Drawing.Color.White;
            this.lblArmando.Location = new System.Drawing.Point(43, 28);
            this.lblArmando.Name = "lblArmando";
            this.lblArmando.Size = new System.Drawing.Size(369, 44);
            this.lblArmando.TabIndex = 1;
            this.lblArmando.Text = "Armando simulación...";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 653);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.lblParametros);
            this.Controls.Add(this.pnlParametros);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlParametros.ResumeLayout(false);
            this.pnlParametros.PerformLayout();
            this.pnlArmando.ResumeLayout(false);
            this.pnlArmando.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlParametros;
        private System.Windows.Forms.TextBox txtMediaControlComidaMayores;
        private System.Windows.Forms.Label lblTiempoPromControlComidaMayores;
        private System.Windows.Forms.TextBox txtMediaControlComida;
        private System.Windows.Forms.Label lblTiempoPromControlComida;
        private System.Windows.Forms.TextBox txtMediaAtenciónEntrada;
        private System.Windows.Forms.Label lblTiempoPromAtenciónEntrada;
        private System.Windows.Forms.TextBox txtMediaAtenciónParking;
        private System.Windows.Forms.Label lblTiempoPromAtenciónParking;
        private System.Windows.Forms.TextBox txtMediaLLegadaAuto;
        private System.Windows.Forms.Label lblLlegadaAuto;
        private System.Windows.Forms.Label lblParametros;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCantSimulaciones;
        private System.Windows.Forms.TextBox txtCantSimulaciones;
        private System.Windows.Forms.Label lblVerHasta;
        private System.Windows.Forms.TextBox txtVerHasta;
        private System.Windows.Forms.Label lblVerDesde;
        private System.Windows.Forms.TextBox txtVerDesde;
        private System.Windows.Forms.Panel pnlArmando;
        private System.Windows.Forms.Label lblArmando;
    }
}

