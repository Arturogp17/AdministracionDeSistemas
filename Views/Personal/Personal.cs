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
using ProyectoABD.Models;

namespace ProyectoABD.Views.Personal
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            DGVPersonal.Rows.Clear();
            List<cPersonal> LisPersonal = new List<cPersonal>();
            string query = @"SELECT * FROM PAQUETERIA.personal";

            try
            {

                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {

                    cPersonal p = new cPersonal();

                    p.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    p.nss = Convert.ToInt32(reader["nss"]);
                    p.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                    p.nombre = Convert.ToString(reader["nombre"]);
                    p.numeroCelular = Convert.ToString(reader["numeroCelular"]);
                    p.edad = Convert.ToInt32(reader["edad"]);
                    p.fechaNacimiento = Convert.ToString(reader["fechaNacimiento"]);
                    p.direccion = Convert.ToString(reader["direccion"]);
                    p.email = Convert.ToString(reader["email"]);
                    p.tipoEmpleado = Convert.ToString(reader["tipoEmpleado"]);
                    p.salario = Convert.ToInt32(reader["salario"]);

                    LisPersonal.Add(p);

                }
                foreach (var item in LisPersonal)
                {
                    string[] row = new string[] { item.idPersonal.ToString(), item.nss.ToString(), item.idSucursal.ToString(), item.nombre, item.numeroCelular, item.edad.ToString(), item.fechaNacimiento, item.direccion, item.email, item.tipoEmpleado, item.salario.ToString() };
                    DGVPersonal.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_FormAñadir_Click(object sender, EventArgs e)
        {
            frmPersonal fp = new frmPersonal();
            fp.Text = "Añadir nuevo personal";
            if (fp.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void DGVPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double idPersonal = Convert.ToInt32(DGVPersonal.Rows[e.RowIndex].Cells["idPersonal"].Value);
            double nss = Convert.ToInt32(DGVPersonal.Rows[e.RowIndex].Cells["nss"].Value);
            double idSucursal = Convert.ToInt32(DGVPersonal.Rows[e.RowIndex].Cells["idSucursal"].Value);
            string nombre = Convert.ToString(DGVPersonal.Rows[e.RowIndex].Cells["nombre"].Value);
            string numeroCelular = Convert.ToString(DGVPersonal.Rows[e.RowIndex].Cells["numeroCelular"].Value);
            int edad = Convert.ToInt32(DGVPersonal.Rows[e.RowIndex].Cells["edad"].Value);
            string fechaNacimiento = Convert.ToString(DGVPersonal.Rows[e.RowIndex].Cells["fechaNacimiento"].Value);
            string direccion = Convert.ToString(DGVPersonal.Rows[e.RowIndex].Cells["direccion"].Value);
            string email = Convert.ToString(DGVPersonal.Rows[e.RowIndex].Cells["email"].Value);
            string tipoEmpleado = Convert.ToString(DGVPersonal.Rows[e.RowIndex].Cells["tipoEmpleado"].Value);
            double salario = Convert.ToInt32(DGVPersonal.Rows[e.RowIndex].Cells["Salario"].Value);

            frmPersonal fp = new frmPersonal(idPersonal, nss, idSucursal, nombre, numeroCelular, edad, fechaNacimiento, direccion, email, tipoEmpleado, salario);
            fp.Text = "Modificar sucursal";
            if (fp.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (DGVPersonal.SelectedRows.Count > 0)
            {
                try
                {
                    int res = 0;
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idPersonal", Convert.ToInt32(DGVPersonal.SelectedRows[0].Cells[0].Value))
                    };
                    string query = "DELETE FROM PAQUETERIA.personal WHERE idPersonal = @idPersonal";
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
    }
}
