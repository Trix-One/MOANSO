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
    public partial class Cobrador : Form
    {
        public Cobrador()
        {
            InitializeComponent();
        }
        #region Validaciones
        void RedirigirLogin()
        {
            Hide();
            Login _Login = new Login();
            _Login.Show();
        }

        //void bool ValidarFormulario() { }
        #endregion

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            RedirigirLogin();
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            Expediente expediente = new Expediente();
            expediente.ShowDialog();
        }
    }
}
