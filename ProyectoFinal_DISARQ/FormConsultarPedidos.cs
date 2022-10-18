using CapaEntidad;
using CapaLogica;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormConsultarPedidos : Form
    {
        public FormConsultarPedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            entPedido oPedido = new logPedido().ObtenerPedido(txtNDocu.Text);
            if (oPedido.codigo_pedido != 0)
            {
                txtNDocu2.Text = oPedido.numeroComprobante_pedido;
                txtFecha.Text = oPedido.fechaCreacion_pedido.ToString();
                if (oPedido.tipoComprobante_pedido == "D")
                {
                    txtTipoDocumento.Text = "BOLETA";
                }
                else if (oPedido.tipoComprobante_pedido == "R")
                {
                    txtTipoDocumento.Text = "FACTURA";
                }
                txtUsuario.Text = oPedido.oUsuario.nombre_usuario;
                txtDocCli.Text = oPedido.numeroDocumento_cliente;
                txtNombreCliente.Text = oPedido.nombre_cliente;
                txtNombreMesa.Text = oPedido.oMesa.numero_mesa;
                txtPisoMesa.Text = oPedido.oMesa.ubicacion_mesa;
                dgvMesa.Rows.Clear();
                foreach (entDetallePedido dv in oPedido.oDetallePedido)
                {
                    dgvMesa.Rows.Add(new object[] { dv.codigo_producto.codigo_producto, dv.codigo_producto.nombre_producto, dv.cantidad_detallePedido, dv.precioUnitario_detallePedido, dv.subtotal_detallePedido });
                }
                txtMontoTotal.Text = oPedido.montoTotal_pedido.ToString("0.00");
                txtMontoPago.Text = oPedido.montoPago_pedido.ToString("0.00");
                txtMontoCambio.Text = oPedido.montoCambio_pedido.ToString("0.00");
            }
        }

        private void txtNDocu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Buscar();
            }
        }

        private void btnLimpiarDocumento_Click(object sender, EventArgs e)
        {
            txtNDocu2.ResetText();
            txtFecha.ResetText();
            txtTipoDocumento.ResetText();
            txtUsuario.ResetText();
            txtDocCli.ResetText();
            txtNombreCliente.ResetText();
            txtNombreMesa.ResetText();
            txtPisoMesa.ResetText();
            txtMontoTotal.Text = "0.00";
            txtMontoPago.Text = "0.00";
            lblMontoCambio.Text = "0.00";
            txtNDocu.ResetText();
            dgvMesa.Rows.Clear();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (txtNDocu2.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaPedido.ToString();

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNDocu2.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txtDocCli.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtNombreCliente.Text);

            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvMesa.Rows)
            {
                filas += "<tr class=\"table-warning\">";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["P_Unitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtMontoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", lblMontoCambio.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = String.Format("Pedido_{0}.pdf", txtNDocu2.Text);
            saveFile.Filter = "Pdf Files |*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
