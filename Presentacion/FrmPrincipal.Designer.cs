namespace Presentacion
{
    partial class FrmPrincipal
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
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.BtnPrestamo = new System.Windows.Forms.Button();
            this.BtnDocumento = new System.Windows.Forms.Button();
            this.BtnCronogramaPagos = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(33, 362);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(21, 20);
            this.LblCargo.TabIndex = 45;
            this.LblCargo.Text = "...";
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(33, 30);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(21, 20);
            this.LblBienvenido.TabIndex = 44;
            this.LblBienvenido.Text = "...";
            // 
            // BtnPrestamo
            // 
            this.BtnPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrestamo.Image = global::Presentacion.Properties.Resources.contrato;
            this.BtnPrestamo.Location = new System.Drawing.Point(211, 67);
            this.BtnPrestamo.Name = "BtnPrestamo";
            this.BtnPrestamo.Size = new System.Drawing.Size(110, 104);
            this.BtnPrestamo.TabIndex = 43;
            this.BtnPrestamo.Text = "PRESTAMO";
            this.BtnPrestamo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPrestamo.UseVisualStyleBackColor = true;
            this.BtnPrestamo.Click += new System.EventHandler(this.BtnPrestamo_Click);
            // 
            // BtnDocumento
            // 
            this.BtnDocumento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDocumento.Image = global::Presentacion.Properties.Resources.Documento;
            this.BtnDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDocumento.Location = new System.Drawing.Point(67, 221);
            this.BtnDocumento.Name = "BtnDocumento";
            this.BtnDocumento.Size = new System.Drawing.Size(110, 104);
            this.BtnDocumento.TabIndex = 42;
            this.BtnDocumento.Text = "DOCUMENTO";
            this.BtnDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDocumento.UseVisualStyleBackColor = true;
            this.BtnDocumento.Click += new System.EventHandler(this.BtnDocumento_Click);
            // 
            // BtnCronogramaPagos
            // 
            this.BtnCronogramaPagos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCronogramaPagos.Image = global::Presentacion.Properties.Resources.cronograma;
            this.BtnCronogramaPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCronogramaPagos.Location = new System.Drawing.Point(211, 221);
            this.BtnCronogramaPagos.Name = "BtnCronogramaPagos";
            this.BtnCronogramaPagos.Size = new System.Drawing.Size(110, 104);
            this.BtnCronogramaPagos.TabIndex = 41;
            this.BtnCronogramaPagos.Text = "CRONOGRAMA PAGOS";
            this.BtnCronogramaPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCronogramaPagos.UseVisualStyleBackColor = true;
            this.BtnCronogramaPagos.Click += new System.EventHandler(this.BtnCronogramaPagos_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Image = global::Presentacion.Properties.Resources.Cliente;
            this.BtnCliente.Location = new System.Drawing.Point(67, 67);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(110, 104);
            this.BtnCliente.TabIndex = 40;
            this.BtnCliente.Text = "CLIENTE";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 401);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.BtnPrestamo);
            this.Controls.Add(this.BtnDocumento);
            this.Controls.Add(this.BtnCronogramaPagos);
            this.Controls.Add(this.BtnCliente);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Button BtnPrestamo;
        private System.Windows.Forms.Button BtnDocumento;
        private System.Windows.Forms.Button BtnCronogramaPagos;
        private System.Windows.Forms.Button BtnCliente;
    }
}