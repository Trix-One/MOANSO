namespace Presentacion
{
    partial class FrmPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GboPrestamo = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgvPrestamo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoSolicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboDatos = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnGuardarRequisito = new System.Windows.Forms.Button();
            this.CboRequisito = new System.Windows.Forms.ComboBox();
            this.CboTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.TxtNumeroCuotas = new System.Windows.Forms.TextBox();
            this.TxtMontoSolicitado = new System.Windows.Forms.TextBox();
            this.TxtDNICliente = new System.Windows.Forms.TextBox();
            this.LblNroCuotas = new System.Windows.Forms.Label();
            this.LblMontoSolicitado = new System.Windows.Forms.Label();
            this.LblRequisito = new System.Windows.Forms.Label();
            this.LblTipoPrestamo = new System.Windows.Forms.Label();
            this.LblDNICliente = new System.Windows.Forms.Label();
            this.GboPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamo)).BeginInit();
            this.GboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboPrestamo
            // 
            this.GboPrestamo.Controls.Add(this.BtnBuscar);
            this.GboPrestamo.Controls.Add(this.TxtBuscar);
            this.GboPrestamo.Controls.Add(this.LblBuscar);
            this.GboPrestamo.Controls.Add(this.BtnEliminar);
            this.GboPrestamo.Controls.Add(this.DgvPrestamo);
            this.GboPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboPrestamo.Location = new System.Drawing.Point(15, 223);
            this.GboPrestamo.Name = "GboPrestamo";
            this.GboPrestamo.Size = new System.Drawing.Size(663, 367);
            this.GboPrestamo.TabIndex = 3;
            this.GboPrestamo.TabStop = false;
            this.GboPrestamo.Text = "Prestamo";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(252, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 25);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(58, 38);
            this.TxtBuscar.MaxLength = 8;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(177, 27);
            this.TxtBuscar.TabIndex = 26;
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(8, 41);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(56, 20);
            this.LblBuscar.TabIndex = 25;
            this.LblBuscar.Text = "Buscar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(498, 327);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 29);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // DgvPrestamo
            // 
            this.DgvPrestamo.AllowUserToAddRows = false;
            this.DgvPrestamo.AllowUserToDeleteRows = false;
            this.DgvPrestamo.AllowUserToResizeColumns = false;
            this.DgvPrestamo.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.NroDocumento,
            this.TipoPrestamo,
            this.Requisito,
            this.MontoSolicitado,
            this.NroCuotas,
            this.FechaRegistro,
            this.Estado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPrestamo.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPrestamo.Location = new System.Drawing.Point(6, 79);
            this.DgvPrestamo.Name = "DgvPrestamo";
            this.DgvPrestamo.ReadOnly = true;
            this.DgvPrestamo.RowHeadersWidth = 51;
            this.DgvPrestamo.Size = new System.Drawing.Size(642, 236);
            this.DgvPrestamo.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 90;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.MinimumWidth = 6;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Visible = false;
            this.NroDocumento.Width = 125;
            // 
            // TipoPrestamo
            // 
            this.TipoPrestamo.HeaderText = "Tipo Prestamo";
            this.TipoPrestamo.MinimumWidth = 6;
            this.TipoPrestamo.Name = "TipoPrestamo";
            this.TipoPrestamo.ReadOnly = true;
            this.TipoPrestamo.Width = 125;
            // 
            // Requisito
            // 
            this.Requisito.HeaderText = "Requisito";
            this.Requisito.MinimumWidth = 6;
            this.Requisito.Name = "Requisito";
            this.Requisito.ReadOnly = true;
            this.Requisito.Width = 125;
            // 
            // MontoSolicitado
            // 
            this.MontoSolicitado.HeaderText = "Monto Solicitado";
            this.MontoSolicitado.MinimumWidth = 6;
            this.MontoSolicitado.Name = "MontoSolicitado";
            this.MontoSolicitado.ReadOnly = true;
            this.MontoSolicitado.Width = 125;
            // 
            // NroCuotas
            // 
            this.NroCuotas.HeaderText = "NroCuotas";
            this.NroCuotas.MinimumWidth = 6;
            this.NroCuotas.Name = "NroCuotas";
            this.NroCuotas.ReadOnly = true;
            this.NroCuotas.Width = 70;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // GboDatos
            // 
            this.GboDatos.Controls.Add(this.BtnGuardar);
            this.GboDatos.Controls.Add(this.BtnGuardarRequisito);
            this.GboDatos.Controls.Add(this.CboRequisito);
            this.GboDatos.Controls.Add(this.CboTipoPrestamo);
            this.GboDatos.Controls.Add(this.TxtNumeroCuotas);
            this.GboDatos.Controls.Add(this.TxtMontoSolicitado);
            this.GboDatos.Controls.Add(this.TxtDNICliente);
            this.GboDatos.Controls.Add(this.LblNroCuotas);
            this.GboDatos.Controls.Add(this.LblMontoSolicitado);
            this.GboDatos.Controls.Add(this.LblRequisito);
            this.GboDatos.Controls.Add(this.LblTipoPrestamo);
            this.GboDatos.Controls.Add(this.LblDNICliente);
            this.GboDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboDatos.Location = new System.Drawing.Point(15, 12);
            this.GboDatos.Name = "GboDatos";
            this.GboDatos.Size = new System.Drawing.Size(663, 192);
            this.GboDatos.TabIndex = 2;
            this.GboDatos.TabStop = false;
            this.GboDatos.Text = "Datos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(486, 137);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(144, 29);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "GUARDAR PRESTAMO";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarRequisito
            // 
            this.BtnGuardarRequisito.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnGuardarRequisito.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarRequisito.Location = new System.Drawing.Point(330, 137);
            this.BtnGuardarRequisito.Name = "BtnGuardarRequisito";
            this.BtnGuardarRequisito.Size = new System.Drawing.Size(150, 29);
            this.BtnGuardarRequisito.TabIndex = 6;
            this.BtnGuardarRequisito.Text = "GUARDAR REQUISITO";
            this.BtnGuardarRequisito.UseVisualStyleBackColor = false;
            // 
            // CboRequisito
            // 
            this.CboRequisito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRequisito.FormattingEnabled = true;
            this.CboRequisito.Location = new System.Drawing.Point(126, 137);
            this.CboRequisito.Name = "CboRequisito";
            this.CboRequisito.Size = new System.Drawing.Size(145, 28);
            this.CboRequisito.TabIndex = 3;
            // 
            // CboTipoPrestamo
            // 
            this.CboTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPrestamo.FormattingEnabled = true;
            this.CboTipoPrestamo.Location = new System.Drawing.Point(126, 90);
            this.CboTipoPrestamo.Name = "CboTipoPrestamo";
            this.CboTipoPrestamo.Size = new System.Drawing.Size(145, 28);
            this.CboTipoPrestamo.TabIndex = 2;
            // 
            // TxtNumeroCuotas
            // 
            this.TxtNumeroCuotas.Location = new System.Drawing.Point(459, 90);
            this.TxtNumeroCuotas.Name = "TxtNumeroCuotas";
            this.TxtNumeroCuotas.Size = new System.Drawing.Size(171, 27);
            this.TxtNumeroCuotas.TabIndex = 5;
            // 
            // TxtMontoSolicitado
            // 
            this.TxtMontoSolicitado.Location = new System.Drawing.Point(459, 44);
            this.TxtMontoSolicitado.Name = "TxtMontoSolicitado";
            this.TxtMontoSolicitado.Size = new System.Drawing.Size(171, 27);
            this.TxtMontoSolicitado.TabIndex = 4;
            // 
            // TxtDNICliente
            // 
            this.TxtDNICliente.Location = new System.Drawing.Point(126, 45);
            this.TxtDNICliente.MaxLength = 8;
            this.TxtDNICliente.Name = "TxtDNICliente";
            this.TxtDNICliente.Size = new System.Drawing.Size(149, 27);
            this.TxtDNICliente.TabIndex = 1;
            // 
            // LblNroCuotas
            // 
            this.LblNroCuotas.AutoSize = true;
            this.LblNroCuotas.Location = new System.Drawing.Point(332, 94);
            this.LblNroCuotas.Name = "LblNroCuotas";
            this.LblNroCuotas.Size = new System.Drawing.Size(88, 20);
            this.LblNroCuotas.TabIndex = 4;
            this.LblNroCuotas.Text = "Nro Cuotas";
            // 
            // LblMontoSolicitado
            // 
            this.LblMontoSolicitado.AutoSize = true;
            this.LblMontoSolicitado.Location = new System.Drawing.Point(332, 48);
            this.LblMontoSolicitado.Name = "LblMontoSolicitado";
            this.LblMontoSolicitado.Size = new System.Drawing.Size(128, 20);
            this.LblMontoSolicitado.TabIndex = 3;
            this.LblMontoSolicitado.Text = "Monto Solicitado";
            // 
            // LblRequisito
            // 
            this.LblRequisito.AutoSize = true;
            this.LblRequisito.Location = new System.Drawing.Point(16, 140);
            this.LblRequisito.Name = "LblRequisito";
            this.LblRequisito.Size = new System.Drawing.Size(82, 20);
            this.LblRequisito.TabIndex = 2;
            this.LblRequisito.Text = "Requisitos";
            // 
            // LblTipoPrestamo
            // 
            this.LblTipoPrestamo.AutoSize = true;
            this.LblTipoPrestamo.Location = new System.Drawing.Point(16, 94);
            this.LblTipoPrestamo.Name = "LblTipoPrestamo";
            this.LblTipoPrestamo.Size = new System.Drawing.Size(111, 20);
            this.LblTipoPrestamo.TabIndex = 1;
            this.LblTipoPrestamo.Text = "Tipo Prestamo";
            // 
            // LblDNICliente
            // 
            this.LblDNICliente.AutoSize = true;
            this.LblDNICliente.Location = new System.Drawing.Point(16, 48);
            this.LblDNICliente.Name = "LblDNICliente";
            this.LblDNICliente.Size = new System.Drawing.Size(89, 20);
            this.LblDNICliente.TabIndex = 0;
            this.LblDNICliente.Text = "DNI Cliente";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 602);
            this.Controls.Add(this.GboPrestamo);
            this.Controls.Add(this.GboDatos);
            this.Name = "FrmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamo";
            this.GboPrestamo.ResumeLayout(false);
            this.GboPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamo)).EndInit();
            this.GboDatos.ResumeLayout(false);
            this.GboDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboPrestamo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DgvPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoSolicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.GroupBox GboDatos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnGuardarRequisito;
        private System.Windows.Forms.ComboBox CboRequisito;
        private System.Windows.Forms.ComboBox CboTipoPrestamo;
        private System.Windows.Forms.TextBox TxtNumeroCuotas;
        private System.Windows.Forms.TextBox TxtMontoSolicitado;
        private System.Windows.Forms.TextBox TxtDNICliente;
        private System.Windows.Forms.Label LblNroCuotas;
        private System.Windows.Forms.Label LblMontoSolicitado;
        private System.Windows.Forms.Label LblRequisito;
        private System.Windows.Forms.Label LblTipoPrestamo;
        private System.Windows.Forms.Label LblDNICliente;
    }
}