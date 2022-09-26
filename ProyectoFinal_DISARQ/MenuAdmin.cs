using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuAdmin : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MenuAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Formulario
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(240, 255, 240);
            public static Color color2 = Color.FromArgb(25, 25, 112);
            public static Color color3 = Color.FromArgb(226, 127, 28);
            public static Color color4 = Color.FromArgb(28, 226, 193);
            public static Color color5 = Color.FromArgb(160, 226, 28);
            public static Color color6 = Color.FromArgb(128, 0, 0);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn =(Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 110, 51);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borde Izq
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono Panel arriba
                iconCurrentChildForm.Image = currentBtn.Image;
                lblTitleChildForm.Text = currentBtn.Text;

            }
        }

        private void DisableButton()
        {
            if(currentBtn!= null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 110, 51);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }


        private void pictureLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            // OpenChildForm(new );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnMantenedorProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnMantenedorMesas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.Image = Image.FromFile("C:\\Users\\ADVANCE\\Source\\Repos\\ProyectoFinal_DISARQ\\ProyectoFinal_DISARQ\\Imagenes\\home-icon-silhouette (1).png");
            lblTitleChildForm.Text = "Bienvenido Administrador";
        }
        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void MenuAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
