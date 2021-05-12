
namespace ProyectoABD.Views.Pago
{
    partial class Pago
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridPagos = new System.Windows.Forms.DataGridView();
            this.idPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasTrabajados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpInicio = new System.Windows.Forms.DateTimePicker();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.panelCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCamion
            // 
            this.panelCamion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.lbSucursal);
            this.panelCamion.Location = new System.Drawing.Point(5, 13);
            this.panelCamion.Margin = new System.Windows.Forms.Padding(2);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(979, 73);
            this.panelCamion.TabIndex = 13;
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursal.ForeColor = System.Drawing.Color.White;
            this.lbSucursal.Location = new System.Drawing.Point(20, 23);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(74, 26);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "Pagos";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(19, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Realizar pagos";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridPagos
            // 
            this.gridPagos.AllowUserToAddRows = false;
            this.gridPagos.AllowUserToDeleteRows = false;
            this.gridPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonal,
            this.Nombre,
            this.NSS,
            this.Cuenta,
            this.DiasTrabajados,
            this.Salario,
            this.PagoR});
            this.gridPagos.Location = new System.Drawing.Point(19, 138);
            this.gridPagos.Margin = new System.Windows.Forms.Padding(2);
            this.gridPagos.MultiSelect = false;
            this.gridPagos.Name = "gridPagos";
            this.gridPagos.ReadOnly = true;
            this.gridPagos.RowHeadersWidth = 51;
            this.gridPagos.RowTemplate.Height = 24;
            this.gridPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPagos.Size = new System.Drawing.Size(965, 300);
            this.gridPagos.TabIndex = 10;
            // 
            // idPersonal
            // 
            this.idPersonal.HeaderText = "idPersonal";
            this.idPersonal.Name = "idPersonal";
            this.idPersonal.ReadOnly = true;
            this.idPersonal.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NSS
            // 
            this.NSS.HeaderText = "NSS";
            this.NSS.Name = "NSS";
            this.NSS.ReadOnly = true;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // DiasTrabajados
            // 
            this.DiasTrabajados.HeaderText = "Dias trabajados";
            this.DiasTrabajados.Name = "DiasTrabajados";
            this.DiasTrabajados.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Sueldo mensual";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // PagoR
            // 
            this.PagoR.HeaderText = "Pago a realizar";
            this.PagoR.Name = "PagoR";
            this.PagoR.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sucursal";
            // 
            // ddlSucursal
            // 
            this.ddlSucursal.DisplayMember = "idNombre";
            this.ddlSucursal.FormattingEnabled = true;
            this.ddlSucursal.Location = new System.Drawing.Point(271, 104);
            this.ddlSucursal.Name = "ddlSucursal";
            this.ddlSucursal.Size = new System.Drawing.Size(175, 21);
            this.ddlSucursal.TabIndex = 16;
            this.ddlSucursal.ValueMember = "idSucursal";
            this.ddlSucursal.SelectedIndexChanged += new System.EventHandler(this.ddlSucursal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Periodo de";
            // 
            // dpInicio
            // 
            this.dpInicio.Enabled = false;
            this.dpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInicio.Location = new System.Drawing.Point(603, 105);
            this.dpInicio.Name = "dpInicio";
            this.dpInicio.Size = new System.Drawing.Size(80, 20);
            this.dpInicio.TabIndex = 18;
            // 
            // dpFin
            // 
            this.dpFin.Enabled = false;
            this.dpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFin.Location = new System.Drawing.Point(718, 105);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(80, 20);
            this.dpFin.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "al";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Gray;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(888, 97);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 32);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "Pagos";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpFin);
            this.Controls.Add(this.dpInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridPagos);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridPagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasTrabajados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagoR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpInicio;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
    }
}