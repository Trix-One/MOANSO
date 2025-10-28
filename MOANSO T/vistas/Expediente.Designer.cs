namespace MOANSO_T.vistas
{
    partial class Expediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expediente));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvExpediente = new System.Windows.Forms.DataGridView();
            this.ExpedienteId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente: Nombre";
            // 
            // DgvExpediente
            // 
            this.DgvExpediente.AllowUserToAddRows = false;
            this.DgvExpediente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvExpediente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpedienteId,
            this.Documento,
            this.Responsable,
            this.Fecha});
            this.DgvExpediente.Location = new System.Drawing.Point(16, 64);
            this.DgvExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.DgvExpediente.Name = "DgvExpediente";
            this.DgvExpediente.ReadOnly = true;
            this.DgvExpediente.RowHeadersWidth = 51;
            this.DgvExpediente.Size = new System.Drawing.Size(760, 348);
            this.DgvExpediente.TabIndex = 2;
            // 
            // ExpedienteId
            // 
            this.ExpedienteId.HeaderText = "ID";
            this.ExpedienteId.MinimumWidth = 6;
            this.ExpedienteId.Name = "ExpedienteId";
            this.ExpedienteId.ReadOnly = true;
            this.ExpedienteId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpedienteId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExpedienteId.Visible = false;
            this.ExpedienteId.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Documento.Width = 250;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.MinimumWidth = 6;
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            this.Responsable.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Brown;
            this.BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(317, 436);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(147, 37);
            this.BtnRegresar.TabIndex = 9;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 498);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvExpediente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Expediente";
            this.Text = "Crecer Financiera";
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvExpediente;
        private System.Windows.Forms.DataGridViewLinkColumn ExpedienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button BtnRegresar;
    }
}