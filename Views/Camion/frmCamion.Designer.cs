
namespace ProyectoABD.Views.Camion
{
    partial class frmCamion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidCamion = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlSucursal = new System.Windows.Forms.ComboBox();
            this.dpAnio = new System.Windows.Forms.DateTimePicker();
            this.chkComprado = new System.Windows.Forms.RadioButton();
            this.chkArrendado = new System.Windows.Forms.RadioButton();
            this.grpArrendado = new System.Windows.Forms.GroupBox();
            this.txtArrendadoProveedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numArrendadoCosto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlArrendadoContrato = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpComprado = new System.Windows.Forms.GroupBox();
            this.dpCompradoFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numCompradoCosto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.grpArrendado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrendadoCosto)).BeginInit();
            this.grpComprado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompradoCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idCamion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sucursal";
            // 
            // txtidCamion
            // 
            this.txtidCamion.Enabled = false;
            this.txtidCamion.Location = new System.Drawing.Point(95, 21);
            this.txtidCamion.Name = "txtidCamion";
            this.txtidCamion.Size = new System.Drawing.Size(206, 20);
            this.txtidCamion.TabIndex = 3;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(95, 48);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(206, 20);
            this.txtPlaca.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(226, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(145, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 102);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(206, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(95, 128);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(206, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Año";
            // 
            // ddlSucursal
            // 
            this.ddlSucursal.DisplayMember = "idNombre";
            this.ddlSucursal.FormattingEnabled = true;
            this.ddlSucursal.Location = new System.Drawing.Point(95, 75);
            this.ddlSucursal.Name = "ddlSucursal";
            this.ddlSucursal.Size = new System.Drawing.Size(206, 21);
            this.ddlSucursal.TabIndex = 13;
            this.ddlSucursal.ValueMember = "idSucursal";
            // 
            // dpAnio
            // 
            this.dpAnio.CustomFormat = "yyyy";
            this.dpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpAnio.Location = new System.Drawing.Point(95, 154);
            this.dpAnio.Name = "dpAnio";
            this.dpAnio.Size = new System.Drawing.Size(206, 20);
            this.dpAnio.TabIndex = 14;
            // 
            // chkComprado
            // 
            this.chkComprado.AutoSize = true;
            this.chkComprado.Checked = true;
            this.chkComprado.Location = new System.Drawing.Point(49, 180);
            this.chkComprado.Name = "chkComprado";
            this.chkComprado.Size = new System.Drawing.Size(73, 17);
            this.chkComprado.TabIndex = 16;
            this.chkComprado.TabStop = true;
            this.chkComprado.Text = "Comprado";
            this.chkComprado.UseVisualStyleBackColor = true;
            this.chkComprado.CheckedChanged += new System.EventHandler(this.chkComprado_CheckedChanged);
            // 
            // chkArrendado
            // 
            this.chkArrendado.AutoSize = true;
            this.chkArrendado.Location = new System.Drawing.Point(189, 180);
            this.chkArrendado.Name = "chkArrendado";
            this.chkArrendado.Size = new System.Drawing.Size(74, 17);
            this.chkArrendado.TabIndex = 17;
            this.chkArrendado.Text = "Arrendado";
            this.chkArrendado.UseVisualStyleBackColor = true;
            // 
            // grpArrendado
            // 
            this.grpArrendado.Controls.Add(this.txtArrendadoProveedor);
            this.grpArrendado.Controls.Add(this.label9);
            this.grpArrendado.Controls.Add(this.numArrendadoCosto);
            this.grpArrendado.Controls.Add(this.label8);
            this.grpArrendado.Controls.Add(this.ddlArrendadoContrato);
            this.grpArrendado.Controls.Add(this.label7);
            this.grpArrendado.Location = new System.Drawing.Point(24, 197);
            this.grpArrendado.Name = "grpArrendado";
            this.grpArrendado.Size = new System.Drawing.Size(286, 104);
            this.grpArrendado.TabIndex = 18;
            this.grpArrendado.TabStop = false;
            this.grpArrendado.Text = "Arrendado";
            this.grpArrendado.Visible = false;
            // 
            // txtArrendadoProveedor
            // 
            this.txtArrendadoProveedor.Location = new System.Drawing.Point(112, 77);
            this.txtArrendadoProveedor.Name = "txtArrendadoProveedor";
            this.txtArrendadoProveedor.Size = new System.Drawing.Size(168, 20);
            this.txtArrendadoProveedor.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Proveedor";
            // 
            // numArrendadoCosto
            // 
            this.numArrendadoCosto.Location = new System.Drawing.Point(112, 51);
            this.numArrendadoCosto.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numArrendadoCosto.Name = "numArrendadoCosto";
            this.numArrendadoCosto.Size = new System.Drawing.Size(168, 20);
            this.numArrendadoCosto.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Costo total";
            // 
            // ddlArrendadoContrato
            // 
            this.ddlArrendadoContrato.DisplayMember = "value";
            this.ddlArrendadoContrato.FormattingEnabled = true;
            this.ddlArrendadoContrato.Location = new System.Drawing.Point(112, 24);
            this.ddlArrendadoContrato.Name = "ddlArrendadoContrato";
            this.ddlArrendadoContrato.Size = new System.Drawing.Size(168, 21);
            this.ddlArrendadoContrato.TabIndex = 19;
            this.ddlArrendadoContrato.ValueMember = "value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tiempo contrato";
            // 
            // grpComprado
            // 
            this.grpComprado.Controls.Add(this.dpCompradoFechaCompra);
            this.grpComprado.Controls.Add(this.label10);
            this.grpComprado.Controls.Add(this.numCompradoCosto);
            this.grpComprado.Controls.Add(this.label11);
            this.grpComprado.Location = new System.Drawing.Point(15, 203);
            this.grpComprado.Name = "grpComprado";
            this.grpComprado.Size = new System.Drawing.Size(286, 104);
            this.grpComprado.TabIndex = 22;
            this.grpComprado.TabStop = false;
            this.grpComprado.Text = "Comprado";
            // 
            // dpCompradoFechaCompra
            // 
            this.dpCompradoFechaCompra.CustomFormat = "";
            this.dpCompradoFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCompradoFechaCompra.Location = new System.Drawing.Point(112, 46);
            this.dpCompradoFechaCompra.Name = "dpCompradoFechaCompra";
            this.dpCompradoFechaCompra.Size = new System.Drawing.Size(168, 20);
            this.dpCompradoFechaCompra.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha de compra";
            // 
            // numCompradoCosto
            // 
            this.numCompradoCosto.Location = new System.Drawing.Point(112, 20);
            this.numCompradoCosto.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numCompradoCosto.Name = "numCompradoCosto";
            this.numCompradoCosto.Size = new System.Drawing.Size(168, 20);
            this.numCompradoCosto.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Costo total";
            // 
            // frmCamion
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(311, 344);
            this.Controls.Add(this.grpComprado);
            this.Controls.Add(this.grpArrendado);
            this.Controls.Add(this.chkArrendado);
            this.Controls.Add(this.chkComprado);
            this.Controls.Add(this.dpAnio);
            this.Controls.Add(this.ddlSucursal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtidCamion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCamion";
            this.Text = "frmCamion";
            this.Load += new System.EventHandler(this.frmCamion_Load);
            this.grpArrendado.ResumeLayout(false);
            this.grpArrendado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrendadoCosto)).EndInit();
            this.grpComprado.ResumeLayout(false);
            this.grpComprado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompradoCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidCamion;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlSucursal;
        private System.Windows.Forms.DateTimePicker dpAnio;
        private System.Windows.Forms.RadioButton chkComprado;
        private System.Windows.Forms.RadioButton chkArrendado;
        private System.Windows.Forms.GroupBox grpArrendado;
        private System.Windows.Forms.TextBox txtArrendadoProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numArrendadoCosto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlArrendadoContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpComprado;
        private System.Windows.Forms.DateTimePicker dpCompradoFechaCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numCompradoCosto;
        private System.Windows.Forms.Label label11;
    }
}