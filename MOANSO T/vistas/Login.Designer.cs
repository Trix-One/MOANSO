namespace MOANSO_T.vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LblLogin = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PbAccesoControl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbAccesoControl)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(642, 25);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(78, 32);
            this.LblLogin.TabIndex = 16;
            this.LblLogin.Text = "Login";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.Location = new System.Drawing.Point(705, 201);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(156, 34);
            this.BtnIngresar.TabIndex = 15;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(516, 201);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(156, 34);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(648, 139);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(4);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(191, 22);
            this.TxtClave.TabIndex = 13;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(648, 89);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(191, 22);
            this.TxtUsuario.TabIndex = 12;
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(533, 139);
            this.LblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(54, 20);
            this.LblClave.TabIndex = 11;
            this.LblClave.Text = "CLAVE";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(533, 91);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(76, 20);
            this.LblUsuario.TabIndex = 10;
            this.LblUsuario.Text = "USUARIO";
            // 
            // PbAccesoControl
            // 
            this.PbAccesoControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbAccesoControl.Image = global::MOANSO_T.Properties.Resources.ControlAcceso;
            this.PbAccesoControl.Location = new System.Drawing.Point(34, 24);
            this.PbAccesoControl.Margin = new System.Windows.Forms.Padding(4);
            this.PbAccesoControl.Name = "PbAccesoControl";
            this.PbAccesoControl.Size = new System.Drawing.Size(440, 238);
            this.PbAccesoControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAccesoControl.TabIndex = 9;
            this.PbAccesoControl.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 287);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.PbAccesoControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crecer Financiera";
            ((System.ComponentModel.ISupportInitialize)(this.PbAccesoControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PbAccesoControl;
    }
}