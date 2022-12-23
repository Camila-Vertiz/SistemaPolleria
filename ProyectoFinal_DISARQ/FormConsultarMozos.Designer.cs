namespace CapaPresentacion
{
    partial class FormConsultarMozos
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
            this.txtCodigoMozo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMozos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoMozo
            // 
            this.txtCodigoMozo.Location = new System.Drawing.Point(411, 122);
            this.txtCodigoMozo.Name = "txtCodigoMozo";
            this.txtCodigoMozo.Size = new System.Drawing.Size(125, 27);
            this.txtCodigoMozo.TabIndex = 15;
            this.txtCodigoMozo.TextChanged += new System.EventHandler(this.txtCodigoMozo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(86, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Información de búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // dgvMozos
            // 
            this.dgvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozos.Location = new System.Drawing.Point(99, 188);
            this.dgvMozos.Name = "dgvMozos";
            this.dgvMozos.RowHeadersWidth = 51;
            this.dgvMozos.RowTemplate.Height = 29;
            this.dgvMozos.Size = new System.Drawing.Size(833, 414);
            this.dgvMozos.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.Image = global::CapaPresentacion.Properties.Resources.list24;
            this.btnListar.Location = new System.Drawing.Point(659, 117);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(44, 37);
            this.btnListar.TabIndex = 32;
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.search25;
            this.btnBuscar.Location = new System.Drawing.Point(583, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 37);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // FormConsultarMozos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1038, 670);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoMozo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMozos);
            this.Name = "FormConsultarMozos";
            this.Text = "FormConsultarMozos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCodigoMozo;
        private Label label4;
        private Label label1;
        private DataGridView dgvMozos;
        private Button btnListar;
        private Button btnBuscar;
    }
}