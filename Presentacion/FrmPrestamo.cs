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
    public partial class FrmPrestamo : Form
    {
        private Prestamo _Prestamo;
        private readonly List<int> ListaRequisitos = new List<int>();
        string requisitos = "";
        private int IDPrestamo = 0;
        private int Numero;

        public FrmPrestamo(int numero)
        {
            InitializeComponent();
            Numero = numero;
            InicializarDatos();
            ListarPrestamos();
        }

        #region FUNCIONES
        private void InicializarDatos()
        {
            CboTipoPrestamo.DataSource = Enum.GetNames(typeof(TipoPrestamo));

            CboRequisito.DataSource = Enum.GetValues(typeof(RequisitoPrestamo))
            .Cast<RequisitoPrestamo>().Select(x => new { Text = x.ToString(), Value = (int)x }).ToList();

            CboRequisito.DisplayMember = "Text";
            CboRequisito.ValueMember = "Value";

            GboDatos.Enabled = (Numero == 1);
        }
        private void LimpiarCampos()
        {
            TxtDNICliente.Text = "";
            TxtMontoSolicitado.Text = "";
            TxtNumeroCuotas.Text = "";
            requisitos = "";
            ListaRequisitos.Clear();

            CboTipoPrestamo.SelectedIndex = 0;
            CboRequisito.SelectedIndex = 0;
        }
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
        private void BtnGuardarRequisito_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToInt32(CboRequisito.SelectedValue);

            if (ListaRequisitos.Contains(numero)) { MessageBox.Show($"Requisito ya guardado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            ListaRequisitos.Add(numero);
            requisitos = string.Join(",", ListaRequisitos);

            MessageBox.Show($"Requisito guardado corretamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var tipoPrestamo = (TipoPrestamo)Enum.Parse(typeof(TipoPrestamo), CboTipoPrestamo.SelectedItem.ToString());

            if (TxtDNICliente.Text != "" && TxtMontoSolicitado.Text != "" && TxtNumeroCuotas.Text != "")
            {
                _Prestamo = new Prestamo
                {
                    NroDocumento = TxtDNICliente.Text,
                    TipoPrestamo = tipoPrestamo,
                    Requisitos = requisitos,
                    MontoSolicitado = Convert.ToDecimal(TxtMontoSolicitado.Text),
                    NroCuotas = Convert.ToInt16(TxtNumeroCuotas.Text)
                };

                PrestamoBL.Instancia.Guardar(_Prestamo);
                MessageBox.Show($"Prestamo guardado correctamente. {tipoPrestamo}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ListarPrestamos();
            }
            else { MessageBox.Show($"Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (IDPrestamo != 0)
            {
                PrestamoBL.Instancia.Eliminar(IDPrestamo);
                MessageBox.Show($"Prestamo eliminado correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ListarPrestamos();
            }
            else { MessageBox.Show($"Debe seleccionar un prestamo a eliminar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var lista = PrestamoBL.Instancia.Buscar(TxtBuscar.Text);
            Buscar(lista);
        }
        #endregion

        #region EVENTOS
        private void TxtDNICliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtDNICliente.Text.Length == 8)
            {
                if (ClienteBL.Instancia.ExisteCliente(TxtDNICliente.Text)) { MessageBox.Show($"El cliente registrado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show($"El cliente no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }
        private void DgvPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActual = DgvPrestamo.Rows[e.RowIndex];

            IDPrestamo = Convert.ToInt16(FilaActual.Cells[0].Value);

            var nroDocumento = FilaActual.Cells[2].Value.ToString();
            var tipoPrestamoTexto = FilaActual.Cells[3].Value.ToString();
            var monto = Convert.ToDecimal(FilaActual.Cells[5].Value);
            var nroCuotas = Convert.ToInt16(FilaActual.Cells[6].Value);
            var estadoTexto = FilaActual.Cells[8].Value.ToString();

            var tipoPrestamo = (TipoPrestamo)Enum.Parse(typeof(TipoPrestamo), tipoPrestamoTexto);

            var estado = (EstadoPrestamo)Enum.Parse(typeof(EstadoPrestamo), estadoTexto);

            _Prestamo = new Prestamo
            {
                PrestamoId = IDPrestamo,
                NroDocumento = nroDocumento,
                TipoPrestamo = tipoPrestamo,
                MontoSolicitado = monto,
                NroCuotas = nroCuotas,
                Estado = estado
            };

            if (Numero != 1)
            {
                if (_Prestamo.Estado == EstadoPrestamo.Aprobado)
                {
                    var Cronograma = new FrmCronograma(_Prestamo);
                    Cronograma.Show();
                    Hide();
                }
                else { MessageBox.Show($"Prestamo no esta aprobado o se encuentra en revision.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void FrmPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Principal = new FrmPrincipal();
            Principal.Show();
            Hide();
        }
        #endregion        
    }
}