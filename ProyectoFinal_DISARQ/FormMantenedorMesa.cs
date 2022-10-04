using CapaEntidad;
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
    public partial class FormMantenedorMesa : Form
    {
        public FormMantenedorMesa()
        {
            InitializeComponent();
            listaMesas();
        }
        public void listaMesas()
        {
            dgvMesa.DataSource = logMesas.Instancia.ListaMesas();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entMesas m = new entMesas();
                m.numero_mesa = txtNumeroMesa.Text.Trim();
                m.capacidad_mesa = int.Parse(txtCapacidad.Text.Trim());
                m.ubicacion_mesa = txtUbicacion.Text.Trim();
                logMesas.Instancia.InsertaMesas(m);
                MessageBox.Show("Registro agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaMesas();
        }
    }
}
