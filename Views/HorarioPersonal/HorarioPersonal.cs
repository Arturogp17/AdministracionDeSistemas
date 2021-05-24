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

namespace ProyectoABD.Views.HorarioPersonal
{
    public partial class HorarioPersonal : Form
    {
        public HorarioPersonal()
        {
            InitializeComponent();
        }

        private void HorarioPersonal_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            DGVHorarioPersonal.Rows.Clear();
            List<cHorarioPersonal> LisHoraPers = new List<cHorarioPersonal>();
            string query = @"SELECT * FROM PAQUETERIA.horarioPersonal E
                             JOIN PAQUETERIA.personal D
                             ON E.idPersonal = D.idPersonal";

            try
            {
                DB dB = new DB();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {

                    cHorarioPersonal hp = new cHorarioPersonal();

                    hp.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    hp.Horas = Convert.ToString(reader["Horas"]);
                    hp.Horario = Convert.ToString(reader["Horario"]);
                    hp.NombrePersonal = Convert.ToString(reader["nombre"]);

                    LisHoraPers.Add(hp);

                }
                foreach (var item in LisHoraPers)
                {
                    string[] row = new string[] { item.idPersonal.ToString() + " - "+ item.NombrePersonal, item.Horas, item.Horario };
                    DGVHorarioPersonal.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Añadir_Click(object sender, EventArgs e)
        {
            frmHorarioPersonal fp = new frmHorarioPersonal();
            fp.Text = "Añadir nuevo personal";
            if (fp.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (DGVHorarioPersonal.SelectedRows.Count > 0)
            {
                try
                {
                    int res = 0;
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idPersonal", Convert.ToInt32(DGVHorarioPersonal.SelectedRows[0].Cells[0].Value.ToString().Split(' ')[0].ToString()))
                    };
                    string query = "DELETE FROM PAQUETERIA.horarioPersonal WHERE idPersonal = @idPersonal";
                    DB dB = new DB();

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

        private void DGVHorarioPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            double idPersonal = Convert.ToInt32(DGVHorarioPersonal.Rows[e.RowIndex].Cells["Id_Personal"].Value.ToString().Split(' ')[0].ToString());
            string Horas = Convert.ToString(DGVHorarioPersonal.Rows[e.RowIndex].Cells["Horas"].Value);
            string Horario = Convert.ToString(DGVHorarioPersonal.Rows[e.RowIndex].Cells["Horario"].Value);


            frmHorarioPersonal fp = new frmHorarioPersonal(idPersonal, Horas, Horario);
            fp.Text = "Modificar sucursal";
            if (fp.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }
    }
}
