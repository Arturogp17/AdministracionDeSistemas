using ProyectoABD.Properties;
using ProyectoABD.Views.AsignacionDeRuta;
using ProyectoABD.Views.Asistencia;
using ProyectoABD.Views.Camion;
using ProyectoABD.Views.Home;
using ProyectoABD.Views.HorarioPersonal;
using ProyectoABD.Views.Pago;
using ProyectoABD.Views.Personal;
using ProyectoABD.Views.Ruta;
using ProyectoABD.Views.Sucursal;
using ProyectoABD.Views.Telefono;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectpABD
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            Home();
        }

        public void Home()
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Home fDashboard = new Home(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Sucursal fDashboard = new Sucursal(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Width == 250)
            {
                pnlLeft.Width = 55;
                btnSlide.Image = Resources.arrow_right;
            }
            else
            {
                pnlLeft.Width = 250;
                btnSlide.Image = Resources.arrow_left;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
            Application.Exit();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Personal(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Personal fDashboard = new Personal(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void btTelefonos_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Telefono fDashboard = new Telefono(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void btCamiones_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Camion fDashboard = new Camion(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();

        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Home fDashboard = new Home(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btHorarioPersonal_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            HorarioPersonal fDashboard = new HorarioPersonal(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void btAsistencia_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Asistencia fDashboard = new Asistencia(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void BtAsignacion_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            RutasAsignadas fDashboard = new RutasAsignadas(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmRutasAsignadas";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void btRutas_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Ruta fDashboard = new Ruta(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }
        
        private void btPago_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  //Limpia el contenedo
            Pago fDashboard = new Pago(); //Crea la nueva forma a asignar
            fDashboard.Name = "frmAdmin";
            fDashboard.TopLevel = false;
            fDashboard.AutoScroll = true;
            pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
            fDashboard.FormBorderStyle = FormBorderStyle.None;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }
    }
}
