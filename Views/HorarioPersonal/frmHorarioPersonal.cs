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
    public partial class frmHorarioPersonal : Form
    {
        private double idPersonal = 0;
        List<cPersonal> personales;
        private string Horas;
        private string Horario;

        public frmHorarioPersonal(double idP = 0, string _Hor = "", string _Horarios = "")
        {
            InitializeComponent();
            idPersonal = idP;
            Horas = _Hor;
            Horario = _Horarios;

        }

        private void frmHorarioPersonal_Load(object sender, EventArgs e)
        {
            List<cHorarioPersonal> LisHoraPers = new List<cHorarioPersonal>();
            personales = new List<cPersonal>();

            string query = @"SELECT * FROM PAQUETERIA.horarioPersonal";
            string querySuc = @"SELECT * FROM PAQUETERIA.personal";


            try
            {
                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {

                    cHorarioPersonal hp = new cHorarioPersonal();

                    hp.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    hp.Horas = Convert.ToString(reader["Horas"]);
                    hp.Horario = Convert.ToString(reader["Horario"]);

                    LisHoraPers.Add(hp);

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


                if (idPersonal > 0)//Editar y tener que recargar valores
                {
                    CBPersonal.Enabled = false;
                    TBHoras.Text = Horas;
                    ChequeaBoxHorario(Horario);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            int res = 0;
            double indPer;
            int r = 0;

            if (idPersonal == 0)
                indPer = personales.Find(x => x.nss == Convert.ToInt32(CBPersonal.Text.Split(' ')[0])).idPersonal;
            else
                indPer = idPersonal;

            string diasHorario = ObtenHorarios();

            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idPersonal", indPer),
                new DBParameter("@Horas", TBHoras.Text),
                new DBParameter("@Horario", diasHorario),
            };
            try
            {
                if (idPersonal > 0)
                {
                    parameters.Add(new DBParameter("@idPersonalMod", idPersonal));
                    query = "UPDATE PAQUETERIA.horarioPersonal SET Horas = @Horas, Horario = @Horario  WHERE idPersonal = @idPersonalMod";
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.horarioPersonal (idPersonal,Horas,Horario) VALUES (@idPersonal, @Horas,@Horario)";
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

        public string ObtenHorarios()
        {
            string horarios = "";

            if (CHBLunes.Checked)
            {
                horarios += "Lunes,";
            }

            if (CHBMartes.Checked)
            {
                horarios += "Martes,";
            }

            if (CHBMiercoles.Checked)
            {
                horarios += "Miercoles,";
            }

            if (CHBJueves.Checked)
            {
                horarios += "Jueves,";
            }

            if (CHBViernes.Checked)
            {
                horarios += "Viernes,";
            }

            if (CHBSabado.Checked)
            {
                horarios += "Sabado,";
            }

            if (CHBDomingo.Checked)
            {
                horarios += "Domingo,";
            }

            return horarios;
        }

        public void ChequeaBoxHorario(string _Horari)
        {
            int i = 0;
            string cadTem = "";

            while (i < _Horari.Length)
            {
                cadTem += _Horari[i];

                switch (cadTem)
                {
                    case "Lu":
                        CHBLunes.Checked = true;
                        cadTem = "";
                        i += 4;
                        break;
                    case "Ma":
                        CHBMartes.Checked = true;
                        cadTem = "";
                        i += 5;
                        break;
                    case "Mi":
                        CHBMiercoles.Checked = true;
                        cadTem = "";
                        i += 8;
                        break;
                    case "Ju":
                        CHBJueves.Checked = true;
                        cadTem = "";
                        i += 5;
                        break;
                    case "Vi":
                        CHBViernes.Checked = true;
                        cadTem = "";
                        i += 6;
                        break;
                    case "Sa":
                        CHBSabado.Checked = true;
                        cadTem = "";
                        i += 5;
                        break;
                    case "Do":
                        CHBDomingo.Checked = true;
                        cadTem = "";
                        i += 6;
                        break;

                }
                i++;
            }

        }
    }
}
