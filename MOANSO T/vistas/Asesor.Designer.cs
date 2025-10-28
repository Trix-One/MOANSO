namespace MOANSO_T.vistas
{
    partial class Asesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.PbPerfil = new System.Windows.Forms.PictureBox();
            this.TpControl = new System.Windows.Forms.TabControl();
            this.TbAnalisisCrediticio = new System.Windows.Forms.TabPage();
            this.BtnExpedienteCrediticio = new System.Windows.Forms.Button();
            this.BtnRechazadoCrediticio = new System.Windows.Forms.Button();
            this.BtnAprobadoCrediticio = new System.Windows.Forms.Button();
            this.BtnReevaluacionCrediticio = new System.Windows.Forms.Button();
            this.DgvAnalisisCreditcio = new System.Windows.Forms.DataGridView();
            this.ClienteId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbAnalisisRiesgo = new System.Windows.Forms.TabPage();
            this.BtnExpedienteRiesgo = new System.Windows.Forms.Button();
            this.BtnRechazado = new System.Windows.Forms.Button();
            this.BtnAprobado = new System.Windows.Forms.Button();
            this.BtnReevaluacion = new System.Windows.Forms.Button();
            this.DgvAnalisisRiesgo = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpCarteraCliente = new System.Windows.Forms.TabPage();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerfil)).BeginInit();
            this.TpControl.SuspendLayout();
            this.TbAnalisisCrediticio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnalisisCreditcio)).BeginInit();
            this.TbAnalisisRiesgo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnalisisRiesgo)).BeginInit();
            this.TpCarteraCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(116, 48);
            this.LblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(92, 20);
            this.LblMensaje.TabIndex = 5;
            this.LblMensaje.Text = "Hola, Asesor";
            // 
            // PbPerfil
            // 
            this.PbPerfil.Image = global::MOANSO_T.Properties.Resources.Asesor;
            this.PbPerfil.Location = new System.Drawing.Point(16, 24);
            this.PbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.PbPerfil.Name = "PbPerfil";
            this.PbPerfil.Size = new System.Drawing.Size(67, 62);
            this.PbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPerfil.TabIndex = 4;
            this.PbPerfil.TabStop = false;
            // 
            // TpControl
            // 
            this.TpControl.Controls.Add(this.TbAnalisisCrediticio);
            this.TpControl.Controls.Add(this.TbAnalisisRiesgo);
            this.TpControl.Controls.Add(this.TpCarteraCliente);
            this.TpControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpControl.Location = new System.Drawing.Point(16, 105);
            this.TpControl.Margin = new System.Windows.Forms.Padding(4);
            this.TpControl.Name = "TpControl";
            this.TpControl.SelectedIndex = 0;
            this.TpControl.Size = new System.Drawing.Size(831, 393);
            this.TpControl.TabIndex = 3;
            // 
            // TbAnalisisCrediticio
            // 
            this.TbAnalisisCrediticio.Controls.Add(this.BtnExpedienteCrediticio);
            this.TbAnalisisCrediticio.Controls.Add(this.BtnRechazadoCrediticio);
            this.TbAnalisisCrediticio.Controls.Add(this.BtnAprobadoCrediticio);
            this.TbAnalisisCrediticio.Controls.Add(this.BtnReevaluacionCrediticio);
            this.TbAnalisisCrediticio.Controls.Add(this.DgvAnalisisCreditcio);
            this.TbAnalisisCrediticio.Location = new System.Drawing.Point(4, 29);
            this.TbAnalisisCrediticio.Margin = new System.Windows.Forms.Padding(4);
            this.TbAnalisisCrediticio.Name = "TbAnalisisCrediticio";
            this.TbAnalisisCrediticio.Padding = new System.Windows.Forms.Padding(4);
            this.TbAnalisisCrediticio.Size = new System.Drawing.Size(823, 360);
            this.TbAnalisisCrediticio.TabIndex = 0;
            this.TbAnalisisCrediticio.Text = "Análisis Crediticio";
            this.TbAnalisisCrediticio.UseVisualStyleBackColor = true;
            // 
            // BtnExpedienteCrediticio
            // 
            this.BtnExpedienteCrediticio.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnExpedienteCrediticio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpedienteCrediticio.ForeColor = System.Drawing.Color.White;
            this.BtnExpedienteCrediticio.Location = new System.Drawing.Point(652, 306);
            this.BtnExpedienteCrediticio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExpedienteCrediticio.Name = "BtnExpedienteCrediticio";
            this.BtnExpedienteCrediticio.Size = new System.Drawing.Size(160, 31);
            this.BtnExpedienteCrediticio.TabIndex = 7;
            this.BtnExpedienteCrediticio.Text = "VER EXPEDIENTE";
            this.BtnExpedienteCrediticio.UseVisualStyleBackColor = false;
            this.BtnExpedienteCrediticio.Click += new System.EventHandler(this.BtnExpedienteCrediticio_Click);
            // 
            // BtnRechazadoCrediticio
            // 
            this.BtnRechazadoCrediticio.BackColor = System.Drawing.Color.Brown;
            this.BtnRechazadoCrediticio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechazadoCrediticio.ForeColor = System.Drawing.Color.White;
            this.BtnRechazadoCrediticio.Location = new System.Drawing.Point(176, 306);
            this.BtnRechazadoCrediticio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechazadoCrediticio.Name = "BtnRechazadoCrediticio";
            this.BtnRechazadoCrediticio.Size = new System.Drawing.Size(160, 31);
            this.BtnRechazadoCrediticio.TabIndex = 6;
            this.BtnRechazadoCrediticio.Text = "RECHAZADO";
            this.BtnRechazadoCrediticio.UseVisualStyleBackColor = false;
            // 
            // BtnAprobadoCrediticio
            // 
            this.BtnAprobadoCrediticio.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAprobadoCrediticio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAprobadoCrediticio.ForeColor = System.Drawing.Color.White;
            this.BtnAprobadoCrediticio.Location = new System.Drawing.Point(8, 306);
            this.BtnAprobadoCrediticio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAprobadoCrediticio.Name = "BtnAprobadoCrediticio";
            this.BtnAprobadoCrediticio.Size = new System.Drawing.Size(160, 31);
            this.BtnAprobadoCrediticio.TabIndex = 5;
            this.BtnAprobadoCrediticio.Text = "APROBADO";
            this.BtnAprobadoCrediticio.UseVisualStyleBackColor = false;
            // 
            // BtnReevaluacionCrediticio
            // 
            this.BtnReevaluacionCrediticio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnReevaluacionCrediticio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReevaluacionCrediticio.ForeColor = System.Drawing.Color.White;
            this.BtnReevaluacionCrediticio.Location = new System.Drawing.Point(377, 306);
            this.BtnReevaluacionCrediticio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReevaluacionCrediticio.Name = "BtnReevaluacionCrediticio";
            this.BtnReevaluacionCrediticio.Size = new System.Drawing.Size(267, 31);
            this.BtnReevaluacionCrediticio.TabIndex = 3;
            this.BtnReevaluacionCrediticio.Text = "SOLICITAR REEVALUACIÓN";
            this.BtnReevaluacionCrediticio.UseVisualStyleBackColor = false;
            // 
            // DgvAnalisisCreditcio
            // 
            this.DgvAnalisisCreditcio.AllowUserToAddRows = false;
            this.DgvAnalisisCreditcio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAnalisisCreditcio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAnalisisCreditcio.ColumnHeadersHeight = 29;
            this.DgvAnalisisCreditcio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAnalisisCreditcio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.Cliente,
            this.DNI,
            this.Estado});
            this.DgvAnalisisCreditcio.Location = new System.Drawing.Point(8, 23);
            this.DgvAnalisisCreditcio.Margin = new System.Windows.Forms.Padding(4);
            this.DgvAnalisisCreditcio.Name = "DgvAnalisisCreditcio";
            this.DgvAnalisisCreditcio.ReadOnly = true;
            this.DgvAnalisisCreditcio.RowHeadersWidth = 51;
            this.DgvAnalisisCreditcio.Size = new System.Drawing.Size(804, 262);
            this.DgvAnalisisCreditcio.TabIndex = 0;
            // 
            // ClienteId
            // 
            this.ClienteId.HeaderText = "ID";
            this.ClienteId.MinimumWidth = 6;
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteId.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cliente.Width = 200;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 110;
            // 
            // TbAnalisisRiesgo
            // 
            this.TbAnalisisRiesgo.Controls.Add(this.BtnExpedienteRiesgo);
            this.TbAnalisisRiesgo.Controls.Add(this.BtnRechazado);
            this.TbAnalisisRiesgo.Controls.Add(this.BtnAprobado);
            this.TbAnalisisRiesgo.Controls.Add(this.BtnReevaluacion);
            this.TbAnalisisRiesgo.Controls.Add(this.DgvAnalisisRiesgo);
            this.TbAnalisisRiesgo.Location = new System.Drawing.Point(4, 29);
            this.TbAnalisisRiesgo.Margin = new System.Windows.Forms.Padding(4);
            this.TbAnalisisRiesgo.Name = "TbAnalisisRiesgo";
            this.TbAnalisisRiesgo.Padding = new System.Windows.Forms.Padding(4);
            this.TbAnalisisRiesgo.Size = new System.Drawing.Size(823, 360);
            this.TbAnalisisRiesgo.TabIndex = 1;
            this.TbAnalisisRiesgo.Text = "Análisis Riesgo";
            this.TbAnalisisRiesgo.UseVisualStyleBackColor = true;
            // 
            // BtnExpedienteRiesgo
            // 
            this.BtnExpedienteRiesgo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnExpedienteRiesgo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpedienteRiesgo.ForeColor = System.Drawing.Color.White;
            this.BtnExpedienteRiesgo.Location = new System.Drawing.Point(652, 305);
            this.BtnExpedienteRiesgo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExpedienteRiesgo.Name = "BtnExpedienteRiesgo";
            this.BtnExpedienteRiesgo.Size = new System.Drawing.Size(160, 31);
            this.BtnExpedienteRiesgo.TabIndex = 12;
            this.BtnExpedienteRiesgo.Text = "VER EXPEDIENTE";
            this.BtnExpedienteRiesgo.UseVisualStyleBackColor = false;
            this.BtnExpedienteRiesgo.Click += new System.EventHandler(this.BtnExpedienteRiesgo_Click);
            // 
            // BtnRechazado
            // 
            this.BtnRechazado.BackColor = System.Drawing.Color.Brown;
            this.BtnRechazado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechazado.ForeColor = System.Drawing.Color.White;
            this.BtnRechazado.Location = new System.Drawing.Point(176, 305);
            this.BtnRechazado.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechazado.Name = "BtnRechazado";
            this.BtnRechazado.Size = new System.Drawing.Size(160, 31);
            this.BtnRechazado.TabIndex = 11;
            this.BtnRechazado.Text = "RECHAZADO";
            this.BtnRechazado.UseVisualStyleBackColor = false;
            // 
            // BtnAprobado
            // 
            this.BtnAprobado.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAprobado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAprobado.ForeColor = System.Drawing.Color.White;
            this.BtnAprobado.Location = new System.Drawing.Point(8, 305);
            this.BtnAprobado.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAprobado.Name = "BtnAprobado";
            this.BtnAprobado.Size = new System.Drawing.Size(160, 31);
            this.BtnAprobado.TabIndex = 10;
            this.BtnAprobado.Text = "APROBADO";
            this.BtnAprobado.UseVisualStyleBackColor = false;
            // 
            // BtnReevaluacion
            // 
            this.BtnReevaluacion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnReevaluacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReevaluacion.ForeColor = System.Drawing.Color.White;
            this.BtnReevaluacion.Location = new System.Drawing.Point(377, 305);
            this.BtnReevaluacion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReevaluacion.Name = "BtnReevaluacion";
            this.BtnReevaluacion.Size = new System.Drawing.Size(267, 31);
            this.BtnReevaluacion.TabIndex = 9;
            this.BtnReevaluacion.Text = "SOLICITAR REEVALUACIÓN";
            this.BtnReevaluacion.UseVisualStyleBackColor = false;
            // 
            // DgvAnalisisRiesgo
            // 
            this.DgvAnalisisRiesgo.AllowUserToAddRows = false;
            this.DgvAnalisisRiesgo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAnalisisRiesgo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAnalisisRiesgo.ColumnHeadersHeight = 29;
            this.DgvAnalisisRiesgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAnalisisRiesgo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLinkColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DgvAnalisisRiesgo.Location = new System.Drawing.Point(8, 22);
            this.DgvAnalisisRiesgo.Margin = new System.Windows.Forms.Padding(4);
            this.DgvAnalisisRiesgo.Name = "DgvAnalisisRiesgo";
            this.DgvAnalisisRiesgo.ReadOnly = true;
            this.DgvAnalisisRiesgo.RowHeadersWidth = 51;
            this.DgvAnalisisRiesgo.Size = new System.Drawing.Size(804, 262);
            this.DgvAnalisisRiesgo.TabIndex = 8;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "ID";
            this.dataGridViewLinkColumn1.MinimumWidth = 6;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // TpCarteraCliente
            // 
            this.TpCarteraCliente.Controls.Add(this.DgvClientes);
            this.TpCarteraCliente.Location = new System.Drawing.Point(4, 29);
            this.TpCarteraCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TpCarteraCliente.Name = "TpCarteraCliente";
            this.TpCarteraCliente.Padding = new System.Windows.Forms.Padding(4);
            this.TpCarteraCliente.Size = new System.Drawing.Size(823, 360);
            this.TpCarteraCliente.TabIndex = 2;
            this.TpCarteraCliente.Text = "Cartera Clientes";
            this.TpCarteraCliente.UseVisualStyleBackColor = true;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvClientes.ColumnHeadersHeight = 29;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreCliente,
            this.ApellidoCliente,
            this.DNICliente,
            this.Documento,
            this.dataGridViewTextBoxColumn4});
            this.DgvClientes.EnableHeadersVisualStyles = false;
            this.DgvClientes.Location = new System.Drawing.Point(8, 25);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersWidth = 51;
            this.DgvClientes.Size = new System.Drawing.Size(804, 308);
            this.DgvClientes.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombres";
            this.NombreCliente.MinimumWidth = 6;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 125;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Apellidos";
            this.ApellidoCliente.MinimumWidth = 6;
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            this.ApellidoCliente.Width = 125;
            // 
            // DNICliente
            // 
            this.DNICliente.HeaderText = "DNI";
            this.DNICliente.MinimumWidth = 6;
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.ReadOnly = true;
            this.DNICliente.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(696, 49);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(147, 37);
            this.BtnCerrarSesion.TabIndex = 8;
            this.BtnCerrarSesion.Text = "CERRAR SESION";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // Asesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 522);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.PbPerfil);
            this.Controls.Add(this.TpControl);
            this.Name = "Asesor";
            this.Text = "Asesor";
            ((System.ComponentModel.ISupportInitialize)(this.PbPerfil)).EndInit();
            this.TpControl.ResumeLayout(false);
            this.TbAnalisisCrediticio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnalisisCreditcio)).EndInit();
            this.TbAnalisisRiesgo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnalisisRiesgo)).EndInit();
            this.TpCarteraCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.PictureBox PbPerfil;
        private System.Windows.Forms.TabControl TpControl;
        private System.Windows.Forms.TabPage TbAnalisisCrediticio;
        private System.Windows.Forms.Button BtnExpedienteCrediticio;
        private System.Windows.Forms.Button BtnRechazadoCrediticio;
        private System.Windows.Forms.Button BtnAprobadoCrediticio;
        private System.Windows.Forms.Button BtnReevaluacionCrediticio;
        private System.Windows.Forms.DataGridView DgvAnalisisCreditcio;
        private System.Windows.Forms.DataGridViewLinkColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TabPage TbAnalisisRiesgo;
        private System.Windows.Forms.Button BtnExpedienteRiesgo;
        private System.Windows.Forms.Button BtnRechazado;
        private System.Windows.Forms.Button BtnAprobado;
        private System.Windows.Forms.Button BtnReevaluacion;
        private System.Windows.Forms.DataGridView DgvAnalisisRiesgo;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage TpCarteraCliente;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DataGridViewLinkColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button BtnCerrarSesion;
    }
}