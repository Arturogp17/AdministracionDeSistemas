namespace ProyectoABD.Views.HorarioPersonal
{
    partial class HorarioPersonal
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
            this.Btn_Añadir = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.DGVHorarioPersonal = new System.Windows.Forms.DataGridView();
            this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.lbHorarioPersonal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorarioPersonal)).BeginInit();
            this.panelPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Btn_Añadir
            // 
            this.Btn_Añadir.Location = new System.Drawing.Point(177, 114);
            this.Btn_Añadir.Name = "Btn_Añadir";
            this.Btn_Añadir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Añadir.TabIndex = 1;
            this.Btn_Añadir.Text = "Añadir";
            this.Btn_Añadir.UseVisualStyleBackColor = true;
            this.Btn_Añadir.Click += new System.EventHandler(this.Btn_Añadir_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(586, 114);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // DGVHorarioPersonal
            // 
            this.DGVHorarioPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHorarioPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHorarioPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Personal,
            this.Horas,
            this.Horario});
            this.DGVHorarioPersonal.Location = new System.Drawing.Point(31, 163);
            this.DGVHorarioPersonal.Name = "DGVHorarioPersonal";
            this.DGVHorarioPersonal.Size = new System.Drawing.Size(749, 243);
            this.DGVHorarioPersonal.TabIndex = 5;
            this.DGVHorarioPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHorarioPersonal_CellDoubleClick);
            // 
            // Id_Personal
            // 
            this.Id_Personal.FillWeight = 70F;
            this.Id_Personal.HeaderText = "Id_Personal";
            this.Id_Personal.Name = "Id_Personal";
            this.Id_Personal.ReadOnly = true;
            // 
            // Horas
            // 
            this.Horas.FillWeight = 60F;
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.DarkCyan;
            this.panelPersonal.Controls.Add(this.lbHorarioPersonal);
            this.panelPersonal.Location = new System.Drawing.Point(31, 11);
            this.panelPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(750, 73);
            this.panelPersonal.TabIndex = 6;
            // 
            // lbHorarioPersonal
            // 
            this.lbHorarioPersonal.AutoSize = true;
            this.lbHorarioPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorarioPersonal.ForeColor = System.Drawing.Color.White;
            this.lbHorarioPersonal.Location = new System.Drawing.Point(20, 23);
            this.lbHorarioPersonal.Name = "lbHorarioPersonal";
            this.lbHorarioPersonal.Size = new System.Drawing.Size(242, 26);
            this.lbHorarioPersonal.TabIndex = 3;
            this.lbHorarioPersonal.Text = "HORARIO PERSONAL";
            // 
            // HorarioPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.DGVHorarioPersonal);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Añadir);
            this.Controls.Add(this.label1);
            this.Name = "HorarioPersonal";
            this.Text = "HorarioPersonal";
            this.Load += new System.EventHandler(this.HorarioPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorarioPersonal)).EndInit();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Añadir;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridView DGVHorarioPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label lbHorarioPersonal;
    }
}