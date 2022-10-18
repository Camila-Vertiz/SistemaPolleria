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
    public partial class FormConsultarProductos : Form
    {
        public FormConsultarProductos()
        {
            InitializeComponent();
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
            formatoDGVProducto();
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
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if(cboTipoB.Text=="Codigo" && (!txtCodigoProducto.Text.Trim().Equals("")))
            {
                DataSet ds = logProducto.Instancia.ConsultaProductoId(Convert.ToInt32(txtCodigoProducto.Text.Trim()));
                dgvProducto.DataSource = ds;
                dgvProducto.DataMember = "Producto";
            }
            else if (cboTipoB.Text == "Nombre" && (!txtCodigoProducto.Text.Trim().Equals("")))
            {
                DataSet ds = logProducto.Instancia.BuscaNombreProducto(txtCodigoProducto.Text.Trim());
                dgvProducto.DataSource = ds;
                dgvProducto.DataMember = "Producto";
            }
            else if (cboTipoB.Text == "Categoria" && (!txtCodigoProducto.Text.Trim().Equals("")))
            {
                DataSet ds = logProducto.Instancia.BuscaProducto(txtCodigoProducto.Text.Trim());
                dgvProducto.DataSource = ds;
                dgvProducto.DataMember = "Producto";
            }
            formatoDGVProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
            formatoDGVProducto();
        }
    }
}
