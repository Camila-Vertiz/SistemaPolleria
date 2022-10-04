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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdMesa.Focus();
            int idMesas = Convert.ToInt32(txtIdMesa.Text);
            entMesas Cal = logMesas.Instancia.BuscaMesas(idMesas);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                
                entMesas m = new entMesas();
                m.id_mesa = int.Parse(txtIdMesa.Text.Trim());
                m.numero_mesa = txtNumeroMesa.Text.Trim();
                m.capacidad_mesa = int.Parse(txtCapacidad.Text.Trim());
                m.ubicacion_mesa = txtUbicacion.Text.Trim();
                logMesas.Instancia.EditaMesas(m);
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
                    entMesas m = new entMesas();

                    m.id_mesa = int.Parse(txtIdMesa.Text.Trim());
                    logMesas.Instancia.EliminaMesas(m);
                     MessageBox.Show("Registro eliminado con exito!" );
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
            listaMesas();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
    
}
