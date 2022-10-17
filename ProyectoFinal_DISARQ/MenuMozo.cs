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
            formatoDGV();
            LoadUserData();
        }
        private void LoadUserData()
        {
            lblNombreUser.Text = UserLoginCache.nombre_usuario;
        }
        private void formatoDGV()
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
            //    int cant = Convert.ToInt32(txtNPersonas.Text);
            //    entMesas m = logMesas.Instancia.BuscarCapacidadMesas(cant);
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
        string cod_pedido = "";
        float p_unit = 0;

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex]; //
            cod_pedido= filaActual.Cells[0].Value.ToString();
            txtProductoSelec.Text = filaActual.Cells[1].Value.ToString();
            p_unit = (float) Convert.ToDouble(filaActual.Cells[2].Value);
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }

        private void consultarCliente()
        {
            try
            {
                if (txtDNIcliente.Text.Length == 11)
                {
                    dynamic respuesta = api_peru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + txtDNIcliente.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNvcG9ydGVyb2t5c0BvdXRsb29rLmNvbSJ9.z0szsBQYp7SuyS-2AigCx4cGpqW3pscGWq74eeH2JWc");

                    txtNombreCliente.Text = respuesta.razonSocial;
                }
                if (txtDNIcliente.Text.Length == 8)
                {
                    dynamic respuesta = api_peru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDNIcliente.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNvcG9ydGVyb2t5c0BvdXRsb29rLmNvbSJ9.z0szsBQYp7SuyS-2AigCx4cGpqW3pscGWq74eeH2JWc");
                    txtNombreCliente.Text = respuesta.nombres + " " + respuesta.apellidoPaterno + " " + respuesta.apellidoMaterno;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMostrarMesa.Text) == 0)
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
            detalle_pedido.Columns.Add("codigo_producto", typeof(int));
            detalle_pedido.Columns.Add("cantidad_detallePedido", typeof(int));
            detalle_pedido.Columns.Add("precioUnitario_detallePedido", typeof(float));
            detalle_pedido.Columns.Add("subtotal_detallePedido", typeof(float));

            foreach (DataGridViewRow row in dgvMesa.Rows)
            {
                detalle_pedido.Rows.Add(
                        new object[]
                        {
                            Convert.ToInt32(row.Cells["codigo_producto"].Value.ToString()),
                            Convert.ToInt32(row.Cells["cantidad_detallePedido"].Value.ToString()),
                            Convert.ToDecimal(row.Cells["precioUnitario_detallePedido"].Value.ToString()),
                            Convert.ToDecimal(row.Cells["subtotal_detallePedido"].Value.ToString())
                        }
                    );
            }

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(cantProducto);
            bool p_existe = false;
            if (int.Parse(txtProductoSelec.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //string []fila = {cod_pedido, cant.ToString(), p_unit.ToString()}
        }
    }
}
