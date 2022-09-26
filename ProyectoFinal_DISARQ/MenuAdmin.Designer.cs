namespace CapaPresentacion
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureLogout = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMantenedorProductos = new System.Windows.Forms.Button();
            this.btnMantenedorMesas = new System.Windows.Forms.Button();
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.btnConsultarMesas = new System.Windows.Forms.Button();
            this.btnConsultarMozos = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogout
            // 
            this.pictureLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogout.Image = global::CapaPresentacion.Properties.Resources.logout1;
            this.pictureLogout.Location = new System.Drawing.Point(993, 541);
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.Size = new System.Drawing.Size(30, 30);
            this.pictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogout.TabIndex = 0;
            this.pictureLogout.TabStop = false;
            this.pictureLogout.Click += new System.EventHandler(this.pictureLogout_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.btnConsultarProductos);
            this.panelMenu.Controls.Add(this.btnConsultarMozos);
            this.panelMenu.Controls.Add(this.btnConsultarMesas);
            this.panelMenu.Controls.Add(this.btnConsultarPedidos);
            this.panelMenu.Controls.Add(this.btnMantenedorMesas);
            this.panelMenu.Controls.Add(this.btnMantenedorProductos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 583);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 150);
            this.panelLogo.TabIndex = 2;
            // 
            // btnMantenedorProductos
            // 
            this.btnMantenedorProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenedorProductos.FlatAppearance.BorderSize = 0;
            this.btnMantenedorProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenedorProductos.ForeColor = System.Drawing.Color.White;
            this.btnMantenedorProductos.Image = global::CapaPresentacion.Properties.Resources.kitchen_utensils__2_1;
            this.btnMantenedorProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenedorProductos.Location = new System.Drawing.Point(0, 150);
            this.btnMantenedorProductos.Name = "btnMantenedorProductos";
            this.btnMantenedorProductos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnMantenedorProductos.Size = new System.Drawing.Size(250, 60);
            this.btnMantenedorProductos.TabIndex = 2;
            this.btnMantenedorProductos.Text = " Mantenedor Producto";
            this.btnMantenedorProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenedorProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenedorProductos.UseVisualStyleBackColor = true;
            this.btnMantenedorProductos.Click += new System.EventHandler(this.btnMantenedorProductos_Click);
            // 
            // btnMantenedorMesas
            // 
            this.btnMantenedorMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenedorMesas.FlatAppearance.BorderSize = 0;
            this.btnMantenedorMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenedorMesas.ForeColor = System.Drawing.Color.White;
            this.btnMantenedorMesas.Image = global::CapaPresentacion.Properties.Resources.mesa_de_comedor__1_;
            this.btnMantenedorMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenedorMesas.Location = new System.Drawing.Point(0, 210);
            this.btnMantenedorMesas.Name = "btnMantenedorMesas";
            this.btnMantenedorMesas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnMantenedorMesas.Size = new System.Drawing.Size(250, 60);
            this.btnMantenedorMesas.TabIndex = 3;
            this.btnMantenedorMesas.Text = " Mantenedor Mesas";
            this.btnMantenedorMesas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenedorMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenedorMesas.UseVisualStyleBackColor = true;
            this.btnMantenedorMesas.Click += new System.EventHandler(this.btnMantenedorMesas_Click);
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarPedidos.FlatAppearance.BorderSize = 0;
            this.btnConsultarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPedidos.Image = global::CapaPresentacion.Properties.Resources.mesa_de_edicion__1_;
            this.btnConsultarPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPedidos.Location = new System.Drawing.Point(0, 270);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnConsultarPedidos.Size = new System.Drawing.Size(250, 60);
            this.btnConsultarPedidos.TabIndex = 4;
            this.btnConsultarPedidos.Text = " Consultar Pedidos";
            this.btnConsultarPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            this.btnConsultarPedidos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConsultarMesas
            // 
            this.btnConsultarMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarMesas.FlatAppearance.BorderSize = 0;
            this.btnConsultarMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMesas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMesas.Image = global::CapaPresentacion.Properties.Resources.mesa_de_comedor__2___1_;
            this.btnConsultarMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMesas.Location = new System.Drawing.Point(0, 330);
            this.btnConsultarMesas.Name = "btnConsultarMesas";
            this.btnConsultarMesas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnConsultarMesas.Size = new System.Drawing.Size(250, 60);
            this.btnConsultarMesas.TabIndex = 5;
            this.btnConsultarMesas.Text = " Consultar Mesas";
            this.btnConsultarMesas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarMesas.UseVisualStyleBackColor = true;
            this.btnConsultarMesas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsultarMozos
            // 
            this.btnConsultarMozos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarMozos.FlatAppearance.BorderSize = 0;
            this.btnConsultarMozos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMozos.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMozos.Image = global::CapaPresentacion.Properties.Resources.group__1_;
            this.btnConsultarMozos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMozos.Location = new System.Drawing.Point(0, 390);
            this.btnConsultarMozos.Name = "btnConsultarMozos";
            this.btnConsultarMozos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnConsultarMozos.Size = new System.Drawing.Size(250, 60);
            this.btnConsultarMozos.TabIndex = 6;
            this.btnConsultarMozos.Text = " Consultar Mozos";
            this.btnConsultarMozos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMozos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarMozos.UseVisualStyleBackColor = true;
            this.btnConsultarMozos.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarProductos.FlatAppearance.BorderSize = 0;
            this.btnConsultarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProductos.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProductos.Image = global::CapaPresentacion.Properties.Resources.cocinero__1_;
            this.btnConsultarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProductos.Location = new System.Drawing.Point(0, 450);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnConsultarProductos.Size = new System.Drawing.Size(250, 60);
            this.btnConsultarProductos.TabIndex = 7;
            this.btnConsultarProductos.Text = " Consultar Productos";
            this.btnConsultarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.button6_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pictureLogout);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureLogout;
        private Panel panelMenu;
        private Button btnConsultarProductos;
        private Button btnConsultarMozos;
        private Button btnConsultarMesas;
        private Button btnConsultarPedidos;
        private Button btnMantenedorMesas;
        private Button btnMantenedorProductos;
        private Panel panelLogo;
    }
}