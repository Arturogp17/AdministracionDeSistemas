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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).BeginInit();
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
            this.DGVPersonal.Location = new System.Drawing.Point(12, 51);
            this.DGVPersonal.Name = "DGVPersonal";
            this.DGVPersonal.Size = new System.Drawing.Size(958, 387);
            this.DGVPersonal.TabIndex = 0;
            this.DGVPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPersonal_CellDoubleClick);
            // 
            // idPersonal
            // 
            this.idPersonal.HeaderText = "idPersonal";
            this.idPersonal.Name = "idPersonal";
            this.idPersonal.ReadOnly = true;
            // 
            // nss
            // 
            this.nss.HeaderText = "nss";
            this.nss.Name = "nss";
            this.nss.ReadOnly = true;
            // 
            // idSucursal
            // 
            this.idSucursal.HeaderText = "idSucursal";
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // numeroCelular
            // 
            this.numeroCelular.HeaderText = "numeroCelular";
            this.numeroCelular.Name = "numeroCelular";
            this.numeroCelular.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "fechaNacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // tipoEmpleado
            // 
            this.tipoEmpleado.HeaderText = "tipoEmpleado";
            this.tipoEmpleado.Name = "tipoEmpleado";
            this.tipoEmpleado.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // btn_FormAñadir
            // 
            this.btn_FormAñadir.Location = new System.Drawing.Point(246, 13);
            this.btn_FormAñadir.Name = "btn_FormAñadir";
            this.btn_FormAñadir.Size = new System.Drawing.Size(75, 23);
            this.btn_FormAñadir.TabIndex = 1;
            this.btn_FormAñadir.Text = "Añadir";
            this.btn_FormAñadir.UseVisualStyleBackColor = true;
            this.btn_FormAñadir.Click += new System.EventHandler(this.btn_FormAñadir_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(571, 13);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PERSONAL";
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_FormAñadir);
            this.Controls.Add(this.DGVPersonal);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}