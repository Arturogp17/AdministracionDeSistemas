using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoABD.Views.Camion
{
    public partial class Camion : Form
    {
        public Camion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCamion f = new frmCamion();
            f.ShowDialog();
            f.Dispose();
        }

        private void BtAñadirCamion_Click(object sender, EventArgs e)
        {

        }
    }
}
