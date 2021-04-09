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
    public partial class frmAsistencia : Form
    {
        private double idPersonal = 0;
        List<cPersonal> personales;
        private string HoraLlegada;
        private string HoraSalida;

        public frmAsistencia(double _idPersonal = 0, string horLl = "", string horSa = "")
        {
            InitializeComponent();
            idPersonal = _idPersonal;
            HoraLlegada = horLl;
            HoraSalida = horSa;

        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            List<cAsistencia> LisAsis = new List<cAsistencia>();
            personales = new List<cPersonal>();

            string query = @"SELECT * FROM PAQUETERIA.asistencia";
            string querySuc = @"SELECT * FROM PAQUETERIA.personal";


            try
            {
                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cAsistencia asi = new cAsistencia();

                    asi.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    asi.horarioLlegada = Convert.ToString(reader["HorarioLlegada"]);
                    asi.horarioSalida = Convert.ToString(reader["HorarioSalida"]);
                    asi.fecha = Convert.ToString(reader["fecha"]);

                    LisAsis.Add(asi);
                }

                SqlDataReader readerSuc = dB.DoQuery(querySuc);
                while (readerSuc.Read())
                {
                    cPersonal p = new cPersonal();

                    p.idPersonal = Convert.ToInt32(readerSuc["idPersonal"]);
                    p.nss = Convert.ToInt32(readerSuc["nss"]);
                    p.idSucursal = Convert.ToInt32(readerSuc["idSucursal"]);
                    p.nombre = Convert.ToString(readerSuc["nombre"]);
                    p.numeroCelular = Convert.ToString(readerSuc["numeroCelular"]);
                    p.edad = Convert.ToInt32(readerSuc["edad"]);
                    p.fechaNacimiento = Convert.ToString(readerSuc["fechaNacimiento"]);
                    p.direccion = Convert.ToString(readerSuc["direccion"]);
                    p.email = Convert.ToString(readerSuc["email"]);
                    p.tipoEmpleado = Convert.ToString(readerSuc["tipoEmpleado"]);
                    p.salario = Convert.ToInt32(readerSuc["salario"]);

                    personales.Add(p);
                }

                CBPersonal.Items.Clear();
                foreach (cPersonal a in personales)
                {
                    CBPersonal.Items.Add(a.nss + " " + a.nombre);
                }

                //TextBox.ReadOnly = true;
                if (idPersonal > 0)//Editar y tener que recargar valores
                {
                    CBPersonal.Enabled = false;
                    TBHoraLlegada.Text = HoraLlegada;
                    TBHoraLlegada.ReadOnly = true;
                    TBHoraSalida.ReadOnly = true;
                    TBHoraSalida.Text = HoraSalida;

                    Btn_Agregar.Visible = true;
                }
                else
                {
                    TBHoraSalida.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            int res = 0;
            double indPer;
            int r = 0;

            if (idPersonal == 0)
                indPer = personales.Find(x => x.nss == Convert.ToInt32(CBPersonal.Text.Split(' ')[0])).idPersonal;
            else
                indPer = idPersonal;


            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idPersonal", indPer),
                new DBParameter("@HorarioLlegada", TBHoraLlegada.Text),
                new DBParameter("@HorarioSalida", TBHoraSalida.Text),
            };
            try
            {
                if (idPersonal > 0)
                {
                    parameters.Add(new DBParameter("@idPersonalMod", idPersonal));
                    query = "UPDATE PAQUETERIA.asistencia SET horarioLlegada = @HorarioLlegada, horarioSalida = @HorarioSalida  WHERE idPersonal = @idPersonalMod";
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.asistencia (idPersonal,horarioLlegada) VALUES (@idPersonal, @HorarioLlegada)";
                }
                DBIDisposable dB = new DBIDisposable();

                res = dB.UpdateQuery(query, parameters);

                if (res > 0)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
