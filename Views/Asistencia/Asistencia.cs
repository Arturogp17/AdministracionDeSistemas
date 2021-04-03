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

namespace ProyectoABD.Views.Asistencia
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            DGVAsistencia.Rows.Clear();
            List<cAsistencia> LisAsistencia = new List<cAsistencia>();
            string query = @"SELECT * FROM PAQUETERIA.Asistencia";

            try
            {

                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {

                    cAsistencia a = new cAsistencia();

                    a.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    a.horarioLlegada = Convert.ToString(reader["horarioLlegada"]);
                    a.horarioSalida = Convert.ToString(reader["horarioSalida"]);
                    a.fecha = Convert.ToString(reader["fecha"]).Split(' ')[0];

                    LisAsistencia.Add(a);

                }
                foreach (var item in LisAsistencia)
                {
                    string[] row = new string[] { item.idPersonal.ToString(), item.horarioLlegada, item.horarioSalida, item.fecha };
                    DGVAsistencia.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Añadir_Click(object sender, EventArgs e)
        {
            frmAsistencia fa = new frmAsistencia();
            fa.Text = "Añadir nuevo personal";
            if (fa.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (DGVAsistencia.SelectedRows.Count > 0)
            {
                try
                {
                    int res = 0;
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idPersonal", Convert.ToInt32(DGVAsistencia.SelectedRows[0].Cells[0].Value))
                    };
                    string query = "DELETE FROM PAQUETERIA.asistencia WHERE idPersonal = @idPersonal";
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

        private void DGVAsistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double idPersonal = Convert.ToInt32(DGVAsistencia.Rows[e.RowIndex].Cells["Id_Personal"].Value);
            string HorarioLlegada = Convert.ToString(DGVAsistencia.Rows[e.RowIndex].Cells["HorarioLlegada"].Value);
            string HorarioSalida = Convert.ToString(DGVAsistencia.Rows[e.RowIndex].Cells["HorarioSalida"].Value);


            frmAsistencia fp = new frmAsistencia(idPersonal, HorarioLlegada, HorarioSalida);
            fp.Text = "Modificar sucursal";
            if (fp.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }
    }
}
