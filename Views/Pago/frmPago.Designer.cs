
namespace ProyectoABD.Views.Pago
{
    partial class frmPago
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
            this.gridPagos = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.idPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIniPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).BeginInit();
            this.SuspendLayout();
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
            this.idPago,
            this.Sucursal,
            this.Personal,
            this.Asistencias,
            this.monto,
            this.fechaIniPeriodo,
            this.fechaFinPeriodo});
            this.gridPagos.Location = new System.Drawing.Point(11, 47);
            this.gridPagos.Margin = new System.Windows.Forms.Padding(2);
            this.gridPagos.MultiSelect = false;
            this.gridPagos.Name = "gridPagos";
            this.gridPagos.ReadOnly = true;
            this.gridPagos.RowHeadersWidth = 51;
            this.gridPagos.RowTemplate.Height = 24;
            this.gridPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPagos.Size = new System.Drawing.Size(778, 392);
            this.gridPagos.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(627, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Eliminar pago";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // idPago
            // 
            this.idPago.HeaderText = "idPago";
            this.idPago.Name = "idPago";
            this.idPago.ReadOnly = true;
            this.idPago.Visible = false;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // Personal
            // 
            this.Personal.HeaderText = "Personal";
            this.Personal.Name = "Personal";
            this.Personal.ReadOnly = true;
            // 
            // Asistencias
            // 
            this.Asistencias.HeaderText = "Asistencias";
            this.Asistencias.Name = "Asistencias";
            this.Asistencias.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // fechaIniPeriodo
            // 
            this.fechaIniPeriodo.HeaderText = "Inicio de periodo";
            this.fechaIniPeriodo.Name = "fechaIniPeriodo";
            this.fechaIniPeriodo.ReadOnly = true;
            // 
            // fechaFinPeriodo
            // 
            this.fechaFinPeriodo.HeaderText = "Fin de periodo";
            this.fechaFinPeriodo.Name = "fechaFinPeriodo";
            this.fechaFinPeriodo.ReadOnly = true;
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gridPagos);
            this.Name = "frmPago";
            this.Text = "frmPago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPagos;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIniPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinPeriodo;
    }
}