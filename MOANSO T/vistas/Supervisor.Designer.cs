namespace MOANSO_T.vistas
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.LblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.validarsolicitud = new System.Windows.Forms.TabPage();
            this.btnRechazadoSuper = new System.Windows.Forms.Button();
            this.btnAprobadoSuper = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignarResponsable = new System.Windows.Forms.TabPage();
            this.btnCambiarCobrador = new System.Windows.Forms.Button();
            this.btnCambiarAsesor = new System.Windows.Forms.Button();
            this.btnAsignarCobrador = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dniAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidocliSuper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoAsesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verContrato = new System.Windows.Forms.TabPage();
            this.btnAplazarContrato = new System.Windows.Forms.Button();
            this.btnGenerarContrato = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniSuperv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSuper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.validarsolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.asignarResponsable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.verContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(143, 53);
            this.LblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(117, 20);
            this.LblMensaje.TabIndex = 6;
            this.LblMensaje.Text = "Hola, Supervisor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.validarsolicitud);
            this.tabControl1.Controls.Add(this.asignarResponsable);
            this.tabControl1.Controls.Add(this.verContrato);
            this.tabControl1.Location = new System.Drawing.Point(12, 129);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 309);
            this.tabControl1.TabIndex = 4;
            // 
            // validarsolicitud
            // 
            this.validarsolicitud.Controls.Add(this.btnRechazadoSuper);
            this.validarsolicitud.Controls.Add(this.btnAprobadoSuper);
            this.validarsolicitud.Controls.Add(this.dataGridView1);
            this.validarsolicitud.Location = new System.Drawing.Point(4, 25);
            this.validarsolicitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validarsolicitud.Name = "validarsolicitud";
            this.validarsolicitud.Size = new System.Drawing.Size(768, 280);
            this.validarsolicitud.TabIndex = 0;
            this.validarsolicitud.Text = "Validar Solicitud";
            this.validarsolicitud.UseVisualStyleBackColor = true;
            // 
            // btnRechazadoSuper
            // 
            this.btnRechazadoSuper.BackColor = System.Drawing.Color.Brown;
            this.btnRechazadoSuper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazadoSuper.ForeColor = System.Drawing.Color.White;
            this.btnRechazadoSuper.Location = new System.Drawing.Point(419, 229);
            this.btnRechazadoSuper.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechazadoSuper.Name = "btnRechazadoSuper";
            this.btnRechazadoSuper.Size = new System.Drawing.Size(160, 31);
            this.btnRechazadoSuper.TabIndex = 7;
            this.btnRechazadoSuper.Text = "RECHAZADO";
            this.btnRechazadoSuper.UseVisualStyleBackColor = false;
            // 
            // btnAprobadoSuper
            // 
            this.btnAprobadoSuper.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAprobadoSuper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobadoSuper.ForeColor = System.Drawing.Color.White;
            this.btnAprobadoSuper.Location = new System.Drawing.Point(204, 229);
            this.btnAprobadoSuper.Margin = new System.Windows.Forms.Padding(4);
            this.btnAprobadoSuper.Name = "btnAprobadoSuper";
            this.btnAprobadoSuper.Size = new System.Drawing.Size(160, 31);
            this.btnAprobadoSuper.TabIndex = 6;
            this.btnAprobadoSuper.Text = "APROBADO";
            this.btnAprobadoSuper.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Estado,
            this.DNI});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // asignarResponsable
            // 
            this.asignarResponsable.Controls.Add(this.btnCambiarCobrador);
            this.asignarResponsable.Controls.Add(this.btnCambiarAsesor);
            this.asignarResponsable.Controls.Add(this.btnAsignarCobrador);
            this.asignarResponsable.Controls.Add(this.dataGridView2);
            this.asignarResponsable.Location = new System.Drawing.Point(4, 25);
            this.asignarResponsable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asignarResponsable.Name = "asignarResponsable";
            this.asignarResponsable.Size = new System.Drawing.Size(768, 280);
            this.asignarResponsable.TabIndex = 1;
            this.asignarResponsable.Text = "Asignar Responsable";
            this.asignarResponsable.UseVisualStyleBackColor = true;
            // 
            // btnCambiarCobrador
            // 
            this.btnCambiarCobrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCambiarCobrador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarCobrador.ForeColor = System.Drawing.Color.White;
            this.btnCambiarCobrador.Location = new System.Drawing.Point(563, 223);
            this.btnCambiarCobrador.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarCobrador.Name = "btnCambiarCobrador";
            this.btnCambiarCobrador.Size = new System.Drawing.Size(188, 31);
            this.btnCambiarCobrador.TabIndex = 7;
            this.btnCambiarCobrador.Text = "CAMBIAR COBRADOR";
            this.btnCambiarCobrador.UseVisualStyleBackColor = false;
            // 
            // btnCambiarAsesor
            // 
            this.btnCambiarAsesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCambiarAsesor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarAsesor.ForeColor = System.Drawing.Color.White;
            this.btnCambiarAsesor.Location = new System.Drawing.Point(325, 223);
            this.btnCambiarAsesor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarAsesor.Name = "btnCambiarAsesor";
            this.btnCambiarAsesor.Size = new System.Drawing.Size(171, 31);
            this.btnCambiarAsesor.TabIndex = 6;
            this.btnCambiarAsesor.Text = "CAMBIAR ASESOR ";
            this.btnCambiarAsesor.UseVisualStyleBackColor = false;
            // 
            // btnAsignarCobrador
            // 
            this.btnAsignarCobrador.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAsignarCobrador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarCobrador.ForeColor = System.Drawing.Color.White;
            this.btnAsignarCobrador.Location = new System.Drawing.Point(4, 223);
            this.btnAsignarCobrador.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarCobrador.Name = "btnAsignarCobrador";
            this.btnAsignarCobrador.Size = new System.Drawing.Size(296, 31);
            this.btnAsignarCobrador.TabIndex = 5;
            this.btnAsignarCobrador.Text = "ASIGNAR ASESOR Y COBRADOR ";
            this.btnAsignarCobrador.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniAsignar,
            this.nombreCli,
            this.apellidocliSuper,
            this.EstadoAsesor,
            this.cobrador});
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(763, 213);
            this.dataGridView2.TabIndex = 0;
            // 
            // dniAsignar
            // 
            this.dniAsignar.HeaderText = "DNI";
            this.dniAsignar.MinimumWidth = 6;
            this.dniAsignar.Name = "dniAsignar";
            this.dniAsignar.ReadOnly = true;
            this.dniAsignar.Width = 125;
            // 
            // nombreCli
            // 
            this.nombreCli.HeaderText = "Nombre";
            this.nombreCli.MinimumWidth = 6;
            this.nombreCli.Name = "nombreCli";
            this.nombreCli.ReadOnly = true;
            this.nombreCli.Width = 125;
            // 
            // apellidocliSuper
            // 
            this.apellidocliSuper.HeaderText = "Apellido";
            this.apellidocliSuper.MinimumWidth = 6;
            this.apellidocliSuper.Name = "apellidocliSuper";
            this.apellidocliSuper.ReadOnly = true;
            this.apellidocliSuper.Width = 125;
            // 
            // EstadoAsesor
            // 
            this.EstadoAsesor.HeaderText = "Asesor Encargado";
            this.EstadoAsesor.MinimumWidth = 6;
            this.EstadoAsesor.Name = "EstadoAsesor";
            this.EstadoAsesor.ReadOnly = true;
            this.EstadoAsesor.Width = 125;
            // 
            // cobrador
            // 
            this.cobrador.HeaderText = "Cobrador Encargado";
            this.cobrador.MinimumWidth = 6;
            this.cobrador.Name = "cobrador";
            this.cobrador.ReadOnly = true;
            this.cobrador.Width = 125;
            // 
            // verContrato
            // 
            this.verContrato.Controls.Add(this.btnAplazarContrato);
            this.verContrato.Controls.Add(this.btnGenerarContrato);
            this.verContrato.Controls.Add(this.dataGridView3);
            this.verContrato.Location = new System.Drawing.Point(4, 25);
            this.verContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verContrato.Name = "verContrato";
            this.verContrato.Size = new System.Drawing.Size(768, 280);
            this.verContrato.TabIndex = 2;
            this.verContrato.Text = "Contrato";
            this.verContrato.UseVisualStyleBackColor = true;
            // 
            // btnAplazarContrato
            // 
            this.btnAplazarContrato.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAplazarContrato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplazarContrato.ForeColor = System.Drawing.Color.White;
            this.btnAplazarContrato.Location = new System.Drawing.Point(395, 217);
            this.btnAplazarContrato.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplazarContrato.Name = "btnAplazarContrato";
            this.btnAplazarContrato.Size = new System.Drawing.Size(171, 31);
            this.btnAplazarContrato.TabIndex = 8;
            this.btnAplazarContrato.Text = "APLAZAR CONTRATO";
            this.btnAplazarContrato.UseVisualStyleBackColor = false;
            // 
            // btnGenerarContrato
            // 
            this.btnGenerarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerarContrato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarContrato.ForeColor = System.Drawing.Color.White;
            this.btnGenerarContrato.Location = new System.Drawing.Point(216, 217);
            this.btnGenerarContrato.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarContrato.Name = "btnGenerarContrato";
            this.btnGenerarContrato.Size = new System.Drawing.Size(171, 31);
            this.btnGenerarContrato.TabIndex = 7;
            this.btnGenerarContrato.Text = "GENERAR CONTRATO";
            this.btnGenerarContrato.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.dniSuperv,
            this.estadoSuper,
            this.fechaFirma});
            this.dataGridView3.Location = new System.Drawing.Point(3, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(763, 194);
            this.dataGridView3.TabIndex = 0;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 125;
            // 
            // dniSuperv
            // 
            this.dniSuperv.HeaderText = "DNI";
            this.dniSuperv.MinimumWidth = 6;
            this.dniSuperv.Name = "dniSuperv";
            this.dniSuperv.ReadOnly = true;
            this.dniSuperv.Width = 125;
            // 
            // estadoSuper
            // 
            this.estadoSuper.HeaderText = "Estado";
            this.estadoSuper.MinimumWidth = 6;
            this.estadoSuper.Name = "estadoSuper";
            this.estadoSuper.ReadOnly = true;
            this.estadoSuper.Width = 125;
            // 
            // fechaFirma
            // 
            this.fechaFirma.HeaderText = "Fecha de Firma";
            this.fechaFirma.MinimumWidth = 6;
            this.fechaFirma.Name = "fechaFirma";
            this.fechaFirma.ReadOnly = true;
            this.fechaFirma.Width = 125;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(623, 53);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(147, 37);
            this.BtnCerrarSesion.TabIndex = 8;
            this.BtnCerrarSesion.Text = "CERRAR SESION";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Supervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crecer Financiera";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.validarsolicitud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.asignarResponsable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.verContrato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage validarsolicitud;
        private System.Windows.Forms.Button btnRechazadoSuper;
        private System.Windows.Forms.Button btnAprobadoSuper;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.TabPage asignarResponsable;
        private System.Windows.Forms.Button btnCambiarCobrador;
        private System.Windows.Forms.Button btnCambiarAsesor;
        private System.Windows.Forms.Button btnAsignarCobrador;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidocliSuper;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobrador;
        private System.Windows.Forms.TabPage verContrato;
        private System.Windows.Forms.Button btnAplazarContrato;
        private System.Windows.Forms.Button btnGenerarContrato;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniSuperv;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoSuper;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFirma;
        private System.Windows.Forms.Button BtnCerrarSesion;
    }
}