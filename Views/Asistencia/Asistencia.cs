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
        List<cAsistencia> LisAsistencia;
        List<cPersonal> LisPersonal;
        string idPeAct;

        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            FillGrid();
            RecuperaPersonal();
            Btn_Añadir.Visible = false;
            Btn_Eliminar.Visible = false;
        }

        public void RecuperaPersonal()
        {
            LisPersonal = new List<cPersonal>();
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
                    p.contadorAsistencias = Convert.ToInt32(reader["contadorAsistencia"]);
                    p.cuentaBancaria = Convert.ToString(reader["cuenta"]);

                    LisPersonal.Add(p);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void FillGrid()
        {
            DGVAsistencia.Rows.Clear();
            LisAsistencia = new List<cAsistencia>();
            string query = @"SELECT * FROM PAQUETERIA.Asistencia E
                             JOIN PAQUETERIA.personal D
                             ON E.idPersonal = D.idPersonal";
            string queryPer = @"SELECT * FROM PAQUETERIA.personal";

            try
            {
                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                SqlDataReader readerPer = dB.DoQuery(queryPer);

                while (reader.Read())
                {

                    cAsistencia a = new cAsistencia();

                    a.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    a.horarioLlegada = Convert.ToString(reader["horarioLlegada"]);
                    a.horarioSalida = Convert.ToString(reader["horarioSalida"]);
                    a.fecha = Convert.ToString(reader["fecha"]).Split(' ')[0];
                    a.nombre = Convert.ToString(reader["nombre"]);


                    LisAsistencia.Add(a);
                }

                CBPersonal.Items.Clear();
                while (readerPer.Read())
                {
                    idPeAct = Convert.ToString(readerPer["idPersonal"]);

                    CBPersonal.Items.Add(Convert.ToString(readerPer["nss"]) + " " + Convert.ToString(readerPer["nombre"]));
                }

                foreach (var item in LisAsistencia)
                {
                    string[] row = new string[] { item.idPersonal.ToString()+ " - "+ item.nombre, item.horarioLlegada, item.horarioSalida, item.fecha };
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
            if (DGVAsistencia.SelectedRows.Count > 0 )
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

        private void BTLlegada_Click(object sender, EventArgs e)
        {            
            string fechaActual = DateTime.Now.Date.ToString();
            string query = string.Empty;
            int res = 0;

            double nssPSel =Convert.ToInt32(CBPersonal.Text.Split(' ')[0].ToString());           
            cPersonal pA = LisPersonal.Find(x => x.nss == nssPSel);


            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idPersonal", pA.idPersonal.ToString()),
                new DBParameter("@HorarioLlegada", DateTime.Now.ToString("hh:mm:ss")),                
            };
            try
            {
                query = "INSERT INTO PAQUETERIA.asistencia (idPersonal,horarioLlegada) VALUES (@idPersonal, @HorarioLlegada)";               
                DBIDisposable dB = new DBIDisposable();

                res = dB.UpdateQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FillGrid();
        }

        private void BTSalida_Click(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString();
            string query = string.Empty;
            int res = 0;

            double nssPSel = Convert.ToInt32(CBPersonal.Text.Split(' ')[0].ToString());
            cPersonal pA = LisPersonal.Find(x => x.nss == nssPSel);

            for(int i =0; i < DGVAsistencia.Rows.Count-1;i++)
            {
                if(DGVAsistencia.Rows[i].Cells["Id_Personal"].Value.ToString().Split(' ')[0].ToString() == pA.idPersonal.ToString() && DGVAsistencia.Rows[i].Cells["HorarioSalida"].Value.ToString() == "" && DGVAsistencia.Rows[i].Cells["Fecha"].Value.ToString() == DateTime.Now.Date.ToString().Split(' ')[0])
                {
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idPersonal", pA.idPersonal.ToString()),
                        new DBParameter("@HorarioLlegada", DGVAsistencia.Rows[i].Cells["HorarioLlegada"].Value.ToString()),
                        new DBParameter("@HorarioSalida", DateTime.Now.ToString("hh:mm:ss"))
                    };
                    try
                    {
                        query = "UPDATE PAQUETERIA.asistencia SET horarioLlegada = @HorarioLlegada, horarioSalida = @HorarioSalida  WHERE idPersonal = @idPersonal AND horarioSalida IS NULL";
                        DBIDisposable dB = new DBIDisposable();

                        res = dB.UpdateQuery(query, parameters);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }

            FillGrid();
        }
    }
}
