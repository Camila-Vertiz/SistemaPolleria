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
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogout
            // 
            this.pictureLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogout.Image = global::CapaPresentacion.Properties.Resources.logout1;
            this.pictureLogout.Location = new System.Drawing.Point(715, 23);
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.Size = new System.Drawing.Size(30, 30);
            this.pictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogout.TabIndex = 0;
            this.pictureLogout.TabStop = false;
            this.pictureLogout.Click += new System.EventHandler(this.pictureLogout_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLogout);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureLogout;
    }
}