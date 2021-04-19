using ProyectoABD.Models;
using ProyectpABD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoABD.Views.Telefono
{
    public partial class Telefono : Form
    {
        public Telefono()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            frmTelefono ft = new frmTelefono(0,0,"");
            ft.Text = "+ Teléfono";
            if (ft.ShowDialog() == DialogResult.OK)
            {
                FillGridTelefonos();
            }
        }

        public void FillGridTelefonos()
        {
            gridTelefonos.Rows.Clear();
            List<cTelefono> telefonos = new List<cTelefono>();
            string query = @"SELECT * FROM PAQUETERIA.telefono INNER JOIN PAQUETERIA.sucursal ON PAQUETERIA.telefono.idSucursal = PAQUETERIA.sucursal.idSucursal ";
            try
            {
                DB dB = new DB();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cTelefono t = new cTelefono();
                    t.idTelefono = Convert.ToInt32(reader["idTelefono"]);
                    t.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                    t.telefono = Convert.ToString(reader["telefono"]);
                    t.nombre = Convert.ToString(reader["nombre"]);
                    telefonos.Add(t);
                }
                foreach (var item in telefonos)
                {
                    string[] row = new string[] { item.idTelefono.ToString(), item.idSucursal.ToString(), item.nombre.ToString(), item.telefono.ToString(), };
                    gridTelefonos.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            FillGridTelefonos();
        }

        private void gridTelefonos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTelefono = Convert.ToInt32(gridTelefonos.Rows[e.RowIndex].Cells["idTelefono"].Value);
            int idSucursal = Convert.ToInt32(gridTelefonos.Rows[e.RowIndex].Cells["idSucursal"].Value);
            string telefono = Convert.ToString(gridTelefonos.Rows[e.RowIndex].Cells["numTelefono"].Value);
            frmTelefono ft = new frmTelefono(idTelefono, idSucursal, telefono);
            ft.Text = "Modificar sucursal";
            if (ft.ShowDialog() == DialogResult.OK)
            {
                FillGridTelefonos();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (gridTelefonos.SelectedRows.Count > 0)
            {
                try
                {
                    int res = 0;
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idTelefono", Convert.ToInt32(gridTelefonos.SelectedRows[0].Cells[0].Value)),
                        new DBParameter("@telefono", Convert.ToInt32(gridTelefonos.SelectedRows[0].Cells[1].Value))
                    };
                    string query = "DELETE FROM PAQUETERIA.telefono WHERE idTelefono = @idTelefono";
                    DB dB = new DB();

                    res = dB.UpdateQuery(query, parameters);

                    if (res > 0)
                    {
                        FillGridTelefonos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
