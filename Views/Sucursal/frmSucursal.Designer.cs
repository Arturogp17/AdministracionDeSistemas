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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.panelCamion = new System.Windows.Forms.Panel();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.btAñadirSucursal = new System.Windows.Forms.Button();
            this.panelCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(29, 82);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 18);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre: ";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.Location = new System.Drawing.Point(29, 122);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(76, 18);
            this.lbdireccion.TabIndex = 2;
            this.lbdireccion.Text = "Dirección:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(124, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(168, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(124, 117);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(168, 22);
            this.tbDireccion.TabIndex = 4;
            // 
            // panelCamion
            // 
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.lbSucursal);
            this.panelCamion.Location = new System.Drawing.Point(0, 9);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(395, 48);
            this.panelCamion.TabIndex = 10;
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursal.ForeColor = System.Drawing.Color.White;
            this.lbSucursal.Location = new System.Drawing.Point(21, 10);
            this.lbSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(185, 29);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "Añadir Sucursal";
            // 
            // btAñadirSucursal
            // 
            this.btAñadirSucursal.BackColor = System.Drawing.Color.Gray;
            this.btAñadirSucursal.FlatAppearance.BorderSize = 0;
            this.btAñadirSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirSucursal.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirSucursal.ForeColor = System.Drawing.Color.White;
            this.btAñadirSucursal.Location = new System.Drawing.Point(388, 173);
            this.btAñadirSucursal.Name = "btAñadirSucursal";
            this.btAñadirSucursal.Size = new System.Drawing.Size(100, 40);
            this.btAñadirSucursal.TabIndex = 11;
            this.btAñadirSucursal.Text = "Añadir";
            this.btAñadirSucursal.UseVisualStyleBackColor = false;
            this.btAñadirSucursal.Click += new System.EventHandler(this.btAñadirSucursal_Click);
            // 
            // frmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 234);
            this.Controls.Add(this.btAñadirSucursal);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.lbNombre);
            this.Name = "frmSucursal";
            this.Text = "frmSucursal";
            this.Load += new System.EventHandler(this.frmSucursal_Load);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Button btAñadirSucursal;
    }
}