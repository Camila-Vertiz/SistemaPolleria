namespace CapaPresentacion
{
    partial class FormMantenedorProducto
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditarMesa = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboTipoB = new System.Windows.Forms.ComboBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(650, 36);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 29);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(650, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 29);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(650, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(129, 34);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(125, 27);
            this.txtCodigoProducto.TabIndex = 8;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(378, 37);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(151, 27);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(129, 87);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(125, 27);
            this.txtPrecioUnitario.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(378, 140);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 27);
            this.txtDescripcion.TabIndex = 11;
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(21, 85);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 29;
            this.dgvProducto.Size = new System.Drawing.Size(891, 219);
            this.dgvProducto.TabIndex = 13;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(280, 93);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 20);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Brasa",
            "Cervezas",
            "Complementos",
            "Ensaladas",
            "Gaseosas",
            "Parrilla",
            "Carta",
            "Postres",
            "Broaster",
            "Burger"});
            this.cboCategoria.Location = new System.Drawing.Point(378, 90);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(151, 28);
            this.cboCategoria.TabIndex = 15;
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.label6);
            this.groupBoxProducto.Controls.Add(this.txtStock);
            this.groupBoxProducto.Controls.Add(this.txtCodigoProducto);
            this.groupBoxProducto.Controls.Add(this.cboCategoria);
            this.groupBoxProducto.Controls.Add(this.label1);
            this.groupBoxProducto.Controls.Add(this.lblCategoria);
            this.groupBoxProducto.Controls.Add(this.label2);
            this.groupBoxProducto.Controls.Add(this.label3);
            this.groupBoxProducto.Controls.Add(this.txtNombreProducto);
            this.groupBoxProducto.Controls.Add(this.btnEliminar);
            this.groupBoxProducto.Controls.Add(this.txtDescripcion);
            this.groupBoxProducto.Controls.Add(this.btnModificar);
            this.groupBoxProducto.Controls.Add(this.btnRegistrar);
            this.groupBoxProducto.Controls.Add(this.txtPrecioUnitario);
            this.groupBoxProducto.Controls.Add(this.label4);
            this.groupBoxProducto.Enabled = false;
            this.groupBoxProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxProducto.Location = new System.Drawing.Point(21, 343);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(781, 199);
            this.groupBoxProducto.TabIndex = 16;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Datos Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(129, 140);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(125, 27);
            this.txtStock.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Buscar Según:";
            // 
            // btnEditarMesa
            // 
            this.btnEditarMesa.Location = new System.Drawing.Point(808, 455);
            this.btnEditarMesa.Name = "btnEditarMesa";
            this.btnEditarMesa.Size = new System.Drawing.Size(104, 29);
            this.btnEditarMesa.TabIndex = 36;
            this.btnEditarMesa.Text = "Editar";
            this.btnEditarMesa.UseVisualStyleBackColor = true;
            this.btnEditarMesa.Click += new System.EventHandler(this.btnEditarMesa_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(808, 398);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 29);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CapaPresentacion.Properties.Resources.list24;
            this.button1.Location = new System.Drawing.Point(647, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 37);
            this.button1.TabIndex = 40;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.search25;
            this.btnBuscar.Location = new System.Drawing.Point(571, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 37);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_2);
            // 
            // cboTipoB
            // 
            this.cboTipoB.FormattingEnabled = true;
            this.cboTipoB.Items.AddRange(new object[] {
            "Nombre",
            "Categoria"});
            this.cboTipoB.Location = new System.Drawing.Point(212, 34);
            this.cboTipoB.Name = "cboTipoB";
            this.cboTipoB.Size = new System.Drawing.Size(151, 28);
            this.cboTipoB.TabIndex = 38;
            this.cboTipoB.Text = "Nombre";
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(397, 35);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(141, 27);
            this.txtBus.TabIndex = 37;
            // 
            // FormMantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboTipoB);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnEditarMesa);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.dgvProducto);
            this.Name = "FormMantenedorProducto";
            this.Text = "FormMantenedorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigoProducto;
        private TextBox txtNombreProducto;
        private TextBox txtPrecioUnitario;
        private TextBox txtDescripcion;
        private DataGridView dgvProducto;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private GroupBox groupBoxProducto;
        private Button btnListar;
        private Button btnBuscar;
        private ComboBox cboTipoB;
        private TextBox txtBus;
        private Label label5;
        private Button btnEditarMesa;
        private Button btnNuevo;
        private Label label6;
        private TextBox txtStock;
        private Button button1;
    }
}