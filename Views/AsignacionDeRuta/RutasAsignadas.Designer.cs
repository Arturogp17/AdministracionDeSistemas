namespace ProyectoABD.Views.AsignacionDeRuta
{
    partial class RutasAsignadas
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
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.lbPersonal = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_FormAgregar = new System.Windows.Forms.Button();
            this.grdAsignacionDeRutas = new System.Windows.Forms.DataGridView();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsignacionDeRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.DarkCyan;
            this.panelPersonal.Controls.Add(this.lbPersonal);
            this.panelPersonal.Location = new System.Drawing.Point(11, 11);
            this.panelPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(750, 73);
            this.panelPersonal.TabIndex = 8;
            // 
            // lbPersonal
            // 
            this.lbPersonal.AutoSize = true;
            this.lbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonal.ForeColor = System.Drawing.Color.White;
            this.lbPersonal.Location = new System.Drawing.Point(16, 24);
            this.lbPersonal.Name = "lbPersonal";
            this.lbPersonal.Size = new System.Drawing.Size(268, 26);
            this.lbPersonal.TabIndex = 3;
            this.lbPersonal.Text = "ASIGNACIÓN DE RUTAS";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(132, 106);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 32);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_FormAgregar
            // 
            this.btn_FormAgregar.BackColor = System.Drawing.Color.Gray;
            this.btn_FormAgregar.FlatAppearance.BorderSize = 0;
            this.btn_FormAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FormAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FormAgregar.ForeColor = System.Drawing.Color.White;
            this.btn_FormAgregar.Location = new System.Drawing.Point(32, 106);
            this.btn_FormAgregar.Name = "btn_FormAgregar";
            this.btn_FormAgregar.Size = new System.Drawing.Size(75, 32);
            this.btn_FormAgregar.TabIndex = 6;
            this.btn_FormAgregar.Text = "Añadir";
            this.btn_FormAgregar.UseVisualStyleBackColor = false;
            this.btn_FormAgregar.Click += new System.EventHandler(this.Btn_FormAgregar_Click);
            // 
            // grdAsignacionDeRutas
            // 
            this.grdAsignacionDeRutas.AllowUserToAddRows = false;
            this.grdAsignacionDeRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAsignacionDeRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAsignacionDeRutas.Location = new System.Drawing.Point(32, 147);
            this.grdAsignacionDeRutas.Name = "grdAsignacionDeRutas";
            this.grdAsignacionDeRutas.RowHeadersWidth = 51;
            this.grdAsignacionDeRutas.Size = new System.Drawing.Size(958, 299);
            this.grdAsignacionDeRutas.TabIndex = 5;
            this.grdAsignacionDeRutas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAsignacionDeRutas_CellDoubleClick);
            // 
            // RutasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 515);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_FormAgregar);
            this.Controls.Add(this.grdAsignacionDeRutas);
            this.Name = "RutasAsignadas";
            this.Text = "RutasAsignadas";
            this.Load += new System.EventHandler(this.RutasAsignadas_Load);
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsignacionDeRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label lbPersonal;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_FormAgregar;
        private System.Windows.Forms.DataGridView grdAsignacionDeRutas;
    }
}