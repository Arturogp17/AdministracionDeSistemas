namespace ProyectoABD.Views.Telefono
{
    partial class Telefono
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
            this.gridTelefonos = new System.Windows.Forms.DataGridView();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.idTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTelefonos
            // 
            this.gridTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTelefono,
            this.idSucursal,
            this.nombre,
            this.numTelefono});
            this.gridTelefonos.Location = new System.Drawing.Point(66, 145);
            this.gridTelefonos.Name = "gridTelefonos";
            this.gridTelefonos.RowHeadersWidth = 51;
            this.gridTelefonos.RowTemplate.Height = 24;
            this.gridTelefonos.Size = new System.Drawing.Size(648, 325);
            this.gridTelefonos.TabIndex = 0;
            this.gridTelefonos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTelefonos_CellDoubleClick);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(543, 82);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 40);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(639, 82);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 40);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // idTelefono
            // 
            this.idTelefono.HeaderText = "ID";
            this.idTelefono.MinimumWidth = 6;
            this.idTelefono.Name = "idTelefono";
            this.idTelefono.Width = 50;
            // 
            // idSucursal
            // 
            this.idSucursal.HeaderText = "idSucursal";
            this.idSucursal.MinimumWidth = 6;
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Sucursal";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // numTelefono
            // 
            this.numTelefono.HeaderText = "Num.Télefono";
            this.numTelefono.MinimumWidth = 6;
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefonos";
            // 
            // Telefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.gridTelefonos);
            this.Name = "Telefono";
            this.Text = "Telefono";
            this.Load += new System.EventHandler(this.Telefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTelefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTelefonos;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefono;
        private System.Windows.Forms.Label label1;
    }
}