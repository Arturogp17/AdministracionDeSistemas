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
            this.telefonos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btAñadirSucursal = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.conjunto = new System.Data.DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSucursal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjunto)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gridSucursales.Location = new System.Drawing.Point(16, 171);
            this.gridSucursales.Name = "gridSucursales";
            this.gridSucursales.RowHeadersWidth = 51;
            this.gridSucursales.RowTemplate.Height = 24;
            this.gridSucursales.Size = new System.Drawing.Size(820, 227);
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
            // telefonos
            // 
            this.telefonos.HeaderText = "Teléfono(s)";
            this.telefonos.MinimumWidth = 6;
            this.telefonos.Name = "telefonos";
            this.telefonos.Width = 125;
            // 
            // btAñadirSucursal
            // 
            this.btAñadirSucursal.BackColor = System.Drawing.Color.Gray;
            this.btAñadirSucursal.FlatAppearance.BorderSize = 0;
            this.btAñadirSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirSucursal.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirSucursal.ForeColor = System.Drawing.Color.White;
            this.btAñadirSucursal.Location = new System.Drawing.Point(16, 121);
            this.btAñadirSucursal.Name = "btAñadirSucursal";
            this.btAñadirSucursal.Size = new System.Drawing.Size(100, 40);
            this.btAñadirSucursal.TabIndex = 1;
            this.btAñadirSucursal.Text = "Añadir";
            this.btAñadirSucursal.UseVisualStyleBackColor = false;
            this.btAñadirSucursal.Click += new System.EventHandler(this.btAñadirSucursal_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Gray;
            this.btEliminar.FlatAppearance.BorderSize = 0;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(150, 121);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 40);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // conjunto
            // 
            this.conjunto.DataSetName = "NewDataSet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lbSucursal);
            this.panel1.Location = new System.Drawing.Point(-2, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 90);
            this.panel1.TabIndex = 5;
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursal.ForeColor = System.Drawing.Color.White;
            this.lbSucursal.Location = new System.Drawing.Point(27, 28);
            this.lbSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(197, 33);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "SUCURSALES";
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAñadirSucursal);
            this.Controls.Add(this.gridSucursales);
            this.Name = "Sucursal";
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.Sucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjunto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSucursales;
        private System.Windows.Forms.Button btAñadirSucursal;
        private System.Windows.Forms.Button btEliminar;
        private System.Data.DataSet conjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewButtonColumn telefonos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSucursal;
    }
}