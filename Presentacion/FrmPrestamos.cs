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
    public partial class FrmPrestamos : Form
    {
        int IDPrestamo;
        string PreRequisitos;

        public FrmPrestamos()
        {
            InitializeComponent();
            ListarPrestamos();
        }

        #region FUNCIONES
        public static string ConvertirRequisitos(string requisitos)
        {
            var lista = requisitos.Split(',');
            var nombres = lista
                .Select(num => Enum.GetName(typeof(RequisitoPrestamo), int.Parse(num)))
                .Where(x => x != null);

            return string.Join(", ", nombres);
        }
        private void ListarPrestamos()
        {
            DgvPrestamo.Rows.Clear();

            var lista = PrestamoBL.Instancia.Listar();

            foreach (var item in lista)
            {
                DgvPrestamo.Rows.Add
                    (
                        item.PrestamoId,
                        item.Cliente,
                        item.NroDocumento,
                        item.TipoPrestamo,
                        ConvertirRequisitos(item.Requisitos),
                        item.MontoSolicitado,
                        item.NroCuotas,
                        item.FechaRegistro.ToString("dd/MM/yyyy"),
                        item.Estado
                    );
            }
        }
        private void Buscar(List<Prestamo> filtro)
        {
            DgvPrestamo.Rows.Clear();

            foreach (var item in filtro)
            {
                DgvPrestamo.Rows.Add
                    (
                        item.PrestamoId,
                        item.Cliente,
                        item.NroDocumento,
                        item.TipoPrestamo,
                        ConvertirRequisitos(item.Requisitos),
                        item.MontoSolicitado,
                        item.NroCuotas,
                        item.FechaRegistro.ToString("dd/MM/yyyy"),
                        item.Estado
                    );
            }
        }
        #endregion

        #region METODOS
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var lista = PrestamoBL.Instancia.Buscar(TxtBuscar.Text);
            Buscar(lista);
        }
        #endregion

        #region EVENTOS
        private void DgvPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActual = DgvPrestamo.Rows[e.RowIndex];

            IDPrestamo = Convert.ToInt16(FilaActual.Cells[0].Value);
            PreRequisitos = FilaActual.Cells[4].Value.ToString();

            MessageBox.Show($"PrestamoId: {IDPrestamo}, PreRequisitos: {PreRequisitos}.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IDPrestamo != 0 && PreRequisitos != "")
            {
                var Documentos = new FrmDocumento(IDPrestamo, PreRequisitos);
                Documentos.Show();
                Hide();
            }
            else
            {
                var Documentos = new FrmDocumento(0, "");
                Documentos.Show();
                Hide();
            }
        }
        #endregion
    }
}
