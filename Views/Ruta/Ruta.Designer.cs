namespace ProyectoABD.Views.Ruta
{
    partial class Ruta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRuta = new System.Windows.Forms.Label();
            this.btEliminarRuta = new System.Windows.Forms.Button();
            this.btAñadirRuta = new System.Windows.Forms.Button();
            this.gridRutas = new System.Windows.Forms.DataGridView();
            this.idRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lbRuta);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 92);
            this.panel1.TabIndex = 9;
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuta.ForeColor = System.Drawing.Color.White;
            this.lbRuta.Location = new System.Drawing.Point(27, 28);
            this.lbRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(105, 33);
            this.lbRuta.TabIndex = 3;
            this.lbRuta.Text = "RUTAS";
            // 
            // btEliminarRuta
            // 
            this.btEliminarRuta.BackColor = System.Drawing.Color.Gray;
            this.btEliminarRuta.FlatAppearance.BorderSize = 0;
            this.btEliminarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarRuta.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarRuta.ForeColor = System.Drawing.Color.White;
            this.btEliminarRuta.Location = new System.Drawing.Point(141, 139);
            this.btEliminarRuta.Name = "btEliminarRuta";
            this.btEliminarRuta.Size = new System.Drawing.Size(100, 40);
            this.btEliminarRuta.TabIndex = 8;
            this.btEliminarRuta.Text = "Eliminar";
            this.btEliminarRuta.UseVisualStyleBackColor = false;
            this.btEliminarRuta.Click += new System.EventHandler(this.btEliminarRuta_Click);
            // 
            // btAñadirRuta
            // 
            this.btAñadirRuta.BackColor = System.Drawing.Color.Gray;
            this.btAñadirRuta.FlatAppearance.BorderSize = 0;
            this.btAñadirRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAñadirRuta.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirRuta.ForeColor = System.Drawing.Color.White;
            this.btAñadirRuta.Location = new System.Drawing.Point(12, 139);
            this.btAñadirRuta.Name = "btAñadirRuta";
            this.btAñadirRuta.Size = new System.Drawing.Size(100, 40);
            this.btAñadirRuta.TabIndex = 7;
            this.btAñadirRuta.Text = "Añadir";
            this.btAñadirRuta.UseVisualStyleBackColor = false;
            this.btAñadirRuta.Click += new System.EventHandler(this.btAñadirRuta_Click);
            // 
            // gridRutas
            // 
            this.gridRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRuta,
            this.idCamion,
            this.infoCamion,
            this.horario,
            this.idSucursalOrigen,
            this.SucOrigen,
            this.idSucursalDestino,
            this.SucDest});
            this.gridRutas.Location = new System.Drawing.Point(12, 196);
            this.gridRutas.Name = "gridRutas";
            this.gridRutas.RowHeadersWidth = 51;
            this.gridRutas.RowTemplate.Height = 24;
            this.gridRutas.Size = new System.Drawing.Size(1088, 227);
            this.gridRutas.TabIndex = 6;
            this.gridRutas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRutas_CellDoubleClick);
            // 
            // idRuta
            // 
            this.idRuta.HeaderText = "idRuta";
            this.idRuta.MinimumWidth = 6;
            this.idRuta.Name = "idRuta";
            this.idRuta.Width = 60;
            // 
            // idCamion
            // 
            this.idCamion.HeaderText = "id Camión";
            this.idCamion.MinimumWidth = 6;
            this.idCamion.Name = "idCamion";
            this.idCamion.Width = 60;
            // 
            // infoCamion
            // 
            this.infoCamion.HeaderText = "Info. Camión";
            this.infoCamion.MinimumWidth = 6;
            this.infoCamion.Name = "infoCamion";
            this.infoCamion.Width = 125;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horario Salida";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.Width = 125;
            // 
            // idSucursalOrigen
            // 
            this.idSucursalOrigen.HeaderText = "id Suc. Origen";
            this.idSucursalOrigen.MinimumWidth = 6;
            this.idSucursalOrigen.Name = "idSucursalOrigen";
            this.idSucursalOrigen.Width = 60;
            // 
            // SucOrigen
            // 
            this.SucOrigen.HeaderText = "Suc. Origen";
            this.SucOrigen.MinimumWidth = 6;
            this.SucOrigen.Name = "SucOrigen";
            this.SucOrigen.Width = 125;
            // 
            // idSucursalDestino
            // 
            this.idSucursalDestino.HeaderText = "id Suc. Destino";
            this.idSucursalDestino.MinimumWidth = 6;
            this.idSucursalDestino.Name = "idSucursalDestino";
            this.idSucursalDestino.Width = 60;
            // 
            // SucDest
            // 
            this.SucDest.HeaderText = "Suc. Destino";
            this.SucDest.MinimumWidth = 6;
            this.SucDest.Name = "SucDest";
            this.SucDest.Width = 125;
            // 
            // Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btEliminarRuta);
            this.Controls.Add(this.btAñadirRuta);
            this.Controls.Add(this.gridRutas);
            this.Name = "Ruta";
            this.Text = "Ruta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Button btEliminarRuta;
        private System.Windows.Forms.Button btAñadirRuta;
        private System.Windows.Forms.DataGridView gridRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucDest;
    }
}