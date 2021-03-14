using ProyectoABD.Properties;
using ProyectoABD.Views.Camion;
using ProyectoABD.Views.Sucursal;
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
    }
}
