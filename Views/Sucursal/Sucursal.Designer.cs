namespace ProyectoABD.Views.Sucursal
{
    partial class Sucursal
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
            this.gridSucursales = new System.Windows.Forms.DataGridView();
            this.idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAñadirSucursal = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.conjunto = new System.Data.DataSet();
            this.lbSucursales = new System.Windows.Forms.Label();
            this.telefonos = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjunto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSucursales
            // 
            this.gridSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSucursal,
            this.nombre,
            this.direccion,
            this.telefonos});
            this.gridSucursales.Location = new System.Drawing.Point(103, 81);
            this.gridSucursales.Name = "gridSucursales";
            this.gridSucursales.RowHeadersWidth = 51;
            this.gridSucursales.RowTemplate.Height = 24;
            this.gridSucursales.Size = new System.Drawing.Size(820, 308);
            this.gridSucursales.TabIndex = 0;
            this.gridSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSucursales_CellClick);
            this.gridSucursales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSucursales_CellDoubleClick);
            // 
            // idSucursal
            // 
            this.idSucursal.HeaderText = "id Sucursal";
            this.idSucursal.MinimumWidth = 6;
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Width = 125;
            // 
            // btAñadirSucursal
            // 
            this.btAñadirSucursal.Location = new System.Drawing.Point(717, 31);
            this.btAñadirSucursal.Name = "btAñadirSucursal";
            this.btAñadirSucursal.Size = new System.Drawing.Size(88, 36);
            this.btAñadirSucursal.TabIndex = 1;
            this.btAñadirSucursal.Text = "Añadir";
            this.btAñadirSucursal.UseVisualStyleBackColor = true;
            this.btAñadirSucursal.Click += new System.EventHandler(this.btAñadirSucursal_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(826, 31);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(88, 36);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // conjunto
            // 
            this.conjunto.DataSetName = "NewDataSet";
            // 
            // lbSucursales
            // 
            this.lbSucursales.AutoSize = true;
            this.lbSucursales.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursales.Location = new System.Drawing.Point(103, 35);
            this.lbSucursales.Name = "lbSucursales";
            this.lbSucursales.Size = new System.Drawing.Size(141, 24);
            this.lbSucursales.TabIndex = 3;
            this.lbSucursales.Text = "SUCURSALES";
            // 
            // telefonos
            // 
            this.telefonos.HeaderText = "Teléfono(s)";
            this.telefonos.MinimumWidth = 6;
            this.telefonos.Name = "telefonos";
            this.telefonos.Width = 125;
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.lbSucursales);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAñadirSucursal);
            this.Controls.Add(this.gridSucursales);
            this.Name = "Sucursal";
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.Sucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSucursales;
        private System.Windows.Forms.Button btAñadirSucursal;
        private System.Windows.Forms.Button btEliminar;
        private System.Data.DataSet conjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Label lbSucursales;
        private System.Windows.Forms.DataGridViewButtonColumn telefonos;
    }
}