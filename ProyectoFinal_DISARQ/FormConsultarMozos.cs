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
    public partial class FormConsultarMozos : Form
    {
        public FormConsultarMozos()
        {
            InitializeComponent();
            DataSet ds = logUsuario.Instancia.ListarMozos("M");
            dgvMozos.DataSource = ds;
            dgvMozos.DataMember = "Usuario";
            formatoDGVMozos();
        }
        private void formatoDGVMozos()
        {
            dgvMozos.Columns[0].Width = 50;
            dgvMozos.Columns[0].HeaderText = "Cod.";
            dgvMozos.Columns[1].Width = 200;
            dgvMozos.Columns[1].HeaderText = "Nombre";
            dgvMozos.Columns[2].Width = 200;
            dgvMozos.Columns[2].HeaderText = "Correo";
            dgvMozos.Columns[3].Width = 165;
            dgvMozos.Columns[3].HeaderText = "User";
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DataSet ds = logUsuario.Instancia.BuscarMozo(txtCodigoMozo.Text.Trim(),"M");
            dgvMozos.DataSource = ds;
            dgvMozos.DataMember = "Usuario";
        }

        private void txtCodigoMozo_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = logUsuario.Instancia.BuscarMozo(txtCodigoMozo.Text.Trim(), "M");
            dgvMozos.DataSource = ds;
            dgvMozos.DataMember = "Usuario";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataSet ds = logUsuario.Instancia.ListarMozos("M");
            dgvMozos.DataSource = ds;
            dgvMozos.DataMember = "Usuario";
        }
    }
}
