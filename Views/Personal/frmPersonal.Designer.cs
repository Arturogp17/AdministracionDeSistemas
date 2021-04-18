﻿namespace ProyectoABD.Views.Personal
{
    partial class frmPersonal
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
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNSS = new System.Windows.Forms.TextBox();
            this.CBSucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNumCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.btAñadirPersonal = new System.Windows.Forms.Button();
            this.panelCamion = new System.Windows.Forms.Panel();
            this.lbPersonal = new System.Windows.Forms.Label();
            this.panelCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(98, 104);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(121, 20);
            this.TBNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "NSS:";
            // 
            // TBNSS
            // 
            this.TBNSS.Location = new System.Drawing.Point(98, 138);
            this.TBNSS.Name = "TBNSS";
            this.TBNSS.Size = new System.Drawing.Size(121, 20);
            this.TBNSS.TabIndex = 2;
            // 
            // CBSucursal
            // 
            this.CBSucursal.FormattingEnabled = true;
            this.CBSucursal.Location = new System.Drawing.Point(98, 67);
            this.CBSucursal.Name = "CBSucursal";
            this.CBSucursal.Size = new System.Drawing.Size(121, 21);
            this.CBSucursal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Num_Celular:";
            // 
            // TBNumCelular
            // 
            this.TBNumCelular.Location = new System.Drawing.Point(98, 173);
            this.TBNumCelular.Name = "TBNumCelular";
            this.TBNumCelular.Size = new System.Drawing.Size(121, 20);
            this.TBNumCelular.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha_Nacimiento:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(241, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1, 20);
            this.textBox4.TabIndex = 8;
            // 
            // DTPFechaNacimiento
            // 
            this.DTPFechaNacimiento.CustomFormat = "MM/dd/yy";
            this.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFechaNacimiento.Location = new System.Drawing.Point(131, 206);
            this.DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            this.DTPFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaNacimiento.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Direccion:";
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(328, 66);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(121, 20);
            this.TBDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email:";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(328, 101);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(121, 20);
            this.TBEmail.TabIndex = 13;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo_Empleado:";
            // 
            // CBTipoEmpleado
            // 
            this.CBTipoEmpleado.FormattingEnabled = true;
            this.CBTipoEmpleado.Items.AddRange(new object[] {
            "Camionero",
            "Administrativo",
            "Limpieza"});
            this.CBTipoEmpleado.Location = new System.Drawing.Point(329, 136);
            this.CBTipoEmpleado.Name = "CBTipoEmpleado";
            this.CBTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.CBTipoEmpleado.TabIndex = 15;
            // 
            // btAñadirPersonal
            // 
            this.btAñadirPersonal.BackColor = System.Drawing.Color.Gray;
            this.btAñadirPersonal.FlatAppearance.BorderSize = 0;
            this.btAñadirPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirPersonal.ForeColor = System.Drawing.Color.White;
            this.btAñadirPersonal.Location = new System.Drawing.Point(429, 254);
            this.btAñadirPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btAñadirPersonal.Name = "btAñadirPersonal";
            this.btAñadirPersonal.Size = new System.Drawing.Size(75, 32);
            this.btAñadirPersonal.TabIndex = 19;
            this.btAñadirPersonal.Text = "Añadir";
            this.btAñadirPersonal.UseVisualStyleBackColor = false;
            this.btAñadirPersonal.Click += new System.EventHandler(this.btAñadirPersonal_Click);
            // 
            // panelCamion
            // 
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.lbPersonal);
            this.panelCamion.Location = new System.Drawing.Point(0, 7);
            this.panelCamion.Margin = new System.Windows.Forms.Padding(2);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(296, 39);
            this.panelCamion.TabIndex = 18;
            // 
            // lbPersonal
            // 
            this.lbPersonal.AutoSize = true;
            this.lbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonal.ForeColor = System.Drawing.Color.White;
            this.lbPersonal.Location = new System.Drawing.Point(16, 8);
            this.lbPersonal.Name = "lbPersonal";
            this.lbPersonal.Size = new System.Drawing.Size(144, 24);
            this.lbPersonal.TabIndex = 3;
            this.lbPersonal.Text = "Añadir Personal";
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 310);
            this.Controls.Add(this.btAñadirPersonal);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBTipoEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.DTPFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBNumCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNSS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBNombre);
            this.Name = "frmPersonal";
            this.Text = "frmPersonal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNSS;
        private System.Windows.Forms.ComboBox CBSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNumCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker DTPFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBTipoEmpleado;
        private System.Windows.Forms.Button btAñadirPersonal;
        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label lbPersonal;
    }
}