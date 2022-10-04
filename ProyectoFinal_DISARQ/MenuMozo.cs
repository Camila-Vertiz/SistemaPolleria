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
        public MenuMozo()
        {
            InitializeComponent();
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
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
    }
}
