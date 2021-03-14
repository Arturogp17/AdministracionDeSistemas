namespace ProyectoABD.Views.Sucursal
{
    partial class frmSucursal
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
            this.btSave = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(228, 144);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 41);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Añadir";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 47);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 17);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre: ";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Location = new System.Drawing.Point(29, 82);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(71, 17);
            this.lbdireccion.TabIndex = 2;
            this.lbdireccion.Text = "Dirección:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(141, 47);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(168, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(141, 82);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(168, 22);
            this.tbDireccion.TabIndex = 4;
            // 
            // frmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 210);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btSave);
            this.Name = "frmSucursal";
            this.Text = "frmSucursal";
            this.Load += new System.EventHandler(this.frmSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
    }
}