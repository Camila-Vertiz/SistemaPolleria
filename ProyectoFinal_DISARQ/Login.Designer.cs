namespace ProyectoFinal_DISARQ
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelIZq = new System.Windows.Forms.Panel();
            this.pictureRokito = new System.Windows.Forms.PictureBox();
            this.pictureX = new System.Windows.Forms.PictureBox();
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.underUsuario = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIZq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRokito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIZq
            // 
            this.panelIZq.BackColor = System.Drawing.Color.Green;
            this.panelIZq.Controls.Add(this.pictureRokito);
            this.panelIZq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIZq.Location = new System.Drawing.Point(0, 0);
            this.panelIZq.Name = "panelIZq";
            this.panelIZq.Size = new System.Drawing.Size(250, 330);
            this.panelIZq.TabIndex = 0;
            // 
            // pictureRokito
            // 
            this.pictureRokito.Image = global::CapaPresentacion.Properties.Resources.Rokito;
            this.pictureRokito.Location = new System.Drawing.Point(54, 40);
            this.pictureRokito.Name = "pictureRokito";
            this.pictureRokito.Size = new System.Drawing.Size(150, 257);
            this.pictureRokito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRokito.TabIndex = 1;
            this.pictureRokito.TabStop = false;
            // 
            // pictureX
            // 
            this.pictureX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureX.Image = global::CapaPresentacion.Properties.Resources.x;
            this.pictureX.Location = new System.Drawing.Point(755, 8);
            this.pictureX.Name = "pictureX";
            this.pictureX.Size = new System.Drawing.Size(15, 15);
            this.pictureX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureX.TabIndex = 1;
            this.pictureX.TabStop = false;
            this.pictureX.Click += new System.EventHandler(this.pictureX_Click);
            // 
            // pictureMin
            // 
            this.pictureMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMin.Image = global::CapaPresentacion.Properties.Resources._;
            this.pictureMin.Location = new System.Drawing.Point(734, 8);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(15, 15);
            this.pictureMin.TabIndex = 2;
            this.pictureMin.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(471, 40);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(128, 39);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Gold;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(333, 106);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(396, 23);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "USUARIO";
            // 
            // underUsuario
            // 
            this.underUsuario.BackColor = System.Drawing.Color.Black;
            this.underUsuario.Location = new System.Drawing.Point(333, 132);
            this.underUsuario.Name = "underUsuario";
            this.underUsuario.Size = new System.Drawing.Size(396, 1);
            this.underUsuario.TabIndex = 6;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Black;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(333, 257);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(400, 40);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.Gold;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(333, 176);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(396, 23);
            this.txtClave.TabIndex = 9;
            this.txtClave.Text = "CONTRASEÑA";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(250, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 330);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(333, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 1);
            this.panel1.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.CancelButton = this.btnIngresar;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.underUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureMin);
            this.Controls.Add(this.pictureX);
            this.Controls.Add(this.panelIZq);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelIZq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRokito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelIZq;
        private PictureBox pictureRokito;
        private PictureBox pictureX;
        private PictureBox pictureMin;
        private Label labelLogin;
        private TextBox txtUsuario;
        private Panel underUsuario;
        private Button btnIngresar;
        private TextBox txtClave;
        private Splitter splitter1;
        private Panel panel1;
    }
}