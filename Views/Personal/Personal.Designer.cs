namespace ProyectoABD.Views.Personal
{
    partial class Personal
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
            this.DGVPersonal = new System.Windows.Forms.DataGridView();
            this.idPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_FormAñadir = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbPersonal = new System.Windows.Forms.Label();
            this.panelPersonal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).BeginInit();
            this.panelPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPersonal
            // 
            this.DGVPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonal,
            this.nss,
            this.idSucursal,
            this.nombre,
            this.numeroCelular,
            this.edad,
            this.fechaNacimiento,
            this.direccion,
            this.email,
            this.tipoEmpleado,
            this.Salario});
            this.DGVPersonal.Location = new System.Drawing.Point(16, 171);
            this.DGVPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.DGVPersonal.Name = "DGVPersonal";
            this.DGVPersonal.RowHeadersWidth = 51;
            this.DGVPersonal.Size = new System.Drawing.Size(1277, 368);
            this.DGVPersonal.TabIndex = 0;
            this.DGVPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPersonal_CellDoubleClick);
            // 
            // idPersonal
            // 
            this.idPersonal.HeaderText = "idPersonal";
            this.idPersonal.MinimumWidth = 6;
            this.idPersonal.Name = "idPersonal";
            this.idPersonal.ReadOnly = true;
            // 
            // nss
            // 
            this.nss.HeaderText = "nss";
            this.nss.MinimumWidth = 6;
            this.nss.Name = "nss";
            this.nss.ReadOnly = true;
            // 
            // idSucursal
            // 
            this.idSucursal.HeaderText = "idSucursal";
            this.idSucursal.MinimumWidth = 6;
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // numeroCelular
            // 
            this.numeroCelular.HeaderText = "numeroCelular";
            this.numeroCelular.MinimumWidth = 6;
            this.numeroCelular.Name = "numeroCelular";
            this.numeroCelular.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "fechaNacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // tipoEmpleado
            // 
            this.tipoEmpleado.HeaderText = "tipoEmpleado";
            this.tipoEmpleado.MinimumWidth = 6;
            this.tipoEmpleado.Name = "tipoEmpleado";
            this.tipoEmpleado.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 6;
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // btn_FormAñadir
            // 
            this.btn_FormAñadir.BackColor = System.Drawing.Color.Gray;
            this.btn_FormAñadir.FlatAppearance.BorderSize = 0;
            this.btn_FormAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FormAñadir.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FormAñadir.ForeColor = System.Drawing.Color.White;
            this.btn_FormAñadir.Location = new System.Drawing.Point(16, 121);
            this.btn_FormAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FormAñadir.Name = "btn_FormAñadir";
            this.btn_FormAñadir.Size = new System.Drawing.Size(100, 40);
            this.btn_FormAñadir.TabIndex = 1;
            this.btn_FormAñadir.Text = "Añadir";
            this.btn_FormAñadir.UseVisualStyleBackColor = false;
            this.btn_FormAñadir.Click += new System.EventHandler(this.btn_FormAñadir_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(150, 121);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 40);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbPersonal
            // 
            this.lbPersonal.AutoSize = true;
            this.lbPersonal.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonal.ForeColor = System.Drawing.Color.White;
            this.lbPersonal.Location = new System.Drawing.Point(27, 28);
            this.lbPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPersonal.Name = "lbPersonal";
            this.lbPersonal.Size = new System.Drawing.Size(162, 33);
            this.lbPersonal.TabIndex = 3;
            this.lbPersonal.Text = "PERSONAL";
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.DarkCyan;
            this.panelPersonal.Controls.Add(this.lbPersonal);
            this.panelPersonal.Location = new System.Drawing.Point(0, 16);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(1000, 90);
            this.panelPersonal.TabIndex = 4;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 554);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_FormAñadir);
            this.Controls.Add(this.DGVPersonal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).EndInit();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nss;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.Button btn_FormAñadir;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbPersonal;
        private System.Windows.Forms.Panel panelPersonal;
    }
}