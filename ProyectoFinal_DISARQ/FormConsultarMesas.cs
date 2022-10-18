using CapaDatos;
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
    public partial class FormConsultarMesas : Form
    {
        public FormConsultarMesas()
        {
            InitializeComponent();
            listaMesas();
        }
        public void listaMesas()
        {
            dgvMesas.DataSource = logMesa.Instancia.ListaMesas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = logMesa.Instancia.BuscarCapacidadMesas(Convert.ToInt32(txtNumeroMesa.Text.Trim()));
            dgvMesas.DataSource = ds;
            dgvMesas.DataMember = "Mesa";
        }

        private void txtNumeroMesa_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                DataSet ds = logMesa.Instancia.BuscarCapacidadMesas(Convert.ToInt32(txtNumeroMesa.Text.Trim()));
                dgvMesas.DataSource = ds;
                dgvMesas.DataMember = "Mesa"; 
            }
        }

        private void txtNumeroMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtNumeroMesa.Text.Trim().Length == 0 )
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) )
                    {
                        e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaMesas();
        }
    }
}
