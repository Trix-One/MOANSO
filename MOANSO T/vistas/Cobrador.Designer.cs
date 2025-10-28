namespace MOANSO_T.vistas
{
    partial class Cobrador
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientesC = new System.Windows.Forms.TabPage();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dniC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cronogramaPagos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historialMorosos = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idMorosos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniMorosos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasMoroso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.btnPagoFueraTiempo = new System.Windows.Forms.Button();
            this.btnSubiEvidencia = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.clientesC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cronogramaPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.historialMorosos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientesC);
            this.tabControl1.Controls.Add(this.cronogramaPagos);
            this.tabControl1.Controls.Add(this.historialMorosos);
            this.tabControl1.Location = new System.Drawing.Point(10, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 302);
            this.tabControl1.TabIndex = 15;
            // 
            // clientesC
            // 
            this.clientesC.Controls.Add(this.btnGenerarRecibo);
            this.clientesC.Controls.Add(this.dataGridView1);
            this.clientesC.Location = new System.Drawing.Point(4, 25);
            this.clientesC.Name = "clientesC";
            this.clientesC.Padding = new System.Windows.Forms.Padding(3);
            this.clientesC.Size = new System.Drawing.Size(806, 273);
            this.clientesC.TabIndex = 0;
            this.clientesC.Text = "Clientes";
            this.clientesC.UseVisualStyleBackColor = true;
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerarRecibo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRecibo.ForeColor = System.Drawing.Color.White;
            this.btnGenerarRecibo.Location = new System.Drawing.Point(259, 225);
            this.btnGenerarRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(250, 31);
            this.btnGenerarRecibo.TabIndex = 7;
            this.btnGenerarRecibo.Text = "GENERAR RECIBO NUMERADO";
            this.btnGenerarRecibo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniC,
            this.nombreC,
            this.apellidoC});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // dniC
            // 
            this.dniC.HeaderText = "DNI";
            this.dniC.MinimumWidth = 6;
            this.dniC.Name = "dniC";
            this.dniC.ReadOnly = true;
            this.dniC.Width = 125;
            // 
            // nombreC
            // 
            this.nombreC.HeaderText = "Nombre";
            this.nombreC.MinimumWidth = 6;
            this.nombreC.Name = "nombreC";
            this.nombreC.ReadOnly = true;
            this.nombreC.Width = 125;
            // 
            // apellidoC
            // 
            this.apellidoC.HeaderText = "Apellido";
            this.apellidoC.MinimumWidth = 6;
            this.apellidoC.Name = "apellidoC";
            this.apellidoC.ReadOnly = true;
            this.apellidoC.Width = 125;
            // 
            // cronogramaPagos
            // 
            this.cronogramaPagos.Controls.Add(this.dataGridView2);
            this.cronogramaPagos.Location = new System.Drawing.Point(4, 25);
            this.cronogramaPagos.Name = "cronogramaPagos";
            this.cronogramaPagos.Padding = new System.Windows.Forms.Padding(3);
            this.cronogramaPagos.Size = new System.Drawing.Size(806, 273);
            this.cronogramaPagos.TabIndex = 1;
            this.cronogramaPagos.Text = "Cronograma de Pago";
            this.cronogramaPagos.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(785, 236);
            this.dataGridView2.TabIndex = 0;
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "LUNES";
            this.Lunes.MinimumWidth = 6;
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            this.Lunes.Width = 125;
            // 
            // martes
            // 
            this.martes.HeaderText = "MARTES";
            this.martes.MinimumWidth = 6;
            this.martes.Name = "martes";
            this.martes.ReadOnly = true;
            this.martes.Width = 125;
            // 
            // miercoles
            // 
            this.miercoles.HeaderText = "MIERCOLES";
            this.miercoles.MinimumWidth = 6;
            this.miercoles.Name = "miercoles";
            this.miercoles.ReadOnly = true;
            this.miercoles.Width = 125;
            // 
            // jueves
            // 
            this.jueves.HeaderText = "JUEVES";
            this.jueves.MinimumWidth = 6;
            this.jueves.Name = "jueves";
            this.jueves.ReadOnly = true;
            this.jueves.Width = 125;
            // 
            // viernes
            // 
            this.viernes.HeaderText = "VIERNES";
            this.viernes.MinimumWidth = 6;
            this.viernes.Name = "viernes";
            this.viernes.ReadOnly = true;
            this.viernes.Width = 125;
            // 
            // sabado
            // 
            this.sabado.HeaderText = "SÁBADO";
            this.sabado.MinimumWidth = 6;
            this.sabado.Name = "sabado";
            this.sabado.ReadOnly = true;
            this.sabado.Width = 125;
            // 
            // historialMorosos
            // 
            this.historialMorosos.Controls.Add(this.dataGridView3);
            this.historialMorosos.Location = new System.Drawing.Point(4, 25);
            this.historialMorosos.Name = "historialMorosos";
            this.historialMorosos.Padding = new System.Windows.Forms.Padding(3);
            this.historialMorosos.Size = new System.Drawing.Size(806, 273);
            this.historialMorosos.TabIndex = 2;
            this.historialMorosos.Text = "Historial de Morosos";
            this.historialMorosos.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMorosos,
            this.dniMorosos,
            this.fechaPago,
            this.diasMoroso,
            this.totalMora});
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(794, 234);
            this.dataGridView3.TabIndex = 0;
            // 
            // idMorosos
            // 
            this.idMorosos.HeaderText = "Clientes";
            this.idMorosos.MinimumWidth = 6;
            this.idMorosos.Name = "idMorosos";
            this.idMorosos.ReadOnly = true;
            this.idMorosos.Width = 125;
            // 
            // dniMorosos
            // 
            this.dniMorosos.HeaderText = "DNI";
            this.dniMorosos.MinimumWidth = 6;
            this.dniMorosos.Name = "dniMorosos";
            this.dniMorosos.ReadOnly = true;
            this.dniMorosos.Width = 125;
            // 
            // fechaPago
            // 
            this.fechaPago.HeaderText = "Fecha de Pago";
            this.fechaPago.MinimumWidth = 6;
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.ReadOnly = true;
            this.fechaPago.Width = 125;
            // 
            // diasMoroso
            // 
            this.diasMoroso.HeaderText = "Días Mora";
            this.diasMoroso.MinimumWidth = 6;
            this.diasMoroso.Name = "diasMoroso";
            this.diasMoroso.ReadOnly = true;
            this.diasMoroso.Width = 125;
            // 
            // totalMora
            // 
            this.totalMora.HeaderText = "Total Mora";
            this.totalMora.MinimumWidth = 6;
            this.totalMora.Name = "totalMora";
            this.totalMora.ReadOnly = true;
            this.totalMora.Width = 125;
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnVerCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCliente.ForeColor = System.Drawing.Color.White;
            this.btnVerCliente.Location = new System.Drawing.Point(569, 407);
            this.btnVerCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(137, 31);
            this.btnVerCliente.TabIndex = 14;
            this.btnVerCliente.Text = "VER CLIENTE";
            this.btnVerCliente.UseVisualStyleBackColor = false;
            // 
            // btnPagoFueraTiempo
            // 
            this.btnPagoFueraTiempo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPagoFueraTiempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoFueraTiempo.ForeColor = System.Drawing.Color.White;
            this.btnPagoFueraTiempo.Location = new System.Drawing.Point(309, 407);
            this.btnPagoFueraTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoFueraTiempo.Name = "btnPagoFueraTiempo";
            this.btnPagoFueraTiempo.Size = new System.Drawing.Size(214, 31);
            this.btnPagoFueraTiempo.TabIndex = 13;
            this.btnPagoFueraTiempo.Text = "PAGO FUERA DE TIEMPO";
            this.btnPagoFueraTiempo.UseVisualStyleBackColor = false;
            // 
            // btnSubiEvidencia
            // 
            this.btnSubiEvidencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubiEvidencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubiEvidencia.ForeColor = System.Drawing.Color.White;
            this.btnSubiEvidencia.Location = new System.Drawing.Point(117, 407);
            this.btnSubiEvidencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubiEvidencia.Name = "btnSubiEvidencia";
            this.btnSubiEvidencia.Size = new System.Drawing.Size(167, 31);
            this.btnSubiEvidencia.TabIndex = 12;
            this.btnSubiEvidencia.Text = "SUBIR EVIDENCIA";
            this.btnSubiEvidencia.UseVisualStyleBackColor = false;
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(140, 36);
            this.LblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(111, 20);
            this.LblMensaje.TabIndex = 11;
            this.LblMensaje.Text = "Hola, Cobrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 79);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Cobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVerCliente);
            this.Controls.Add(this.btnPagoFueraTiempo);
            this.Controls.Add(this.btnSubiEvidencia);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cobrador";
            this.Text = "Cobrador";
            this.tabControl1.ResumeLayout(false);
            this.clientesC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cronogramaPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.historialMorosos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientesC;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoC;
        private System.Windows.Forms.TabPage cronogramaPagos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.TabPage historialMorosos;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMorosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniMorosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasMoroso;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMora;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Button btnPagoFueraTiempo;
        private System.Windows.Forms.Button btnSubiEvidencia;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}