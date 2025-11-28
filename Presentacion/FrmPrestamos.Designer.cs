namespace Presentacion
{
    partial class FrmPrestamos
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
            this.GboPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // GboPrestamo
            // 
            this.GboPrestamo.Controls.Add(this.BtnBuscar);
            this.GboPrestamo.Controls.Add(this.TxtBuscar);
            this.GboPrestamo.Controls.Add(this.LblBuscar);
            this.GboPrestamo.Controls.Add(this.DgvPrestamo);
            this.GboPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboPrestamo.Location = new System.Drawing.Point(14, 19);
            this.GboPrestamo.Name = "GboPrestamo";
            this.GboPrestamo.Size = new System.Drawing.Size(756, 336);
            this.GboPrestamo.TabIndex = 3;
            this.GboPrestamo.TabStop = false;
            this.GboPrestamo.Text = "Prestamo";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(254, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 25);
            this.BtnBuscar.TabIndex = 24;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(60, 35);
            this.TxtBuscar.MaxLength = 8;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(177, 27);
            this.TxtBuscar.TabIndex = 2;
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(10, 38);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(56, 20);
            this.LblBuscar.TabIndex = 1;
            this.LblBuscar.Text = "Buscar";
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
            this.DgvPrestamo.Location = new System.Drawing.Point(9, 79);
            this.DgvPrestamo.Name = "DgvPrestamo";
            this.DgvPrestamo.ReadOnly = true;
            this.DgvPrestamo.RowHeadersWidth = 51;
            this.DgvPrestamo.Size = new System.Drawing.Size(728, 236);
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
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 375);
            this.Controls.Add(this.GboPrestamo);
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamos";
            this.GboPrestamo.ResumeLayout(false);
            this.GboPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboPrestamo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
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
    }
}