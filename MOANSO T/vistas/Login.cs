using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO_T.vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Usuarios y contraseñas temporales creados aquí mismo
            string usuario = TxtUsuario.Text;
            string contra = TxtClave.Text;

            // Validación directa
            if (usuario == "Asesor" && contra == "1234")
            {
                new Asesor().Show();
                this.Hide();
            }
            else if (usuario == "Cobrador" && contra == "cob123")
            {
                new Cobrador().Show();
                this.Hide();
            }
            else if (usuario == "AsistenteAdministrativo" && contra == "asis2025")
            {
                new Asistente_Administrativo().Show();
                this.Hide();
            }
            else if (usuario == "Administrador" && contra == "admin123")
            {
                new Administrador().Show();
                this.Hide();
            }
            else if (usuario == "Supervisor" && contra == "sup2025")
            {
                new Supervisor().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
