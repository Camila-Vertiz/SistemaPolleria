using System.Data;
using System.Runtime.InteropServices;
using CapaEntidad;
using CapaLogica;
using CapaPresentacion;

namespace ProyectoFinal_DISARQ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaprure();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void pictureX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;

            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaprure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelIZq_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaprure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string user_usuario = txtUsuario.Text;
            string contrasena_usuario = txtClave.Text;
            bool encontrado = false;
            if (user_usuario != "USUARIO")
            {
                if (contrasena_usuario != "CONTRASEÑA")
                {
                    DataTable us = logUsuario.Instancia.BuscarUsuario(user_usuario, contrasena_usuario);
                    for (int i = 0; i < us.Rows.Count; i++)
                    {
                        if (us.Rows[i][2].ToString() == user_usuario && us.Rows[i][3].ToString() == contrasena_usuario)
                        {
                            if (us.Rows[i][4].ToString() == "A")
                            {
                                MenuAdmin menuAdmin = new MenuAdmin();
                                menuAdmin.Show();
                                this.Hide();
                            }
                            else if (us.Rows[i][4].ToString() == "M")
                            {
                                MenuMozo menuMozo = new MenuMozo();
                                menuMozo.Show();
                                this.Hide();
                            }
                            encontrado = true;
                        }
                        else
                            continue;
                    }
                    if(!encontrado)
                    {
                        MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtClave.ResetText();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}