namespace Colas
{
    partial class Visualizador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.imgArrow = new System.Windows.Forms.PictureBox();
            this.imgX = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdCorrectiva = new System.Windows.Forms.DataGridView();
            this.jornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_averia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_arreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_acum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_prom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_averias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uso_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObjetosTemporales = new System.Windows.Forms.Button();
            this.lblVectorEstado = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCorrectiva)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(217)))), ((int)(((byte)(130)))));
            this.pnlTitulo.Controls.Add(this.imgArrow);
            this.pnlTitulo.Controls.Add(this.imgX);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1334, 90);
            this.pnlTitulo.TabIndex = 3;
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
            this.lblTitulo.Size = new System.Drawing.Size(290, 61);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visualizador";
            // 
            // grdCorrectiva
            // 
            this.grdCorrectiva.AllowUserToAddRows = false;
            this.grdCorrectiva.AllowUserToDeleteRows = false;
            this.grdCorrectiva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grdCorrectiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCorrectiva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCorrectiva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCorrectiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCorrectiva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jornada,
            this.rnd1,
            this.rnd2,
            this.uso,
            this.rnd3,
            this.dia_revision,
            this.dia_averia,
            this.costo_arreglo,
            this.costo_revision,
            this.costo_total,
            this.costo_acum,
            this.costo_prom,
            this.cant_averias,
            this.tiempo_promedio,
            this.uso_max});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCorrectiva.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCorrectiva.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grdCorrectiva.Location = new System.Drawing.Point(6, 133);
            this.grdCorrectiva.Name = "grdCorrectiva";
            this.grdCorrectiva.ReadOnly = true;
            this.grdCorrectiva.RowHeadersWidth = 51;
            this.grdCorrectiva.Size = new System.Drawing.Size(1316, 494);
            this.grdCorrectiva.TabIndex = 4;
            // 
            // jornada
            // 
            this.jornada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jornada.DataPropertyName = "jornada";
            this.jornada.HeaderText = "Jornada";
            this.jornada.MinimumWidth = 6;
            this.jornada.Name = "jornada";
            this.jornada.ReadOnly = true;
            // 
            // rnd1
            // 
            this.rnd1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rnd1.DataPropertyName = "rnd1";
            this.rnd1.HeaderText = "RND1hs";
            this.rnd1.MinimumWidth = 6;
            this.rnd1.Name = "rnd1";
            this.rnd1.ReadOnly = true;
            // 
            // rnd2
            // 
            this.rnd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rnd2.DataPropertyName = "rnd2";
            this.rnd2.HeaderText = "RND2hs";
            this.rnd2.MinimumWidth = 6;
            this.rnd2.Name = "rnd2";
            this.rnd2.ReadOnly = true;
            // 
            // uso
            // 
            this.uso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uso.DataPropertyName = "uso";
            this.uso.HeaderText = "Horas de Uso";
            this.uso.MinimumWidth = 6;
            this.uso.Name = "uso";
            this.uso.ReadOnly = true;
            // 
            // rnd3
            // 
            this.rnd3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rnd3.DataPropertyName = "rnd3";
            this.rnd3.HeaderText = "RNDAvería";
            this.rnd3.MinimumWidth = 6;
            this.rnd3.Name = "rnd3";
            this.rnd3.ReadOnly = true;
            // 
            // dia_revision
            // 
            this.dia_revision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_revision.DataPropertyName = "dia_revision";
            this.dia_revision.HeaderText = "Día Revisión";
            this.dia_revision.MinimumWidth = 6;
            this.dia_revision.Name = "dia_revision";
            this.dia_revision.ReadOnly = true;
            // 
            // dia_averia
            // 
            this.dia_averia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_averia.DataPropertyName = "dia_averia";
            this.dia_averia.HeaderText = "Día Avería";
            this.dia_averia.MinimumWidth = 6;
            this.dia_averia.Name = "dia_averia";
            this.dia_averia.ReadOnly = true;
            // 
            // costo_arreglo
            // 
            this.costo_arreglo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_arreglo.DataPropertyName = "costo_arreglo";
            this.costo_arreglo.HeaderText = "Costo Arreglo";
            this.costo_arreglo.MinimumWidth = 6;
            this.costo_arreglo.Name = "costo_arreglo";
            this.costo_arreglo.ReadOnly = true;
            // 
            // costo_revision
            // 
            this.costo_revision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_revision.DataPropertyName = "costo_revision";
            this.costo_revision.HeaderText = "Costo Revisión";
            this.costo_revision.MinimumWidth = 6;
            this.costo_revision.Name = "costo_revision";
            this.costo_revision.ReadOnly = true;
            // 
            // costo_total
            // 
            this.costo_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_total.DataPropertyName = "costo_total";
            this.costo_total.HeaderText = "Costo Total";
            this.costo_total.MinimumWidth = 6;
            this.costo_total.Name = "costo_total";
            this.costo_total.ReadOnly = true;
            // 
            // costo_acum
            // 
            this.costo_acum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_acum.DataPropertyName = "costo_acum";
            this.costo_acum.HeaderText = "Costo Acum.";
            this.costo_acum.MinimumWidth = 6;
            this.costo_acum.Name = "costo_acum";
            this.costo_acum.ReadOnly = true;
            // 
            // costo_prom
            // 
            this.costo_prom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_prom.DataPropertyName = "costo_prom";
            this.costo_prom.HeaderText = "Costo Diario Promedio";
            this.costo_prom.MinimumWidth = 6;
            this.costo_prom.Name = "costo_prom";
            this.costo_prom.ReadOnly = true;
            // 
            // cant_averias
            // 
            this.cant_averias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cant_averias.DataPropertyName = "cant_averias";
            this.cant_averias.HeaderText = "Cantidad de Averías";
            this.cant_averias.MinimumWidth = 6;
            this.cant_averias.Name = "cant_averias";
            this.cant_averias.ReadOnly = true;
            // 
            // tiempo_promedio
            // 
            this.tiempo_promedio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tiempo_promedio.DataPropertyName = "tiempo_promedio";
            this.tiempo_promedio.HeaderText = "Tiempo Promedio de Avería";
            this.tiempo_promedio.MinimumWidth = 6;
            this.tiempo_promedio.Name = "tiempo_promedio";
            this.tiempo_promedio.ReadOnly = true;
            // 
            // uso_max
            // 
            this.uso_max.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uso_max.DataPropertyName = "uso_max";
            this.uso_max.HeaderText = "Uso Máximo";
            this.uso_max.MinimumWidth = 6;
            this.uso_max.Name = "uso_max";
            this.uso_max.ReadOnly = true;
            // 
            // btnObjetosTemporales
            // 
            this.btnObjetosTemporales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(217)))), ((int)(((byte)(130)))));
            this.btnObjetosTemporales.FlatAppearance.BorderSize = 0;
            this.btnObjetosTemporales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetosTemporales.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.btnObjetosTemporales.ForeColor = System.Drawing.Color.White;
            this.btnObjetosTemporales.Location = new System.Drawing.Point(550, 633);
            this.btnObjetosTemporales.Name = "btnObjetosTemporales";
            this.btnObjetosTemporales.Size = new System.Drawing.Size(708, 39);
            this.btnObjetosTemporales.TabIndex = 8;
            this.btnObjetosTemporales.Text = "Ver objetos temporales";
            this.btnObjetosTemporales.UseVisualStyleBackColor = false;
            // 
            // lblVectorEstado
            // 
            this.lblVectorEstado.AutoSize = true;
            this.lblVectorEstado.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblVectorEstado.Location = new System.Drawing.Point(530, 93);
            this.lblVectorEstado.Name = "lblVectorEstado";
            this.lblVectorEstado.Size = new System.Drawing.Size(195, 35);
            this.lblVectorEstado.TabIndex = 9;
            this.lblVectorEstado.Text = "Vector Estado";
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.lblVectorEstado);
            this.Controls.Add(this.btnObjetosTemporales);
            this.Controls.Add(this.grdCorrectiva);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visualizador";
            this.Text = "Form1";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCorrectiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox imgArrow;
        private System.Windows.Forms.PictureBox imgX;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.DataGridView grdCorrectiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn jornada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn uso;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_averia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_arreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_acum;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_prom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_averias;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn uso_max;
        private System.Windows.Forms.Button btnObjetosTemporales;
        private System.Windows.Forms.Label lblVectorEstado;
    }
}