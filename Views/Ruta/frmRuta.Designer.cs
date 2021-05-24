namespace ProyectoABD.Views.Ruta
{
    partial class frmRuta
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
            this.panelRuta = new System.Windows.Forms.Panel();
            this.lbRuta = new System.Windows.Forms.Label();
            this.lbCamion = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbSucursalO = new System.Windows.Forms.Label();
            this.lbSucursalD = new System.Windows.Forms.Label();
            this.cbCamion = new System.Windows.Forms.ComboBox();
            this.cbSucOrigen = new System.Windows.Forms.ComboBox();
            this.cbSucDestino = new System.Windows.Forms.ComboBox();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.btAñadirRuta = new System.Windows.Forms.Button();
            this.panelRuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRuta
            // 
            this.panelRuta.BackColor = System.Drawing.Color.DarkCyan;
            this.panelRuta.Controls.Add(this.lbRuta);
            this.panelRuta.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRuta.Location = new System.Drawing.Point(0, 33);
            this.panelRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRuta.Name = "panelRuta";
            this.panelRuta.Size = new System.Drawing.Size(409, 48);
            this.panelRuta.TabIndex = 19;
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuta.ForeColor = System.Drawing.Color.White;
            this.lbRuta.Location = new System.Drawing.Point(21, 10);
            this.lbRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(140, 29);
            this.lbRuta.TabIndex = 3;
            this.lbRuta.Text = "Añadir Ruta";
            // 
            // lbCamion
            // 
            this.lbCamion.AutoSize = true;
            this.lbCamion.Location = new System.Drawing.Point(26, 121);
            this.lbCamion.Name = "lbCamion";
            this.lbCamion.Size = new System.Drawing.Size(55, 17);
            this.lbCamion.TabIndex = 20;
            this.lbCamion.Text = "Camión";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(26, 158);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(90, 17);
            this.lbHora.TabIndex = 21;
            this.lbHora.Text = "Hora Salida: ";
            // 
            // lbSucursalO
            // 
            this.lbSucursalO.AutoSize = true;
            this.lbSucursalO.Location = new System.Drawing.Point(26, 194);
            this.lbSucursalO.Name = "lbSucursalO";
            this.lbSucursalO.Size = new System.Drawing.Size(118, 17);
            this.lbSucursalO.TabIndex = 22;
            this.lbSucursalO.Text = "Sucursal Origen: ";
            // 
            // lbSucursalD
            // 
            this.lbSucursalD.AutoSize = true;
            this.lbSucursalD.Location = new System.Drawing.Point(29, 235);
            this.lbSucursalD.Name = "lbSucursalD";
            this.lbSucursalD.Size = new System.Drawing.Size(119, 17);
            this.lbSucursalD.TabIndex = 23;
            this.lbSucursalD.Text = "Sucursal Destino:";
            // 
            // cbCamion
            // 
            this.cbCamion.FormattingEnabled = true;
            this.cbCamion.Location = new System.Drawing.Point(187, 112);
            this.cbCamion.Name = "cbCamion";
            this.cbCamion.Size = new System.Drawing.Size(222, 24);
            this.cbCamion.TabIndex = 24;
            // 
            // cbSucOrigen
            // 
            this.cbSucOrigen.FormattingEnabled = true;
            this.cbSucOrigen.Location = new System.Drawing.Point(187, 187);
            this.cbSucOrigen.Name = "cbSucOrigen";
            this.cbSucOrigen.Size = new System.Drawing.Size(222, 24);
            this.cbSucOrigen.TabIndex = 25;
            this.cbSucOrigen.SelectedIndexChanged += new System.EventHandler(this.cbSucOrigen_SelectedIndexChanged);
            // 
            // cbSucDestino
            // 
            this.cbSucDestino.FormattingEnabled = true;
            this.cbSucDestino.Location = new System.Drawing.Point(187, 228);
            this.cbSucDestino.Name = "cbSucDestino";
            this.cbSucDestino.Size = new System.Drawing.Size(222, 24);
            this.cbSucDestino.TabIndex = 26;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(187, 152);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(222, 22);
            this.tbHora.TabIndex = 27;
            // 
            // btAñadirRuta
            // 
            this.btAñadirRuta.BackColor = System.Drawing.Color.Gray;
            this.btAñadirRuta.FlatAppearance.BorderSize = 0;
            this.btAñadirRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirRuta.ForeColor = System.Drawing.Color.White;
            this.btAñadirRuta.Location = new System.Drawing.Point(498, 255);
            this.btAñadirRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAñadirRuta.Name = "btAñadirRuta";
            this.btAñadirRuta.Size = new System.Drawing.Size(100, 39);
            this.btAñadirRuta.TabIndex = 28;
            this.btAñadirRuta.Text = "Añadir";
            this.btAñadirRuta.UseVisualStyleBackColor = false;
            this.btAñadirRuta.Click += new System.EventHandler(this.btAñadirRuta_Click);
            // 
            // frmRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 336);
            this.Controls.Add(this.btAñadirRuta);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.cbSucDestino);
            this.Controls.Add(this.cbSucOrigen);
            this.Controls.Add(this.cbCamion);
            this.Controls.Add(this.lbSucursalD);
            this.Controls.Add(this.lbSucursalO);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbCamion);
            this.Controls.Add(this.panelRuta);
            this.Name = "frmRuta";
            this.Text = "frmRuta";
            this.Load += new System.EventHandler(this.frmRuta_Load);
            this.panelRuta.ResumeLayout(false);
            this.panelRuta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRuta;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Label lbCamion;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbSucursalO;
        private System.Windows.Forms.Label lbSucursalD;
        private System.Windows.Forms.ComboBox cbCamion;
        private System.Windows.Forms.ComboBox cbSucOrigen;
        private System.Windows.Forms.ComboBox cbSucDestino;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.Button btAñadirRuta;
    }
}