namespace MOANSO_T.vistas
{
    partial class Asistente_Administrativo
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
            this.clientes = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreClienteAsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniClienteAsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faseClienteAsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoClienteAsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleados = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreEmpeado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimosMovimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankingPromotor = new System.Windows.Forms.TabPage();
            this.btnAñadirCliente = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombrePromotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalClientesProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesAprobadosProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.rankingPromotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientes);
            this.tabControl1.Controls.Add(this.empleados);
            this.tabControl1.Controls.Add(this.rankingPromotor);
            this.tabControl1.Location = new System.Drawing.Point(14, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 296);
            this.tabControl1.TabIndex = 3;
            // 
            // clientes
            // 
            this.clientes.Controls.Add(this.dataGridView1);
            this.clientes.Location = new System.Drawing.Point(4, 25);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(3);
            this.clientes.Size = new System.Drawing.Size(764, 267);
            this.clientes.TabIndex = 0;
            this.clientes.Text = "Ver Cliente";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreClienteAsis,
            this.dniClienteAsis,
            this.faseClienteAsis,
            this.estadoClienteAsis,
            this.fechaRegistro});
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombreClienteAsis
            // 
            this.nombreClienteAsis.HeaderText = "Nombre";
            this.nombreClienteAsis.MinimumWidth = 6;
            this.nombreClienteAsis.Name = "nombreClienteAsis";
            this.nombreClienteAsis.ReadOnly = true;
            this.nombreClienteAsis.Width = 125;
            // 
            // dniClienteAsis
            // 
            this.dniClienteAsis.HeaderText = "DNI";
            this.dniClienteAsis.MinimumWidth = 6;
            this.dniClienteAsis.Name = "dniClienteAsis";
            this.dniClienteAsis.ReadOnly = true;
            this.dniClienteAsis.Width = 125;
            // 
            // faseClienteAsis
            // 
            this.faseClienteAsis.HeaderText = "Fase";
            this.faseClienteAsis.MinimumWidth = 6;
            this.faseClienteAsis.Name = "faseClienteAsis";
            this.faseClienteAsis.ReadOnly = true;
            this.faseClienteAsis.Width = 125;
            // 
            // estadoClienteAsis
            // 
            this.estadoClienteAsis.HeaderText = "Estado";
            this.estadoClienteAsis.MinimumWidth = 6;
            this.estadoClienteAsis.Name = "estadoClienteAsis";
            this.estadoClienteAsis.ReadOnly = true;
            this.estadoClienteAsis.Width = 125;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha de Registro";
            this.fechaRegistro.MinimumWidth = 6;
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 125;
            // 
            // empleados
            // 
            this.empleados.Controls.Add(this.dataGridView2);
            this.empleados.Location = new System.Drawing.Point(4, 25);
            this.empleados.Name = "empleados";
            this.empleados.Padding = new System.Windows.Forms.Padding(3);
            this.empleados.Size = new System.Drawing.Size(764, 267);
            this.empleados.TabIndex = 1;
            this.empleados.Text = "Ver Empleados";
            this.empleados.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEmpeado,
            this.dniEmpleado,
            this.cargo,
            this.totalClientes,
            this.ultimosMovimientos});
            this.dataGridView2.Location = new System.Drawing.Point(6, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(736, 229);
            this.dataGridView2.TabIndex = 0;
            // 
            // nombreEmpeado
            // 
            this.nombreEmpeado.HeaderText = "Nombre Empleado";
            this.nombreEmpeado.MinimumWidth = 6;
            this.nombreEmpeado.Name = "nombreEmpeado";
            this.nombreEmpeado.ReadOnly = true;
            this.nombreEmpeado.Width = 125;
            // 
            // dniEmpleado
            // 
            this.dniEmpleado.HeaderText = "DNI Empleado";
            this.dniEmpleado.MinimumWidth = 6;
            this.dniEmpleado.Name = "dniEmpleado";
            this.dniEmpleado.ReadOnly = true;
            this.dniEmpleado.Width = 125;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.MinimumWidth = 6;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 125;
            // 
            // totalClientes
            // 
            this.totalClientes.HeaderText = "Total de Clientes";
            this.totalClientes.MinimumWidth = 6;
            this.totalClientes.Name = "totalClientes";
            this.totalClientes.ReadOnly = true;
            this.totalClientes.Width = 125;
            // 
            // ultimosMovimientos
            // 
            this.ultimosMovimientos.HeaderText = "Ultimos Movimientos";
            this.ultimosMovimientos.MinimumWidth = 6;
            this.ultimosMovimientos.Name = "ultimosMovimientos";
            this.ultimosMovimientos.ReadOnly = true;
            this.ultimosMovimientos.Width = 125;
            // 
            // rankingPromotor
            // 
            this.rankingPromotor.Controls.Add(this.btnAñadirCliente);
            this.rankingPromotor.Controls.Add(this.dataGridView3);
            this.rankingPromotor.Location = new System.Drawing.Point(4, 25);
            this.rankingPromotor.Name = "rankingPromotor";
            this.rankingPromotor.Size = new System.Drawing.Size(764, 267);
            this.rankingPromotor.TabIndex = 2;
            this.rankingPromotor.Text = "Ranking Promotor";
            this.rankingPromotor.UseVisualStyleBackColor = true;
            // 
            // btnAñadirCliente
            // 
            this.btnAñadirCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAñadirCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCliente.ForeColor = System.Drawing.Color.White;
            this.btnAñadirCliente.Location = new System.Drawing.Point(81, 212);
            this.btnAñadirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirCliente.Name = "btnAñadirCliente";
            this.btnAñadirCliente.Size = new System.Drawing.Size(160, 31);
            this.btnAñadirCliente.TabIndex = 7;
            this.btnAñadirCliente.Text = "AÑADIR CLIENTE";
            this.btnAñadirCliente.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePromotor,
            this.totalClientesProm,
            this.clientesAprobadosProm});
            this.dataGridView3.Location = new System.Drawing.Point(8, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(755, 185);
            this.dataGridView3.TabIndex = 0;
            // 
            // nombrePromotor
            // 
            this.nombrePromotor.HeaderText = "Nombre Promotor";
            this.nombrePromotor.MinimumWidth = 6;
            this.nombrePromotor.Name = "nombrePromotor";
            this.nombrePromotor.ReadOnly = true;
            this.nombrePromotor.Width = 125;
            // 
            // totalClientesProm
            // 
            this.totalClientesProm.HeaderText = "Total de Clientes";
            this.totalClientesProm.MinimumWidth = 6;
            this.totalClientesProm.Name = "totalClientesProm";
            this.totalClientesProm.ReadOnly = true;
            this.totalClientesProm.Width = 125;
            // 
            // clientesAprobadosProm
            // 
            this.clientesAprobadosProm.HeaderText = "Clientes Aprobados";
            this.clientesAprobadosProm.MinimumWidth = 6;
            this.clientesAprobadosProm.Name = "clientesAprobadosProm";
            this.clientesAprobadosProm.ReadOnly = true;
            this.clientesAprobadosProm.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 109);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Asistente_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Asistente_Administrativo";
            this.Text = "Asistente_Administrativo";
            this.tabControl1.ResumeLayout(false);
            this.clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.rankingPromotor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteAsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniClienteAsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn faseClienteAsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoClienteAsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.TabPage empleados;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpeado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimosMovimientos;
        private System.Windows.Forms.TabPage rankingPromotor;
        private System.Windows.Forms.Button btnAñadirCliente;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePromotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalClientesProm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesAprobadosProm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}