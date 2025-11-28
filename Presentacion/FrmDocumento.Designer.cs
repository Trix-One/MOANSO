namespace Presentacion
{
    partial class FrmDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GboDocumento = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAprobar = new System.Windows.Forms.Button();
            this.BtnRechazar = new System.Windows.Forms.Button();
            this.DgvDocumentos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboDatos = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnPrestamo = new System.Windows.Forms.Button();
            this.TxtPrestamoId = new System.Windows.Forms.TextBox();
            this.CboRequisito = new System.Windows.Forms.ComboBox();
            this.LblRequisito = new System.Windows.Forms.Label();
            this.LblPrestamoId = new System.Windows.Forms.Label();
            this.GboDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocumentos)).BeginInit();
            this.GboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboDocumento
            // 
            this.GboDocumento.Controls.Add(this.BtnEliminar);
            this.GboDocumento.Controls.Add(this.BtnAprobar);
            this.GboDocumento.Controls.Add(this.BtnRechazar);
            this.GboDocumento.Controls.Add(this.DgvDocumentos);
            this.GboDocumento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboDocumento.Location = new System.Drawing.Point(11, 159);
            this.GboDocumento.Name = "GboDocumento";
            this.GboDocumento.Size = new System.Drawing.Size(886, 378);
            this.GboDocumento.TabIndex = 3;
            this.GboDocumento.TabStop = false;
            this.GboDocumento.Text = "Documento";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(14, 334);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 29);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAprobar
            // 
            this.BtnAprobar.BackColor = System.Drawing.Color.Green;
            this.BtnAprobar.ForeColor = System.Drawing.Color.White;
            this.BtnAprobar.Location = new System.Drawing.Point(723, 334);
            this.BtnAprobar.Name = "BtnAprobar";
            this.BtnAprobar.Size = new System.Drawing.Size(150, 29);
            this.BtnAprobar.TabIndex = 10;
            this.BtnAprobar.Text = "APROBAR";
            this.BtnAprobar.UseVisualStyleBackColor = false;
            this.BtnAprobar.Click += new System.EventHandler(this.BtnAprobar_Click);
            // 
            // BtnRechazar
            // 
            this.BtnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRechazar.ForeColor = System.Drawing.Color.White;
            this.BtnRechazar.Location = new System.Drawing.Point(561, 334);
            this.BtnRechazar.Name = "BtnRechazar";
            this.BtnRechazar.Size = new System.Drawing.Size(150, 29);
            this.BtnRechazar.TabIndex = 9;
            this.BtnRechazar.Text = "RECHAZAR";
            this.BtnRechazar.UseVisualStyleBackColor = false;
            this.BtnRechazar.Click += new System.EventHandler(this.BtnRechazar_Click);
            // 
            // DgvDocumentos
            // 
            this.DgvDocumentos.AllowUserToAddRows = false;
            this.DgvDocumentos.AllowUserToDeleteRows = false;
            this.DgvDocumentos.AllowUserToResizeColumns = false;
            this.DgvDocumentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Prestamo,
            this.TipoRequisito,
            this.Nombre,
            this.Ruta,
            this.FechaRegistro,
            this.FechaRespuesta,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDocumentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDocumentos.Location = new System.Drawing.Point(14, 51);
            this.DgvDocumentos.Name = "DgvDocumentos";
            this.DgvDocumentos.ReadOnly = true;
            this.DgvDocumentos.RowHeadersWidth = 51;
            this.DgvDocumentos.Size = new System.Drawing.Size(859, 261);
            this.DgvDocumentos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // Prestamo
            // 
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.MinimumWidth = 6;
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.ReadOnly = true;
            this.Prestamo.Width = 65;
            // 
            // TipoRequisito
            // 
            this.TipoRequisito.HeaderText = "Requisito";
            this.TipoRequisito.MinimumWidth = 6;
            this.TipoRequisito.Name = "TipoRequisito";
            this.TipoRequisito.ReadOnly = true;
            this.TipoRequisito.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Ruta
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ruta.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.MinimumWidth = 6;
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            this.Ruta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ruta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ruta.TrackVisitedState = false;
            this.Ruta.VisitedLinkColor = System.Drawing.Color.Black;
            this.Ruta.Width = 250;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 80;
            // 
            // FechaRespuesta
            // 
            this.FechaRespuesta.HeaderText = "Repuesta";
            this.FechaRespuesta.MinimumWidth = 6;
            this.FechaRespuesta.Name = "FechaRespuesta";
            this.FechaRespuesta.ReadOnly = true;
            this.FechaRespuesta.Width = 80;
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
            this.GboDatos.Controls.Add(this.BtnPrestamo);
            this.GboDatos.Controls.Add(this.TxtPrestamoId);
            this.GboDatos.Controls.Add(this.CboRequisito);
            this.GboDatos.Controls.Add(this.LblRequisito);
            this.GboDatos.Controls.Add(this.LblPrestamoId);
            this.GboDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboDatos.Location = new System.Drawing.Point(11, 14);
            this.GboDatos.Name = "GboDatos";
            this.GboDatos.Size = new System.Drawing.Size(481, 126);
            this.GboDatos.TabIndex = 2;
            this.GboDatos.TabStop = false;
            this.GboDatos.Text = "Datos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(319, 70);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 28);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnPrestamo
            // 
            this.BtnPrestamo.Location = new System.Drawing.Point(319, 38);
            this.BtnPrestamo.Name = "BtnPrestamo";
            this.BtnPrestamo.Size = new System.Drawing.Size(39, 23);
            this.BtnPrestamo.TabIndex = 3;
            this.BtnPrestamo.Text = "...";
            this.BtnPrestamo.UseVisualStyleBackColor = true;
            // 
            // TxtPrestamoId
            // 
            this.TxtPrestamoId.Enabled = false;
            this.TxtPrestamoId.Location = new System.Drawing.Point(106, 36);
            this.TxtPrestamoId.Name = "TxtPrestamoId";
            this.TxtPrestamoId.Size = new System.Drawing.Size(178, 27);
            this.TxtPrestamoId.TabIndex = 1;
            // 
            // CboRequisito
            // 
            this.CboRequisito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRequisito.FormattingEnabled = true;
            this.CboRequisito.Location = new System.Drawing.Point(107, 70);
            this.CboRequisito.Name = "CboRequisito";
            this.CboRequisito.Size = new System.Drawing.Size(178, 28);
            this.CboRequisito.TabIndex = 2;
            // 
            // LblRequisito
            // 
            this.LblRequisito.AutoSize = true;
            this.LblRequisito.Location = new System.Drawing.Point(26, 73);
            this.LblRequisito.Name = "LblRequisito";
            this.LblRequisito.Size = new System.Drawing.Size(75, 20);
            this.LblRequisito.TabIndex = 1;
            this.LblRequisito.Text = "Requisito";
            // 
            // LblPrestamoId
            // 
            this.LblPrestamoId.AutoSize = true;
            this.LblPrestamoId.Location = new System.Drawing.Point(26, 38);
            this.LblPrestamoId.Name = "LblPrestamoId";
            this.LblPrestamoId.Size = new System.Drawing.Size(76, 20);
            this.LblPrestamoId.TabIndex = 0;
            this.LblPrestamoId.Text = "Prestamo";
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 550);
            this.Controls.Add(this.GboDocumento);
            this.Controls.Add(this.GboDatos);
            this.Name = "FrmDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocumento";
            this.GboDocumento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocumentos)).EndInit();
            this.GboDatos.ResumeLayout(false);
            this.GboDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboDocumento;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAprobar;
        private System.Windows.Forms.Button BtnRechazar;
        private System.Windows.Forms.DataGridView DgvDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRequisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewLinkColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.GroupBox GboDatos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnPrestamo;
        private System.Windows.Forms.TextBox TxtPrestamoId;
        private System.Windows.Forms.ComboBox CboRequisito;
        private System.Windows.Forms.Label LblRequisito;
        private System.Windows.Forms.Label LblPrestamoId;
    }
}