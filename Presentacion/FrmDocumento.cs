using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentacion
{
    public partial class FrmDocumento : Form
    {
        private Documento _Documento;
        private int IDPrestamo;
        private string PreRequisito;
        private int IDDocumento = 0;

        public FrmDocumento(int iDPrestamo, string preRequisito)
        {
            InitializeComponent();
            IDPrestamo = iDPrestamo;
            PreRequisito = preRequisito;
            CargarDatos();
            ListarDocumentos();
        }

        #region FUNCIONES
        public void CargarDatos()
        {
            if (IDPrestamo == 0 && PreRequisito == "") { TxtPrestamoId.Text = ""; }
            else { TxtPrestamoId.Text = IDPrestamo.ToString(); CboRequisito.DataSource = PreRequisito.Split(',').Select(x => x.Trim()).Where(x => x != "").ToList(); }
        }
        public void ListarDocumentos()
        {
            DgvDocumentos.Rows.Clear();

            var lista = DocumentoBL.Instancia.Listar(IDPrestamo);

            foreach (var item in lista)
            {
                DgvDocumentos.Rows.Add
                    (
                        item.DocumentoId,
                        item.PrestamoId,
                        item.TipoRequisito,
                        item.Nombre,
                        item.Ruta,
                        item.FechaRegistro.ToString("dd/MM/yyyy"),
                        item.FechaRespuesta?.ToString("dd/MM/yyyy"),
                        item.Estado
                    );
            }
        }
        #endregion

        #region METODOS
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtPrestamoId.Text == "") { return; }

            var prestamoId = Convert.ToInt16(TxtPrestamoId.Text);
            var requisito = (RequisitoPrestamo)Enum.Parse(typeof(RequisitoPrestamo), CboRequisito.SelectedItem.ToString());

            if (DocumentoBL.Instancia.ValidarRequisito(prestamoId, requisito))
            {
                MessageBox.Show($"Este requisito ya esta registrado para este prestamo.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (TxtPrestamoId.Text != "")
            {
                var _OpenFileDialog = new OpenFileDialog
                {
                    Filter = "Archivos PDF (*.pdf)|*.pdf",
                    Title = "Seleccionar un archivo PDF"
                };

                if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Origen = _OpenFileDialog.FileName;
                    var NombreArchivo = Path.GetFileName(Origen);

                    try
                    {
                        var RutaBase = Application.StartupPath;
                        var CarpetaBin = Directory.GetParent(RutaBase);
                        var CarpetaProyecto = CarpetaBin.Parent;

                        var CarpetaDestino = Path.Combine(CarpetaProyecto.FullName, "Documentos");

                        if (!Directory.Exists(CarpetaDestino)) { Directory.CreateDirectory(CarpetaDestino); }

                        var Destino = Path.Combine(CarpetaDestino, NombreArchivo);

                        File.Copy(Origen, Destino, true);

                        _Documento = new Documento
                        {
                            PrestamoId = prestamoId,
                            TipoRequisito = requisito,
                            Nombre = NombreArchivo,
                            Ruta = $"Documentos\\{NombreArchivo}"
                        };

                        DocumentoBL.Instancia.Guardar(_Documento);
                        ListarDocumentos();

                        MessageBox.Show($"PDF guardado correctamento en:\n{Destino}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else { MessageBox.Show("Debe seleccionar un requisito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void BtnPrestamo_Click(object sender, EventArgs e)
        {
            var Prestamos = new FrmPrestamos();
            Prestamos.Show();
            Hide();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (IDDocumento != 0)
            {
                DocumentoBL.Instancia.Eliminar(IDDocumento);
                MessageBox.Show($"Documento eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarDocumentos();
                IDDocumento = 0;
            }
            else { MessageBox.Show($"Debe seleccionar un documento.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void BtnRechazar_Click(object sender, EventArgs e)
        {
            if (IDDocumento != 0)
            {
                DocumentoBL.Instancia.Atender(IDDocumento, 0);
                MessageBox.Show($"Documento rechazado correctamente.", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarDocumentos();
                IDDocumento = 0;
            }
            else { MessageBox.Show($"Debe seleccionar un documento.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void BtnAprobar_Click(object sender, EventArgs e)
        {
            if (IDDocumento != 0)
            {
                DocumentoBL.Instancia.Atender(IDDocumento, 2);
                MessageBox.Show($"Documento aprobado correctamente.", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarDocumentos();
                IDDocumento = 0;
            }
            else { MessageBox.Show($"Debe seleccionar un documento.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        #endregion

        #region EVENTOS
        private void DgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvDocumentos.Columns[e.ColumnIndex].Name == "Ruta")
            {
                var rutaRelativa = DgvDocumentos.Rows[e.RowIndex].Cells["Ruta"].Value.ToString();
                var rutaCompleta = Path.Combine(Application.StartupPath, @"..\..\", rutaRelativa);

                if (File.Exists(rutaCompleta)) { System.Diagnostics.Process.Start(rutaCompleta); }
                else { MessageBox.Show("El archivo no existe en la carpeta del proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void DgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActual = DgvDocumentos.Rows[e.RowIndex];

            IDDocumento = Convert.ToInt16(FilaActual.Cells[0].Value);
        }
        private void FrmDocumento_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Principal = new FrmPrincipal();
            Principal.Show();
            Hide();
        }
        #endregion
    }
}
