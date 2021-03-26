using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoABD.Models;
using ProyectpABD.Models;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoABD.Views.Sucursal
{
    public partial class Sucursal : Form
    {
        public Sucursal()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            gridSucursales.Rows.Clear();
            List<cSucursal> sucursales = new List<cSucursal>();
            string query = @"SELECT * FROM PAQUETERIA.sucursal";
            try
            {
                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cSucursal s = new cSucursal();
                    s.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                    s.nombre = Convert.ToString(reader["nombre"]);
                    s.direccion = Convert.ToString(reader["direccion"]);
                    sucursales.Add(s);
                }
                foreach (var item in sucursales)
                {
                    string[] row = new string[] { item.idSucursal.ToString(), item.nombre.ToString(), item.direccion.ToString(), };
                    gridSucursales.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sucursal_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btAñadirSucursal_Click(object sender, EventArgs e)
        {
            frmSucursal fs = new frmSucursal();
            fs.Text = "Añadir nueva sucursal";
            if (fs.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(gridSucursales.SelectedRows.Count > 0)
            {    
                try
                {
                    int res = 0;
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idSucursal", Convert.ToInt32(gridSucursales.SelectedRows[0].Cells[0].Value))
                    };
                    string query = "DELETE FROM PAQUETERIA.sucursal WHERE idSucursal = @idSucursal";
                    DBIDisposable dB = new DBIDisposable();
                    
                    res = dB.UpdateQuery(query, parameters);
                    
                    if (res > 0)
                    {
                        FillGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gridSucursales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSucursal = Convert.ToInt32(gridSucursales.Rows[e.RowIndex].Cells["idSucursal"].Value);
            string nombre = Convert.ToString(gridSucursales.Rows[e.RowIndex].Cells["nombre"].Value);
            string direccion = Convert.ToString(gridSucursales.Rows[e.RowIndex].Cells["direccion"].Value);
            frmSucursal fs = new frmSucursal(idSucursal, nombre, direccion);
            fs.Text = "Modificar sucursal";
            if(fs.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void gridSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                /*
                frmDashBoard fDashboard = new Sucursal();
                MessageBox.Show("Hola");
                pnlContainer.Controls.Clear();  //Limpia el contenedo
                Sucursal fDashboard = new Sucursal(); //Crea la nueva forma a asignar
                fDashboard.Name = "frmAdmin";
                fDashboard.TopLevel = false;
                fDashboard.AutoScroll = true;
                pnlContainer.Controls.Add(fDashboard); //Agrega la forma al panel
                fDashboard.FormBorderStyle = FormBorderStyle.None;
                fDashboard.Dock = DockStyle.Fill;
                fDashboard.Show();*/
            }
        }
    }
}
