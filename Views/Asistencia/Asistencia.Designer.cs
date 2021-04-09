namespace ProyectoABD.Views.Asistencia
{
    partial class Asistencia
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
            this.lbHorarioPersonal = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Añadir = new System.Windows.Forms.Button();
            this.DGVAsistencia = new System.Windows.Forms.DataGridView();
            this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBPersonal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTLlegada = new System.Windows.Forms.Button();
            this.BTSalida = new System.Windows.Forms.Button();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.DarkCyan;
            this.panelPersonal.Controls.Add(this.lbHorarioPersonal);
            this.panelPersonal.Location = new System.Drawing.Point(24, 11);
            this.panelPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(750, 73);
            this.panelPersonal.TabIndex = 7;
            // 
            // lbHorarioPersonal
            // 
            this.lbHorarioPersonal.AutoSize = true;
            this.lbHorarioPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorarioPersonal.ForeColor = System.Drawing.Color.White;
            this.lbHorarioPersonal.Location = new System.Drawing.Point(20, 23);
            this.lbHorarioPersonal.Name = "lbHorarioPersonal";
            this.lbHorarioPersonal.Size = new System.Drawing.Size(143, 26);
            this.lbHorarioPersonal.TabIndex = 3;
            this.lbHorarioPersonal.Text = "ASISTENCIA";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(624, 95);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 10;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Añadir
            // 
            this.Btn_Añadir.Location = new System.Drawing.Point(713, 95);
            this.Btn_Añadir.Name = "Btn_Añadir";
            this.Btn_Añadir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Añadir.TabIndex = 9;
            this.Btn_Añadir.Text = "Añadir";
            this.Btn_Añadir.UseVisualStyleBackColor = true;
            this.Btn_Añadir.Click += new System.EventHandler(this.Btn_Añadir_Click);
            // 
            // DGVAsistencia
            // 
            this.DGVAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Personal,
            this.HorarioLlegada,
            this.HorarioSalida,
            this.Fecha});
            this.DGVAsistencia.Location = new System.Drawing.Point(12, 141);
            this.DGVAsistencia.Name = "DGVAsistencia";
            this.DGVAsistencia.Size = new System.Drawing.Size(776, 218);
            this.DGVAsistencia.TabIndex = 8;
            this.DGVAsistencia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAsistencia_CellDoubleClick);
            // 
            // Id_Personal
            // 
            this.Id_Personal.HeaderText = "Id_Personal";
            this.Id_Personal.Name = "Id_Personal";
            this.Id_Personal.ReadOnly = true;
            // 
            // HorarioLlegada
            // 
            this.HorarioLlegada.HeaderText = "HorarioLlegada";
            this.HorarioLlegada.Name = "HorarioLlegada";
            this.HorarioLlegada.ReadOnly = true;
            // 
            // HorarioSalida
            // 
            this.HorarioSalida.HeaderText = "HorarioSalida";
            this.HorarioSalida.Name = "HorarioSalida";
            this.HorarioSalida.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // CBPersonal
            // 
            this.CBPersonal.FormattingEnabled = true;
            this.CBPersonal.Location = new System.Drawing.Point(93, 93);
            this.CBPersonal.Name = "CBPersonal";
            this.CBPersonal.Size = new System.Drawing.Size(121, 21);
            this.CBPersonal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id_Personal";
            // 
            // BTLlegada
            // 
            this.BTLlegada.Location = new System.Drawing.Point(285, 95);
            this.BTLlegada.Name = "BTLlegada";
            this.BTLlegada.Size = new System.Drawing.Size(101, 23);
            this.BTLlegada.TabIndex = 13;
            this.BTLlegada.Text = "Registra Llegada";
            this.BTLlegada.UseVisualStyleBackColor = true;
            this.BTLlegada.Click += new System.EventHandler(this.BTLlegada_Click);
            // 
            // BTSalida
            // 
            this.BTSalida.Location = new System.Drawing.Point(421, 95);
            this.BTSalida.Name = "BTSalida";
            this.BTSalida.Size = new System.Drawing.Size(112, 23);
            this.BTSalida.TabIndex = 14;
            this.BTSalida.Text = "Registra Salida";
            this.BTSalida.UseVisualStyleBackColor = true;
            this.BTSalida.Click += new System.EventHandler(this.BTSalida_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.BTSalida);
            this.Controls.Add(this.BTLlegada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBPersonal);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Añadir);
            this.Controls.Add(this.DGVAsistencia);
            this.Controls.Add(this.panelPersonal);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label lbHorarioPersonal;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Añadir;
        private System.Windows.Forms.DataGridView DGVAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.ComboBox CBPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTLlegada;
        private System.Windows.Forms.Button BTSalida;
    }
}