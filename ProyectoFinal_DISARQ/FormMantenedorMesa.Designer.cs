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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesa
            // 
            this.dgvMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesa.Location = new System.Drawing.Point(81, 270);
            this.dgvMesa.Name = "dgvMesa";
            this.dgvMesa.RowHeadersWidth = 51;
            this.dgvMesa.RowTemplate.Height = 29;
            this.dgvMesa.Size = new System.Drawing.Size(594, 219);
            this.dgvMesa.TabIndex = 27;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(375, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 29);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(236, 208);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(125, 27);
            this.txtUbicacion.TabIndex = 24;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(236, 163);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(125, 27);
            this.txtCapacidad.TabIndex = 23;
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(236, 119);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.Size = new System.Drawing.Size(125, 27);
            this.txtNumeroMesa.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(81, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "DATOS DE LA MESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ubicación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Capacidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Número de mesa:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(514, 199);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 29);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Mesa";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(514, 81);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(161, 29);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar Mesa";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.Location = new System.Drawing.Point(235, 75);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(125, 27);
            this.txtIdMesa.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id de Mesa";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(514, 137);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(161, 29);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Modifica Mesa";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormMantenedorMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtIdMesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMesa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtNumeroMesa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FormMantenedorMesa";
            this.Text = "FormMantenedorMesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMesa;
        private Button btnBuscar;
        private TextBox txtUbicacion;
        private TextBox txtCapacidad;
        private TextBox txtNumeroMesa;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEliminar;
        private Button btnRegistrar;
        private TextBox txtIdMesa;
        private Label label4;
        private Button btnEditar;
    }
}