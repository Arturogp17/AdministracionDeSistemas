
namespace ProyectoABD.Views.Camion
{
    partial class Camion
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
            this.panelCamion = new System.Windows.Forms.Panel();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.btEliminarCamion = new System.Windows.Forms.Button();
            this.btAñadirCamion = new System.Windows.Forms.Button();
            this.gridCamiones = new System.Windows.Forms.DataGridView();
            this.panelCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCamion
            // 
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.lbSucursal);
            this.panelCamion.Location = new System.Drawing.Point(-1, 14);
            this.panelCamion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(750, 73);
            this.panelCamion.TabIndex = 9;
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursal.ForeColor = System.Drawing.Color.White;
            this.lbSucursal.Location = new System.Drawing.Point(20, 23);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(130, 26);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "CAMIONES";
            // 
            // btEliminarCamion
            // 
            this.btEliminarCamion.BackColor = System.Drawing.Color.Gray;
            this.btEliminarCamion.FlatAppearance.BorderSize = 0;
            this.btEliminarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarCamion.ForeColor = System.Drawing.Color.White;
            this.btEliminarCamion.Location = new System.Drawing.Point(113, 98);
            this.btEliminarCamion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEliminarCamion.Name = "btEliminarCamion";
            this.btEliminarCamion.Size = new System.Drawing.Size(75, 32);
            this.btEliminarCamion.TabIndex = 8;
            this.btEliminarCamion.Text = "Eliminar";
            this.btEliminarCamion.UseVisualStyleBackColor = false;
            // 
            // btAñadirCamion
            // 
            this.btAñadirCamion.BackColor = System.Drawing.Color.Gray;
            this.btAñadirCamion.FlatAppearance.BorderSize = 0;
            this.btAñadirCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirCamion.ForeColor = System.Drawing.Color.White;
            this.btAñadirCamion.Location = new System.Drawing.Point(13, 98);
            this.btAñadirCamion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAñadirCamion.Name = "btAñadirCamion";
            this.btAñadirCamion.Size = new System.Drawing.Size(75, 32);
            this.btAñadirCamion.TabIndex = 7;
            this.btAñadirCamion.Text = "Añadir";
            this.btAñadirCamion.UseVisualStyleBackColor = false;
            this.btAñadirCamion.Click += new System.EventHandler(this.BtAñadirCamion_Click);
            // 
            // gridCamiones
            // 
            this.gridCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCamiones.Location = new System.Drawing.Point(13, 139);
            this.gridCamiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCamiones.Name = "gridCamiones";
            this.gridCamiones.RowHeadersWidth = 51;
            this.gridCamiones.RowTemplate.Height = 24;
            this.gridCamiones.Size = new System.Drawing.Size(615, 184);
            this.gridCamiones.TabIndex = 6;
            // 
            // Camion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.btEliminarCamion);
            this.Controls.Add(this.btAñadirCamion);
            this.Controls.Add(this.gridCamiones);
            this.Name = "Camion";
            this.Text = "Form1";
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCamiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Button btEliminarCamion;
        private System.Windows.Forms.Button btAñadirCamion;
        private System.Windows.Forms.DataGridView gridCamiones;
    }
}