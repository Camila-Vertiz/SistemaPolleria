using CapaDatos;
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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo_usuario = txtCorreo.Text;
            if(correo_usuario != "Correo Electronico")
            {
                string result = logUsuario.Instancia.recoverPassword(txtCorreo.Text);
                MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
