namespace MOANSO_T.vistas
{
    partial class Administrador
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
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.TpControl = new System.Windows.Forms.TabControl();
            this.TbRegistar = new System.Windows.Forms.TabPage();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.BtnGenerarPdf = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.CboZonaAsignada = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TbSolicitarPdf = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirreccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdf = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TbReevaluacion = new System.Windows.Forms.TabPage();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TpControl.SuspendLayout();
            this.TbRegistar.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.TbSolicitarPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(710, 39);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(147, 37);
            this.BtnCerrarSesion.TabIndex = 7;
            this.BtnCerrarSesion.Text = "CERRAR SESION";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // TpControl
            // 
            this.TpControl.Controls.Add(this.TbRegistar);
            this.TpControl.Controls.Add(this.TbSolicitarPdf);
            this.TpControl.Controls.Add(this.TbReevaluacion);
            this.TpControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpControl.Location = new System.Drawing.Point(19, 97);
            this.TpControl.Margin = new System.Windows.Forms.Padding(4);
            this.TpControl.Name = "TpControl";
            this.TpControl.SelectedIndex = 0;
            this.TpControl.Size = new System.Drawing.Size(843, 442);
            this.TpControl.TabIndex = 6;
            // 
            // TbRegistar
            // 
            this.TbRegistar.Controls.Add(this.GbCliente);
            this.TbRegistar.Location = new System.Drawing.Point(4, 29);
            this.TbRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.TbRegistar.Name = "TbRegistar";
            this.TbRegistar.Padding = new System.Windows.Forms.Padding(4);
            this.TbRegistar.Size = new System.Drawing.Size(835, 409);
            this.TbRegistar.TabIndex = 0;
            this.TbRegistar.Text = "Registar";
            this.TbRegistar.UseVisualStyleBackColor = true;
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.TxtTelefono);
            this.GbCliente.Controls.Add(this.TxtDireccion);
            this.GbCliente.Controls.Add(this.TxtDni);
            this.GbCliente.Controls.Add(this.TxtApellidos);
            this.GbCliente.Controls.Add(this.TxtNombres);
            this.GbCliente.Controls.Add(this.BtnGenerarPdf);
            this.GbCliente.Controls.Add(this.Lbl);
            this.GbCliente.Controls.Add(this.CboZonaAsignada);
            this.GbCliente.Controls.Add(this.BtnGuardar);
            this.GbCliente.Controls.Add(this.LblTelefono);
            this.GbCliente.Controls.Add(this.LblDireccion);
            this.GbCliente.Controls.Add(this.LblDni);
            this.GbCliente.Controls.Add(this.LblApellidos);
            this.GbCliente.Controls.Add(this.LblNombre);
            this.GbCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(8, 7);
            this.GbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Padding = new System.Windows.Forms.Padding(4);
            this.GbCliente.Size = new System.Drawing.Size(816, 395);
            this.GbCliente.TabIndex = 1;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos Cliente";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(265, 270);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.MaxLength = 9;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(212, 27);
            this.TxtTelefono.TabIndex = 13;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(265, 223);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(212, 27);
            this.TxtDireccion.TabIndex = 12;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(265, 170);
            this.TxtDni.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDni.MaxLength = 8;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(212, 27);
            this.TxtDni.TabIndex = 11;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(265, 112);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(212, 27);
            this.TxtApellidos.TabIndex = 10;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(265, 59);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(212, 27);
            this.TxtNombres.TabIndex = 9;
            // 
            // BtnGenerarPdf
            // 
            this.BtnGenerarPdf.BackColor = System.Drawing.Color.Brown;
            this.BtnGenerarPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarPdf.ForeColor = System.Drawing.Color.White;
            this.BtnGenerarPdf.Location = new System.Drawing.Point(588, 192);
            this.BtnGenerarPdf.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGenerarPdf.Name = "BtnGenerarPdf";
            this.BtnGenerarPdf.Size = new System.Drawing.Size(147, 31);
            this.BtnGenerarPdf.TabIndex = 8;
            this.BtnGenerarPdf.Text = "GENERAR PDF";
            this.BtnGenerarPdf.UseVisualStyleBackColor = false;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(25, 334);
            this.Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(109, 20);
            this.Lbl.TabIndex = 7;
            this.Lbl.Text = "Zona Asignada";
            // 
            // CboZonaAsignada
            // 
            this.CboZonaAsignada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboZonaAsignada.FormattingEnabled = true;
            this.CboZonaAsignada.Items.AddRange(new object[] {
            "Seleccionar una opción",
            "Trujillo",
            "Chiclayo",
            "Piura",
            "Lima"});
            this.CboZonaAsignada.Location = new System.Drawing.Point(265, 324);
            this.CboZonaAsignada.Margin = new System.Windows.Forms.Padding(4);
            this.CboZonaAsignada.Name = "CboZonaAsignada";
            this.CboZonaAsignada.Size = new System.Drawing.Size(212, 28);
            this.CboZonaAsignada.TabIndex = 6;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(588, 133);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(147, 31);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(25, 278);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(67, 20);
            this.LblTelefono.TabIndex = 4;
            this.LblTelefono.Text = "Teléfono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(25, 231);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(72, 20);
            this.LblDireccion.TabIndex = 3;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(25, 177);
            this.LblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(202, 20);
            this.LblDni.TabIndex = 2;
            this.LblDni.Text = "Documento de Identificación";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(25, 118);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(72, 20);
            this.LblApellidos.TabIndex = 1;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(25, 68);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(70, 20);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombres";
            // 
            // TbSolicitarPdf
            // 
            this.TbSolicitarPdf.Controls.Add(this.button1);
            this.TbSolicitarPdf.Controls.Add(this.dataGridView1);
            this.TbSolicitarPdf.Location = new System.Drawing.Point(4, 29);
            this.TbSolicitarPdf.Margin = new System.Windows.Forms.Padding(4);
            this.TbSolicitarPdf.Name = "TbSolicitarPdf";
            this.TbSolicitarPdf.Padding = new System.Windows.Forms.Padding(4);
            this.TbSolicitarPdf.Size = new System.Drawing.Size(835, 409);
            this.TbSolicitarPdf.TabIndex = 1;
            this.TbSolicitarPdf.Text = "Solicitar Pdf";
            this.TbSolicitarPdf.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Dni,
            this.Dirreccion,
            this.Telefono,
            this.Pdf});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(804, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 135;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 125;
            // 
            // Dirreccion
            // 
            this.Dirreccion.HeaderText = "Dirección";
            this.Dirreccion.MinimumWidth = 6;
            this.Dirreccion.Name = "Dirreccion";
            this.Dirreccion.ReadOnly = true;
            this.Dirreccion.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Pdf
            // 
            this.Pdf.HeaderText = "Pdf";
            this.Pdf.MinimumWidth = 6;
            this.Pdf.Name = "Pdf";
            this.Pdf.ReadOnly = true;
            this.Pdf.Width = 125;
            // 
            // TbReevaluacion
            // 
            this.TbReevaluacion.Location = new System.Drawing.Point(4, 29);
            this.TbReevaluacion.Margin = new System.Windows.Forms.Padding(4);
            this.TbReevaluacion.Name = "TbReevaluacion";
            this.TbReevaluacion.Padding = new System.Windows.Forms.Padding(4);
            this.TbReevaluacion.Size = new System.Drawing.Size(835, 409);
            this.TbReevaluacion.TabIndex = 2;
            this.TbReevaluacion.Text = "Reevaluación";
            this.TbReevaluacion.UseVisualStyleBackColor = true;
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(115, 37);
            this.LblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(143, 20);
            this.LblMensaje.TabIndex = 5;
            this.LblMensaje.Text = "Hola, Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MOANSO_T.Properties.Resources.Administrador;
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(339, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "GENERAR PDF";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 554);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.TpControl);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.TpControl.ResumeLayout(false);
            this.TbRegistar.ResumeLayout(false);
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.TbSolicitarPdf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.TabControl TpControl;
        private System.Windows.Forms.TabPage TbRegistar;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Button BtnGenerarPdf;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.ComboBox CboZonaAsignada;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TabPage TbSolicitarPdf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirreccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewLinkColumn Pdf;
        private System.Windows.Forms.TabPage TbReevaluacion;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}