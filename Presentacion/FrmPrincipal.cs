using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region FUNCIONES

        #endregion

        #region METODOS
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            var Cliente = new FrmCliente();
            Cliente.Show();
            Hide();
        }

        private void BtnPrestamo_Click(object sender, EventArgs e)
        {
            var Prestamo = new FrmPrestamo(1);
            Prestamo.Show();
            Hide();
        }

        private void BtnCronogramaPagos_Click(object sender, EventArgs e)
        {
            var Cronograma = new FrmPrestamo(0);
            Cronograma.Show();
            Hide();
        }

        private void BtnDocumento_Click(object sender, EventArgs e)
        {
            var Documentos = new FrmDocumento(0, "");
            Documentos.Show();
            Hide();
        }
        #endregion

        #region EVENTOS
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
        #endregion
    }
}
