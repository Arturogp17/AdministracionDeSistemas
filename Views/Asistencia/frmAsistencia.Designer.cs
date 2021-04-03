namespace ProyectoABD.Views.Asistencia
{
    partial class frmAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.LHoraSalida = new System.Windows.Forms.Label();
            this.TBHoraSalida = new System.Windows.Forms.TextBox();
            this.LHoraLLegada = new System.Windows.Forms.Label();
            this.TBHoraLlegada = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.LPersonal = new System.Windows.Forms.Label();
            this.CBPersonal = new System.Windows.Forms.ComboBox();
            this.panelCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamion
            // 
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.label1);
            this.panelCamion.Location = new System.Drawing.Point(11, 11);
            this.panelCamion.Margin = new System.Windows.Forms.Padding(2);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(296, 39);
            this.panelCamion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Añadir/Editar Asistencia";
            // 
            // LHoraSalida
            // 
            this.LHoraSalida.AutoSize = true;
            this.LHoraSalida.Location = new System.Drawing.Point(32, 149);
            this.LHoraSalida.Name = "LHoraSalida";
            this.LHoraSalida.Size = new System.Drawing.Size(73, 13);
            this.LHoraSalida.TabIndex = 22;
            this.LHoraSalida.Text = "Horario Salida";
            // 
            // TBHoraSalida
            // 
            this.TBHoraSalida.Location = new System.Drawing.Point(117, 146);
            this.TBHoraSalida.Name = "TBHoraSalida";
            this.TBHoraSalida.Size = new System.Drawing.Size(176, 20);
            this.TBHoraSalida.TabIndex = 21;
            // 
            // LHoraLLegada
            // 
            this.LHoraLLegada.AutoSize = true;
            this.LHoraLLegada.Location = new System.Drawing.Point(32, 113);
            this.LHoraLLegada.Name = "LHoraLLegada";
            this.LHoraLLegada.Size = new System.Drawing.Size(82, 13);
            this.LHoraLLegada.TabIndex = 20;
            this.LHoraLLegada.Text = "Horario Llegada";
            // 
            // TBHoraLlegada
            // 
            this.TBHoraLlegada.Location = new System.Drawing.Point(117, 110);
            this.TBHoraLlegada.Name = "TBHoraLlegada";
            this.TBHoraLlegada.Size = new System.Drawing.Size(176, 20);
            this.TBHoraLlegada.TabIndex = 19;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(218, 184);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Agregar.TabIndex = 18;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // LPersonal
            // 
            this.LPersonal.AutoSize = true;
            this.LPersonal.Location = new System.Drawing.Point(32, 72);
            this.LPersonal.Name = "LPersonal";
            this.LPersonal.Size = new System.Drawing.Size(48, 13);
            this.LPersonal.TabIndex = 17;
            this.LPersonal.Text = "Personal";
            // 
            // CBPersonal
            // 
            this.CBPersonal.FormattingEnabled = true;
            this.CBPersonal.Location = new System.Drawing.Point(86, 69);
            this.CBPersonal.Name = "CBPersonal";
            this.CBPersonal.Size = new System.Drawing.Size(207, 21);
            this.CBPersonal.TabIndex = 16;
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 233);
            this.Controls.Add(this.LHoraSalida);
            this.Controls.Add(this.TBHoraSalida);
            this.Controls.Add(this.LHoraLLegada);
            this.Controls.Add(this.TBHoraLlegada);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.LPersonal);
            this.Controls.Add(this.CBPersonal);
            this.Controls.Add(this.panelCamion);
            this.Name = "frmAsistencia";
            this.Text = "frmAsistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LHoraSalida;
        private System.Windows.Forms.TextBox TBHoraSalida;
        private System.Windows.Forms.Label LHoraLLegada;
        private System.Windows.Forms.TextBox TBHoraLlegada;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label LPersonal;
        private System.Windows.Forms.ComboBox CBPersonal;
    }
}