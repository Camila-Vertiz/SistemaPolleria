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
        }

        private void button13_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "2";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "10";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "11";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "12";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "13";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "14";
        }
               
        private void button17_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "15";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "16";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = ""; 
        }

        private void MenuMozo_Load(object sender, EventArgs e)
        {

        }
    }
}
