namespace ProyectoABD.Views.Telefono
{
    partial class frmTelefono
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
            this.lbSucursal = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.cbSucursales = new System.Windows.Forms.ComboBox();
            this.tbNumTelefono = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(53, 75);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(63, 17);
            this.lbSucursal.TabIndex = 0;
            this.lbSucursal.Text = "Sucursal";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(53, 130);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(64, 17);
            this.lbTelefono.TabIndex = 1;
            this.lbTelefono.Text = "Teléfono";
            // 
            // cbSucursales
            // 
            this.cbSucursales.DisplayMember = "idSucursal";
            this.cbSucursales.FormattingEnabled = true;
            this.cbSucursales.Location = new System.Drawing.Point(172, 66);
            this.cbSucursales.Name = "cbSucursales";
            this.cbSucursales.Size = new System.Drawing.Size(268, 24);
            this.cbSucursales.TabIndex = 2;
            this.cbSucursales.ValueMember = "idSucursal";
            // 
            // tbNumTelefono
            // 
            this.tbNumTelefono.Location = new System.Drawing.Point(172, 130);
            this.tbNumTelefono.Name = "tbNumTelefono";
            this.tbNumTelefono.Size = new System.Drawing.Size(268, 22);
            this.tbNumTelefono.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(365, 203);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 41);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 272);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNumTelefono);
            this.Controls.Add(this.cbSucursales);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbSucursal);
            this.Name = "frmTelefono";
            this.Text = "frmTelefono";
            this.Load += new System.EventHandler(this.frmTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.ComboBox cbSucursales;
        private System.Windows.Forms.TextBox tbNumTelefono;
        private System.Windows.Forms.Button btSave;
    }
}