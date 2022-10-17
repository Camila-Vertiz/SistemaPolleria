using CapaEntidad;
using CapaEntidad.Cache;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuMozo : Form
    {
        API_Peru api_peru = new API_Peru();
        public MenuMozo()
        {
            InitializeComponent();
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
            formatoDGVProducto();
            LoadUserData();
            txtTotal.Text = "0";
        }
        private void LoadUserData()
        {
            lblNombreUser.Text = UserLoginCache.nombre_usuario;
        }
        private void formatoDGVProducto()
        {
            dgvProducto.Columns[0].Width = 50;
            dgvProducto.Columns[0].HeaderText = "Cod.";
            dgvProducto.Columns[1].Width = 300;
            dgvProducto.Columns[1].HeaderText = "Producto";
            dgvProducto.Columns[2].Width = 70;
            dgvProducto.Columns[2].HeaderText = "P. Unitario";
            dgvProducto.Columns[3].Width = 70;
            dgvProducto.Columns[3].HeaderText = "Stock";
            dgvProducto.Columns[4].Width = 400;
            dgvProducto.Columns[4].HeaderText = "Descripcion";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProductos.Text == "Buscar...")
            {
                txtBuscarProductos.Text = "";
                txtBuscarProductos.ForeColor = Color.Black;
            }
        }

        private void txtBuscarProductos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProductos.Text == "")
            {
                txtBuscarProductos.Text = "Buscar...";
                txtBuscarProductos.ForeColor = Color.DimGray;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "";
        }

        private void MenuMozo_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "1";
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "2";
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "3";
        }

        private void btnBrasa_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Brasa");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnParrilla_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Parrilla");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnAlaCarta_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Carta");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnBroaster_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Broaster");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Burger");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnComplementos_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Complementos");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnEnsaladas_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Ensaladas");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnGaseosas_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Gaseosas");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnCervezas_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Cervezas");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Postres");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaNombreProducto(txtBuscarProductos.Text.Trim());
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //txtNPersonas.Focus();
            //if (!txtNPersonas.Text.Equals(""))
            //{
            //    int p_cant = Convert.ToInt32(txtNPersonas.Text);
            //    entMesas m = logMesas.Instancia.BuscarCapacidadMesas(p_cant);
            //    if(m != null)
            //    {
            //        if(m.capacidad_mesa)
            //    }
            //}
            //else
            //    MessageBox.Show("Ingrese un valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void txtNPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        string p_cod = "";
        float p_unit = 0;
        int p_stock = 0;
        string p_nom = "";

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex]; //
            p_cod = filaActual.Cells[0].Value.ToString();
            p_nom = filaActual.Cells[1].Value.ToString();
            txtProductoSelec.Text = p_nom;
            p_unit = (float)Convert.ToDouble(filaActual.Cells[2].Value);
            p_stock = Convert.ToInt32(filaActual.Cells[3].Value);
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }
        string tipoComprobante = "";
        private void consultarCliente()
        {
            try
            {
                if (txtDNIcliente.Text.Length == 11)
                {
                    dynamic respuesta = api_peru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + txtDNIcliente.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNvcG9ydGVyb2t5c0BvdXRsb29rLmNvbSJ9.z0szsBQYp7SuyS-2AigCx4cGpqW3pscGWq74eeH2JWc");

                    txtNombreCliente.Text = respuesta.razonSocial;
                    tipoComprobante = "R";
                }
                if (txtDNIcliente.Text.Length == 8)
                {
                    dynamic respuesta = api_peru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDNIcliente.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNvcG9ydGVyb2t5c0BvdXRsb29rLmNvbSJ9.z0szsBQYp7SuyS-2AigCx4cGpqW3pscGWq74eeH2JWc");
                    txtNombreCliente.Text = respuesta.nombres + " " + respuesta.apellidoPaterno + " " + respuesta.apellidoMaterno;
                    tipoComprobante = "D";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtMostrarMesa.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una mesa.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvMesa.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DataTable detalle_pedido = new DataTable();
            detalle_pedido.Columns.Add("Codigo", typeof(int));
            detalle_pedido.Columns.Add("Cantidad", typeof(int));
            detalle_pedido.Columns.Add("P_Unitario", typeof(float));
            detalle_pedido.Columns.Add("SubTotal", typeof(float));

            foreach (DataGridViewRow row in dgvMesa.Rows)
            {
                detalle_pedido.Rows.Add(
                        new object[]
                        {
                            Convert.ToInt32(row.Cells["Codigo"].Value.ToString()),
                            Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()),
                            Convert.ToDecimal(row.Cells["P_Unitario"].Value.ToString()),
                            Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString())
                        }
                    );
            }
            int idCorrelativo = new logPedido().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);
            int mesaSelec = Convert.ToInt32(txtMostrarMesa.Text.ToString());
            string rucDNI = txtDNIcliente.Text.ToString();
            string nCliente = txtNombreCliente.Text.ToString();

            entPedido oPedido = new entPedido()
            {
                oMesa = new entMesas() { id_mesa = mesaSelec },
                oUsuario = new entUsuario() { id_usuario = UserLoginCache.id_usuario },
                numeroDocumento_cliente = rucDNI,
                nombre_cliente = nCliente,
                tipoComprobante_pedido = tipoComprobante,
                numeroComprobante_pedido = numeroDocumento,
                montoPago_pedido = (float)Convert.ToDecimal(txtPago.Text.ToString()),
                montoCambio_pedido = (float)Convert.ToDecimal(txtVuelto.Text.ToString()),
                montoTotal_pedido = (float)Convert.ToDecimal(txtTotal.Text.ToString()),
                estado_pedido = "P"
            };
            string mensaje = string.Empty;
            bool respuesta = new logPedido().InsertarPedido(oPedido, detalle_pedido, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de Pedido generado: \n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);
               
                txtTotal.Text = "0";
                txtPago.ResetText();
                txtVuelto.ResetText();
                txtMostrarMesa.ResetText();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        int p_cant = 0;
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            p_cant = Convert.ToInt32(cantProducto.Text);
            bool p_existe = false;
            if (txtProductoSelec.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(cantProducto.Text) < p_cant)
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow f in dgvMesa.Rows)
            {
                if (f.Cells["Codigo"].Value.ToString() == p_cod)
                {
                    p_existe = true;
                    break;
                }
            }

            if (!p_existe)
            {
                bool respuesta = new logPedido().RestarStock(Convert.ToInt32(p_cod), p_cant);

                if (respuesta)
                {
                    dgvMesa.Rows.Add(new object[]
                    { p_cod, p_nom,p_cant.ToString(), p_unit.ToString("0.00"),((p_cant*p_unit).ToString("0.00")) });
                }
                calcularTotal();
                limpiarProducto();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvMesa.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMesa.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotal.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            p_unit = 0;
            cantProducto.Text = "1";
            txtProductoSelec.ResetText();

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPago.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }
            }
        }

        private void calcularVuelto()
        {
            if (txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float pagacon;
            float total = (float)Convert.ToDecimal(txtTotal.Text);

            if (txtPago.Text.Trim() == "")
            {
                txtPago.Text = "0";
            }

            if (float.TryParse(txtPago.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtVuelto.Text = "0.00";
                }
                else
                {
                    float cambio = pagacon - total;
                    txtVuelto.Text = cambio.ToString("0.0");
                }
            }

        }

        private void txtPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularVuelto();
            }
        }

        private void dgvMesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMesa.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new logPedido().SumarStock(Convert.ToInt32(p_cod), p_cant);
                    dgvMesa.Rows.RemoveAt(index);
                    calcularTotal();
                }
            }
        }

        private void dgvMesa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.trash.Width;
                var h = Properties.Resources.trash.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
