using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO_T
{
    public partial class Form0 : System.Windows.Forms.Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 Administrador = new Form1();
            Administrador.Show();
        }
    }
}
