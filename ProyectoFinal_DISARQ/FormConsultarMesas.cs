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
            dgvMesas.DataSource = logMesas.Instancia.ListaMesas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
