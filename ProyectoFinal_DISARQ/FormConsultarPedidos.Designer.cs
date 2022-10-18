namespace CapaPresentacion
{
    partial class FormConsultarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblDocumentoCli = new System.Windows.Forms.Label();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.txtNDocu2 = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNDocu = new System.Windows.Forms.Label();
            this.txtNDocu = new System.Windows.Forms.TextBox();
            this.btnLimpiarDocumento = new System.Windows.Forms.Button();
            this.dgvMesa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtMontoCambio = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.groupBoxMesa = new System.Windows.Forms.GroupBox();
            this.txtPisoMesa = new System.Windows.Forms.TextBox();
            this.txtNombreMesa = new System.Windows.Forms.TextBox();
            this.lblNMesa = new System.Windows.Forms.Label();
            this.lblPisoMesa = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).BeginInit();
            this.groupBoxMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(288, 59);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.ReadOnly = true;
            this.txtTipoDocumento.Size = new System.Drawing.Size(193, 27);
            this.txtTipoDocumento.TabIndex = 17;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(514, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(173, 27);
            this.txtUsuario.TabIndex = 16;
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(20, 70);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.ReadOnly = true;
            this.txtCodigoPedido.Size = new System.Drawing.Size(211, 27);
            this.txtCodigoPedido.TabIndex = 15;
            this.txtCodigoPedido.TextChanged += new System.EventHandler(this.txtCodigoPedido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Detalle Pedido";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(288, 34);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(124, 20);
            this.lblTipoDocumento.TabIndex = 13;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(16, 34);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(50, 20);
            this.lblFechaPedido.TabIndex = 12;
            this.lblFechaPedido.Text = "Fecha:";
            // 
            // lblDocumentoCli
            // 
            this.lblDocumentoCli.AutoSize = true;
            this.lblDocumentoCli.Location = new System.Drawing.Point(20, 39);
            this.lblDocumentoCli.Name = "lblDocumentoCli";
            this.lblDocumentoCli.Size = new System.Drawing.Size(140, 20);
            this.lblDocumentoCli.TabIndex = 11;
            this.lblDocumentoCli.Text = "Documento Cliente:";
            this.lblDocumentoCli.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Image = global::CapaPresentacion.Properties.Resources.search25;
            this.btnBuscarDocumento.Location = new System.Drawing.Point(633, 26);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(52, 33);
            this.btnBuscarDocumento.TabIndex = 9;
            this.btnBuscarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnBuscarDocumento_Click);
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(263, 39);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(117, 20);
            this.lblNomCli.TabIndex = 19;
            this.lblNomCli.Text = "Nombre Cliente:";
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.Controls.Add(this.txtFecha);
            this.groupBoxInfoPedido.Controls.Add(this.lblUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.txtUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.lblFechaPedido);
            this.groupBoxInfoPedido.Controls.Add(this.lblTipoDocumento);
            this.groupBoxInfoPedido.Controls.Add(this.txtTipoDocumento);
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(34, 88);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(803, 104);
            this.groupBoxInfoPedido.TabIndex = 20;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información  Pedido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(514, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "Usuario:";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.txtNDocu2);
            this.groupBoxCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxCliente.Controls.Add(this.txtCodigoPedido);
            this.groupBoxCliente.Controls.Add(this.lblDocumentoCli);
            this.groupBoxCliente.Controls.Add(this.lblNomCli);
            this.groupBoxCliente.Location = new System.Drawing.Point(34, 208);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(812, 109);
            this.groupBoxCliente.TabIndex = 21;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Información Cliente";
            // 
            // txtNDocu2
            // 
            this.txtNDocu2.Location = new System.Drawing.Point(599, 62);
            this.txtNDocu2.Name = "txtNDocu2";
            this.txtNDocu2.Size = new System.Drawing.Size(88, 27);
            this.txtNDocu2.TabIndex = 23;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(263, 70);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(211, 27);
            this.txtNombreCliente.TabIndex = 20;
            // 
            // lblNDocu
            // 
            this.lblNDocu.AutoSize = true;
            this.lblNDocu.Location = new System.Drawing.Point(270, 29);
            this.lblNDocu.Name = "lblNDocu";
            this.lblNDocu.Size = new System.Drawing.Size(148, 20);
            this.lblNDocu.TabIndex = 20;
            this.lblNDocu.Text = "Numero Documento:";
            // 
            // txtNDocu
            // 
            this.txtNDocu.Location = new System.Drawing.Point(458, 29);
            this.txtNDocu.Name = "txtNDocu";
            this.txtNDocu.Size = new System.Drawing.Size(143, 27);
            this.txtNDocu.TabIndex = 20;
            // 
            // btnLimpiarDocumento
            // 
            this.btnLimpiarDocumento.Image = global::CapaPresentacion.Properties.Resources.eraser25;
            this.btnLimpiarDocumento.Location = new System.Drawing.Point(706, 25);
            this.btnLimpiarDocumento.Name = "btnLimpiarDocumento";
            this.btnLimpiarDocumento.Size = new System.Drawing.Size(52, 34);
            this.btnLimpiarDocumento.TabIndex = 22;
            this.btnLimpiarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLimpiarDocumento.UseVisualStyleBackColor = true;
            // 
            // dgvMesa
            // 
            this.dgvMesa.AllowUserToAddRows = false;
            this.dgvMesa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMesa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.P_Unitario,
            this.SubTotal,
            this.btnBorrar});
            this.dgvMesa.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMesa.Location = new System.Drawing.Point(34, 468);
            this.dgvMesa.Name = "dgvMesa";
            this.dgvMesa.ReadOnly = true;
            this.dgvMesa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMesa.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMesa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesa.RowTemplate.Height = 29;
            this.dgvMesa.Size = new System.Drawing.Size(615, 216);
            this.dgvMesa.TabIndex = 25;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // P_Unitario
            // 
            this.P_Unitario.HeaderText = "P_Unitario";
            this.P_Unitario.MinimumWidth = 6;
            this.P_Unitario.Name = "P_Unitario";
            this.P_Unitario.ReadOnly = true;
            this.P_Unitario.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "";
            this.btnBorrar.MinimumWidth = 6;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.ReadOnly = true;
            this.btnBorrar.Width = 125;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(678, 485);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(93, 20);
            this.lblMontoTotal.TabIndex = 24;
            this.lblMontoTotal.Text = "Monto Total:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(777, 485);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(69, 27);
            this.txtMontoTotal.TabIndex = 24;
            this.txtMontoTotal.Text = "0";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(777, 532);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.ReadOnly = true;
            this.txtMontoPago.Size = new System.Drawing.Size(69, 27);
            this.txtMontoPago.TabIndex = 26;
            this.txtMontoPago.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Monto Pago:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(777, 579);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(69, 27);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "0";
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.AutoSize = true;
            this.txtMontoCambio.Location = new System.Drawing.Point(659, 579);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Size = new System.Drawing.Size(112, 20);
            this.txtMontoCambio.TabIndex = 29;
            this.txtMontoCambio.Text = "Monto Cambio:";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::CapaPresentacion.Properties.Resources.pdf24;
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.Location = new System.Drawing.Point(678, 621);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(155, 33);
            this.btnDescargar.TabIndex = 30;
            this.btnDescargar.Text = "Descargar en PDF";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.UseVisualStyleBackColor = true;
            // 
            // groupBoxMesa
            // 
            this.groupBoxMesa.Controls.Add(this.txtPisoMesa);
            this.groupBoxMesa.Controls.Add(this.txtNombreMesa);
            this.groupBoxMesa.Controls.Add(this.lblNMesa);
            this.groupBoxMesa.Controls.Add(this.lblPisoMesa);
            this.groupBoxMesa.Location = new System.Drawing.Point(34, 333);
            this.groupBoxMesa.Name = "groupBoxMesa";
            this.groupBoxMesa.Size = new System.Drawing.Size(329, 109);
            this.groupBoxMesa.TabIndex = 24;
            this.groupBoxMesa.TabStop = false;
            this.groupBoxMesa.Text = "Información Mesa";
            // 
            // txtPisoMesa
            // 
            this.txtPisoMesa.Location = new System.Drawing.Point(180, 70);
            this.txtPisoMesa.Name = "txtPisoMesa";
            this.txtPisoMesa.ReadOnly = true;
            this.txtPisoMesa.Size = new System.Drawing.Size(123, 27);
            this.txtPisoMesa.TabIndex = 20;
            // 
            // txtNombreMesa
            // 
            this.txtNombreMesa.Location = new System.Drawing.Point(20, 70);
            this.txtNombreMesa.Name = "txtNombreMesa";
            this.txtNombreMesa.ReadOnly = true;
            this.txtNombreMesa.Size = new System.Drawing.Size(140, 27);
            this.txtNombreMesa.TabIndex = 15;
            // 
            // lblNMesa
            // 
            this.lblNMesa.AutoSize = true;
            this.lblNMesa.Location = new System.Drawing.Point(20, 39);
            this.lblNMesa.Name = "lblNMesa";
            this.lblNMesa.Size = new System.Drawing.Size(47, 20);
            this.lblNMesa.TabIndex = 11;
            this.lblNMesa.Text = "Mesa:";
            // 
            // lblPisoMesa
            // 
            this.lblPisoMesa.AutoSize = true;
            this.lblPisoMesa.Location = new System.Drawing.Point(180, 39);
            this.lblPisoMesa.Name = "lblPisoMesa";
            this.lblPisoMesa.Size = new System.Drawing.Size(39, 20);
            this.lblPisoMesa.TabIndex = 19;
            this.lblPisoMesa.Text = "Piso:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(20, 59);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(211, 27);
            this.txtFecha.TabIndex = 20;
            // 
            // FormConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(879, 711);
            this.Controls.Add(this.groupBoxMesa);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtMontoCambio);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.dgvMesa);
            this.Controls.Add(this.btnLimpiarDocumento);
            this.Controls.Add(this.txtNDocu);
            this.Controls.Add(this.lblNDocu);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarDocumento);
            this.Name = "FormConsultarPedidos";
            this.Text = "FormConsultarPedidos";
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).EndInit();
            this.groupBoxMesa.ResumeLayout(false);
            this.groupBoxMesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTipoDocumento;
        private TextBox txtUsuario;
        private TextBox txtCodigoPedido;
        private Label label4;
        private Label lblTipoDocumento;
        private Label lblFechaPedido;
        private Label lblDocumentoCli;
        private Button btnBuscarDocumento;
        private Label lblNomCli;
        private GroupBox groupBoxInfoPedido;
        private GroupBox groupBoxCliente;
        private Label lblNDocu;
        private TextBox txtNDocu;
        private Button btnLimpiarDocumento;
        private Label lblUsuario;
        private TextBox txtNDocu2;
        private TextBox txtNombreCliente;
        private DataGridView dgvMesa;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn P_Unitario;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btnBorrar;
        private Label lblMontoTotal;
        private TextBox txtMontoTotal;
        private TextBox txtMontoPago;
        private Label label1;
        private TextBox textBox2;
        private Label txtMontoCambio;
        private Button btnDescargar;
        private GroupBox groupBoxMesa;
        private TextBox txtPisoMesa;
        private TextBox txtNombreMesa;
        private Label lblNMesa;
        private Label lblPisoMesa;
        private TextBox txtFecha;
    }
}