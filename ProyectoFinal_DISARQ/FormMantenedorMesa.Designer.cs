namespace CapaPresentacion
{
    partial class FormMantenedorMesa
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
            this.dgvMesa = new System.Windows.Forms.DataGridView();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditarMesa = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMesa
            // 
            this.dgvMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesa.Location = new System.Drawing.Point(21, 84);
            this.dgvMesa.Name = "dgvMesa";
            this.dgvMesa.RowHeadersWidth = 51;
            this.dgvMesa.RowTemplate.Height = 29;
            this.dgvMesa.Size = new System.Drawing.Size(751, 219);
            this.dgvMesa.TabIndex = 27;
            this.dgvMesa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesa_CellClick);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(150, 166);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(125, 27);
            this.txtUbicacion.TabIndex = 24;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(150, 121);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(125, 27);
            this.txtCapacidad.TabIndex = 23;
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(150, 77);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.Size = new System.Drawing.Size(125, 27);
            this.txtNumeroMesa.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ubicación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Capacidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Número de mesa:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(400, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 29);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(400, 52);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 29);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(561, 35);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(125, 27);
            this.txtBuscarID.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id de Mesa";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(400, 96);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 29);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdMesa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroMesa);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(21, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 205);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Mesa";
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.Location = new System.Drawing.Point(150, 34);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(125, 27);
            this.txtIdMesa.TabIndex = 31;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(653, 379);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 29);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditarMesa
            // 
            this.btnEditarMesa.Location = new System.Drawing.Point(653, 436);
            this.btnEditarMesa.Name = "btnEditarMesa";
            this.btnEditarMesa.Size = new System.Drawing.Size(104, 29);
            this.btnEditarMesa.TabIndex = 33;
            this.btnEditarMesa.Text = "Editar";
            this.btnEditarMesa.UseVisualStyleBackColor = true;
            this.btnEditarMesa.Click += new System.EventHandler(this.btnEditarMesa_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Image = global::CapaPresentacion.Properties.Resources.search25;
            this.btnBuscarID.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarID.Location = new System.Drawing.Point(713, 30);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(44, 37);
            this.btnBuscarID.TabIndex = 34;
            this.btnBuscarID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Buscar por ID:";
            // 
            // FormMantenedorMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(786, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnEditarMesa);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.dgvMesa);
            this.Name = "FormMantenedorMesa";
            this.Text = "FormMantenedorMesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMesa;
        private TextBox txtUbicacion;
        private TextBox txtCapacidad;
        private TextBox txtNumeroMesa;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEliminar;
        private Button btnRegistrar;
        private TextBox txtBuscarID;
        private Label label4;
        private Button btnModificar;
        private GroupBox groupBox1;
        private TextBox txtIdMesa;
        private Button btnNuevo;
        private Button btnEditarMesa;
        private Button btnBuscarID;
        private Label label5;
    }
}