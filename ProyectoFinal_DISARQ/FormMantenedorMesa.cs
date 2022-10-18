using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            txtIdMesa.Enabled = false;
        }
        public void listaMesas()
        {
            dgvMesa.DataSource = logMesa.Instancia.ListaMesas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entMesa m = new entMesa();
                m.numero_mesa = txtNumeroMesa.Text.Trim();
                m.capacidad_mesa = int.Parse(txtCapacidad.Text.Trim());
                m.ubicacion_mesa = txtUbicacion.Text.Trim();
                logMesa.Instancia.InsertaMesas(m);
                MessageBox.Show("Registro agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaMesas();
            dgvMesa.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscarID.Focus();
            int idMesas = Convert.ToInt32(txtBuscarID.Text);
            entMesa Cal = logMesa.Instancia.BuscaMesas(idMesas);
            if (Cal != null)
            {

                txtBuscarID.Text = Convert.ToString(Cal.id_mesa);
                txtNumeroMesa.Text = Cal.numero_mesa;
                txtCapacidad.Text = Convert.ToString(Cal.capacidad_mesa);
                txtUbicacion.Text = Cal.ubicacion_mesa;
                MessageBox.Show("Registro Encontrado");
            }
            else
                MessageBox.Show("El Calzado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                
                entMesa m = new entMesa();
                m.id_mesa = Convert.ToInt32(txtIdMesa.Text.Trim());
                m.numero_mesa = txtNumeroMesa.Text.Trim();
                m.capacidad_mesa = Convert.ToInt32(txtCapacidad.Text.Trim());
                m.ubicacion_mesa = txtUbicacion.Text.Trim();
                logMesa.Instancia.EditaMesas(m);
                MessageBox.Show("Registro Modificado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
           
            listaMesas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                try
                {
                    entMesa m = new entMesa();

                    m.id_mesa = int.Parse(txtIdMesa.Text.Trim());
                    logMesa.Instancia.EliminaMesas(m);
                     MessageBox.Show("Registro eliminado con exito!" );
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
            listaMesas();
            
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            txtBuscarID.Focus();
            int idMesas = Convert.ToInt32(txtBuscarID.Text);
            entMesa Cal = logMesa.Instancia.BuscaMesas(idMesas);
            if (Cal != null)
            {

                txtIdMesa.Text = Convert.ToString(Cal.id_mesa);
                txtNumeroMesa.Text = Cal.numero_mesa;
                txtCapacidad.Text = Convert.ToString(Cal.capacidad_mesa);
                txtUbicacion.Text = Cal.ubicacion_mesa;
                MessageBox.Show("Registro Encontrado");
            }
            else
                MessageBox.Show("El Calzado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnRegistrar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariabes();
            dgvMesa.Enabled = false;
        }
        private void LimpiarVariabes()
        {
            txtIdMesa.ResetText();
            txtCapacidad.ResetText();
            txtNumeroMesa.ResetText();
            txtUbicacion.ResetText();
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
            dgvMesa.Enabled = true;
            txtIdMesa.Enabled = false;
        }

        private void dgvMesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMesa.Rows[e.RowIndex];
            txtIdMesa.Text = filaActual.Cells[0].Value.ToString();
            txtCapacidad.Text = filaActual.Cells[2].Value.ToString();
            txtNumeroMesa.Text = filaActual.Cells[1].Value.ToString();
            txtUbicacion.Text = filaActual.Cells[3].Value.ToString();
        }
    }
    
}
