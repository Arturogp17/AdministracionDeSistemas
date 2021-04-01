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
            this.btAñadirTelefono = new System.Windows.Forms.Button();
            this.panelCamion = new System.Windows.Forms.Panel();
            this.lbAddTel = new System.Windows.Forms.Label();
            this.panelCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursal.Location = new System.Drawing.Point(38, 88);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(67, 18);
            this.lbSucursal.TabIndex = 0;
            this.lbSucursal.Text = "Sucursal";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(38, 135);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(69, 18);
            this.lbTelefono.TabIndex = 1;
            this.lbTelefono.Text = "Teléfono";
            // 
            // cbSucursales
            // 
            this.cbSucursales.DisplayMember = "idSucursal";
            this.cbSucursales.FormattingEnabled = true;
            this.cbSucursales.Location = new System.Drawing.Point(145, 81);
            this.cbSucursales.Name = "cbSucursales";
            this.cbSucursales.Size = new System.Drawing.Size(268, 24);
            this.cbSucursales.TabIndex = 2;
            this.cbSucursales.ValueMember = "idSucursal";
            // 
            // tbNumTelefono
            // 
            this.tbNumTelefono.Location = new System.Drawing.Point(145, 135);
            this.tbNumTelefono.Name = "tbNumTelefono";
            this.tbNumTelefono.Size = new System.Drawing.Size(268, 22);
            this.tbNumTelefono.TabIndex = 3;
            // 
            // btAñadirTelefono
            // 
            this.btAñadirTelefono.BackColor = System.Drawing.Color.Gray;
            this.btAñadirTelefono.FlatAppearance.BorderSize = 0;
            this.btAñadirTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirTelefono.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirTelefono.ForeColor = System.Drawing.Color.White;
            this.btAñadirTelefono.Location = new System.Drawing.Point(395, 220);
            this.btAñadirTelefono.Name = "btAñadirTelefono";
            this.btAñadirTelefono.Size = new System.Drawing.Size(100, 40);
            this.btAñadirTelefono.TabIndex = 13;
            this.btAñadirTelefono.Text = "Añadir";
            this.btAñadirTelefono.UseVisualStyleBackColor = false;
            this.btAñadirTelefono.Click += new System.EventHandler(this.btAñadirSucursal_Click);
            // 
            // panelCamion
            // 
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.lbAddTel);
            this.panelCamion.Location = new System.Drawing.Point(0, 9);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(395, 48);
            this.panelCamion.TabIndex = 12;
            // 
            // lbAddTel
            // 
            this.lbAddTel.AutoSize = true;
            this.lbAddTel.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddTel.ForeColor = System.Drawing.Color.White;
            this.lbAddTel.Location = new System.Drawing.Point(21, 10);
            this.lbAddTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddTel.Name = "lbAddTel";
            this.lbAddTel.Size = new System.Drawing.Size(184, 29);
            this.lbAddTel.TabIndex = 3;
            this.lbAddTel.Text = "Añadir Teléfono";
            // 
            // frmTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 272);
            this.Controls.Add(this.btAñadirTelefono);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.tbNumTelefono);
            this.Controls.Add(this.cbSucursales);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbSucursal);
            this.Name = "frmTelefono";
            this.Text = "frmTelefono";
            this.Load += new System.EventHandler(this.frmTelefono_Load);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.ComboBox cbSucursales;
        private System.Windows.Forms.TextBox tbNumTelefono;
        private System.Windows.Forms.Button btAñadirTelefono;
        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label lbAddTel;
    }
}