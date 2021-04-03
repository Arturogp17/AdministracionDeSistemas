namespace ProyectoABD.Views.HorarioPersonal
{
    partial class frmHorarioPersonal
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
            this.lbAddTel = new System.Windows.Forms.Label();
            this.panelCamion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LHorario = new System.Windows.Forms.Label();
            this.CHBDomingo = new System.Windows.Forms.CheckBox();
            this.CHBSabado = new System.Windows.Forms.CheckBox();
            this.CHBViernes = new System.Windows.Forms.CheckBox();
            this.CHBJueves = new System.Windows.Forms.CheckBox();
            this.CHBMiercoles = new System.Windows.Forms.CheckBox();
            this.CHBMartes = new System.Windows.Forms.CheckBox();
            this.CHBLunes = new System.Windows.Forms.CheckBox();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.TBHoras = new System.Windows.Forms.TextBox();
            this.LHoras = new System.Windows.Forms.Label();
            this.CBPersonal = new System.Windows.Forms.ComboBox();
            this.LPersonal = new System.Windows.Forms.Label();
            this.panelCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddTel
            // 
            this.lbAddTel.AutoSize = true;
            this.lbAddTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddTel.ForeColor = System.Drawing.Color.White;
            this.lbAddTel.Location = new System.Drawing.Point(328, 213);
            this.lbAddTel.Name = "lbAddTel";
            this.lbAddTel.Size = new System.Drawing.Size(0, 24);
            this.lbAddTel.TabIndex = 4;
            // 
            // panelCamion
            // 
            this.panelCamion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCamion.Controls.Add(this.label1);
            this.panelCamion.Location = new System.Drawing.Point(11, 11);
            this.panelCamion.Margin = new System.Windows.Forms.Padding(2);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(296, 39);
            this.panelCamion.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Añadir/Editar Horario Personal";
            // 
            // LHorario
            // 
            this.LHorario.AutoSize = true;
            this.LHorario.Location = new System.Drawing.Point(17, 100);
            this.LHorario.Name = "LHorario";
            this.LHorario.Size = new System.Drawing.Size(41, 13);
            this.LHorario.TabIndex = 32;
            this.LHorario.Text = "Horario";
            // 
            // CHBDomingo
            // 
            this.CHBDomingo.AutoSize = true;
            this.CHBDomingo.Location = new System.Drawing.Point(425, 128);
            this.CHBDomingo.Name = "CHBDomingo";
            this.CHBDomingo.Size = new System.Drawing.Size(68, 17);
            this.CHBDomingo.TabIndex = 31;
            this.CHBDomingo.Text = "Domingo";
            this.CHBDomingo.UseVisualStyleBackColor = true;
            // 
            // CHBSabado
            // 
            this.CHBSabado.AutoSize = true;
            this.CHBSabado.Location = new System.Drawing.Point(356, 128);
            this.CHBSabado.Name = "CHBSabado";
            this.CHBSabado.Size = new System.Drawing.Size(63, 17);
            this.CHBSabado.TabIndex = 30;
            this.CHBSabado.Text = "Sabado";
            this.CHBSabado.UseVisualStyleBackColor = true;
            // 
            // CHBViernes
            // 
            this.CHBViernes.AutoSize = true;
            this.CHBViernes.Location = new System.Drawing.Point(289, 128);
            this.CHBViernes.Name = "CHBViernes";
            this.CHBViernes.Size = new System.Drawing.Size(61, 17);
            this.CHBViernes.TabIndex = 29;
            this.CHBViernes.Text = "Viernes";
            this.CHBViernes.UseVisualStyleBackColor = true;
            // 
            // CHBJueves
            // 
            this.CHBJueves.AutoSize = true;
            this.CHBJueves.Location = new System.Drawing.Point(223, 128);
            this.CHBJueves.Name = "CHBJueves";
            this.CHBJueves.Size = new System.Drawing.Size(60, 17);
            this.CHBJueves.TabIndex = 28;
            this.CHBJueves.Text = "Jueves";
            this.CHBJueves.UseVisualStyleBackColor = true;
            // 
            // CHBMiercoles
            // 
            this.CHBMiercoles.AutoSize = true;
            this.CHBMiercoles.Location = new System.Drawing.Point(146, 128);
            this.CHBMiercoles.Name = "CHBMiercoles";
            this.CHBMiercoles.Size = new System.Drawing.Size(71, 17);
            this.CHBMiercoles.TabIndex = 27;
            this.CHBMiercoles.Text = "Miercoles";
            this.CHBMiercoles.UseVisualStyleBackColor = true;
            // 
            // CHBMartes
            // 
            this.CHBMartes.AutoSize = true;
            this.CHBMartes.Location = new System.Drawing.Point(82, 128);
            this.CHBMartes.Name = "CHBMartes";
            this.CHBMartes.Size = new System.Drawing.Size(58, 17);
            this.CHBMartes.TabIndex = 26;
            this.CHBMartes.Text = "Martes";
            this.CHBMartes.UseVisualStyleBackColor = true;
            // 
            // CHBLunes
            // 
            this.CHBLunes.AutoSize = true;
            this.CHBLunes.Location = new System.Drawing.Point(21, 128);
            this.CHBLunes.Name = "CHBLunes";
            this.CHBLunes.Size = new System.Drawing.Size(55, 17);
            this.CHBLunes.TabIndex = 25;
            this.CHBLunes.Text = "Lunes";
            this.CHBLunes.UseVisualStyleBackColor = true;
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.Location = new System.Drawing.Point(360, 181);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(75, 23);
            this.btn_Añadir.TabIndex = 24;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = true;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_Añadir_Click);
            // 
            // TBHoras
            // 
            this.TBHoras.Location = new System.Drawing.Point(72, 181);
            this.TBHoras.Name = "TBHoras";
            this.TBHoras.Size = new System.Drawing.Size(171, 20);
            this.TBHoras.TabIndex = 23;
            // 
            // LHoras
            // 
            this.LHoras.AutoSize = true;
            this.LHoras.Location = new System.Drawing.Point(18, 181);
            this.LHoras.Name = "LHoras";
            this.LHoras.Size = new System.Drawing.Size(35, 13);
            this.LHoras.TabIndex = 22;
            this.LHoras.Text = "Horas";
            // 
            // CBPersonal
            // 
            this.CBPersonal.FormattingEnabled = true;
            this.CBPersonal.Location = new System.Drawing.Point(72, 69);
            this.CBPersonal.Name = "CBPersonal";
            this.CBPersonal.Size = new System.Drawing.Size(180, 21);
            this.CBPersonal.TabIndex = 21;
            // 
            // LPersonal
            // 
            this.LPersonal.AutoSize = true;
            this.LPersonal.Location = new System.Drawing.Point(18, 72);
            this.LPersonal.Name = "LPersonal";
            this.LPersonal.Size = new System.Drawing.Size(48, 13);
            this.LPersonal.TabIndex = 20;
            this.LPersonal.Text = "Personal";
            // 
            // frmHorarioPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 242);
            this.Controls.Add(this.LHorario);
            this.Controls.Add(this.CHBDomingo);
            this.Controls.Add(this.CHBSabado);
            this.Controls.Add(this.CHBViernes);
            this.Controls.Add(this.CHBJueves);
            this.Controls.Add(this.CHBMiercoles);
            this.Controls.Add(this.CHBMartes);
            this.Controls.Add(this.CHBLunes);
            this.Controls.Add(this.btn_Añadir);
            this.Controls.Add(this.TBHoras);
            this.Controls.Add(this.LHoras);
            this.Controls.Add(this.CBPersonal);
            this.Controls.Add(this.LPersonal);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.lbAddTel);
            this.Name = "frmHorarioPersonal";
            this.Text = "frmHorarioPersonal";
            this.Load += new System.EventHandler(this.frmHorarioPersonal_Load);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddTel;
        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LHorario;
        private System.Windows.Forms.CheckBox CHBDomingo;
        private System.Windows.Forms.CheckBox CHBSabado;
        private System.Windows.Forms.CheckBox CHBViernes;
        private System.Windows.Forms.CheckBox CHBJueves;
        private System.Windows.Forms.CheckBox CHBMiercoles;
        private System.Windows.Forms.CheckBox CHBMartes;
        private System.Windows.Forms.CheckBox CHBLunes;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.TextBox TBHoras;
        private System.Windows.Forms.Label LHoras;
        private System.Windows.Forms.ComboBox CBPersonal;
        private System.Windows.Forms.Label LPersonal;
    }
}