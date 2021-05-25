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

namespace ProyectoABD.Views.AsignacionDeRuta
{
    public partial class AsignacionDeRuta : Form
    {
        private bool cargaDatos = false;
        private int idAsignacionRuta;
        private int idRuta;
        private int idPersonal;
        private string fechaFin;

        public AsignacionDeRuta()
        {
            InitializeComponent();
        }

        public AsignacionDeRuta(int idAsignacionRuta, int idRuta, int idPersonal, string fechaFin)
        {
            InitializeComponent();

            cargaDatos = true;
            this.idAsignacionRuta = idAsignacionRuta;
            this.idRuta = idRuta;
            this.idPersonal = idPersonal;
            this.fechaFin = fechaFin;
        }

        private void BtnAgregarRuta_Click(object sender, EventArgs e)
        {
            cPersonal cpersonal = cmbPersonal.SelectedItem as cPersonal;
            cRuta cruta = cmbRuta1.SelectedItem as cRuta;
            // cmbRuta.SelectedItem
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFinal = dtFechaFin.Value;
            bool bInsertUpdate = false;
            if (cargaDatos == false)
            {
                bInsertUpdate = InsertarRuta(cruta.idRuta, cpersonal.idPersonal, fechaInicio, fechaFinal);
                
            }
            else
            {
                bInsertUpdate = UpdateRuta(this.idAsignacionRuta, this.idRuta, cpersonal.idPersonal, fechaInicio, fechaFinal);
            }

            if (bInsertUpdate)
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                DialogResult = DialogResult.Abort;
            }

            this.Close();
        }

        private bool InsertarRuta(int idRuta, double idPersonal, DateTime fechaInicio, DateTime fechaFin)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idPersonal",  idPersonal),
                new DBParameter("@idRuta", idRuta),
                new DBParameter("@fechaInicio", fechaInicio),
                new DBParameter("@fechaFin", fechaFin)               

            };

            string query = @"INSERT INTO PAQUETERIA.asignacionDeRutas(idRuta, idPersonal, fechaInicio, fechaFin)
                             VALUES(@idRuta, @idPersonal, @fechaInicio, @fechaFin)";
            DB dB = new DB();
            int res = dB.UpdateQuery(query, parameters);
            if(res <= 0)
            {
                MessageBox.Show("Ha ocurrido un error al insertar asignacion de rutas");
                return false;
            }

            return true;
        }

        private bool UpdateRuta(int idAsignacionRuta, int idRuta, double idPersonal, DateTime fechaInicio, DateTime fechaFin)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idAsignacionRuta",  idAsignacionRuta),
                new DBParameter("@idPersonal",  idPersonal),
                new DBParameter("@idRuta", idRuta),
                new DBParameter("@fechaInicio", fechaInicio),
                new DBParameter("@fechaFin", fechaFin)

            };

            string query = @"UPDATE PAQUETERIA.asignacionDeRutas SET idRuta = @idRuta, idPersonal = @idPersonal, fechaInicio = @fechaInicio, fechaFin = @fechaFin WHERE idAsignacionRuta = @idAsignacionRuta";
            DB dB = new DB();
            int res = dB.UpdateQuery(query, parameters);
            if (res <= 0)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar asignacion de rutas");
                return false;
            }

            return true;
        }

        private void AsignacionDeRuta_Load(object sender, EventArgs e)
        {
            List<cPersonal> lstPersonal = GetListPersonal();
            if (lstPersonal.Count == 0)
            {
                MessageBox.Show("No hay registros de personal");
            }
            else
            {
                cmbPersonal.SelectedText = "nombre";
                cmbPersonal.SelectedValue = "idPersonal";         

                for (int i = 0; i < lstPersonal.Count; i++)
                {
                    string text = lstPersonal[i].idPersonal + " " + lstPersonal[i].nombre;
                    lstPersonal[i].nombre = text;
                    cmbPersonal.Items.Add(lstPersonal[i]);
                }

                cmbPersonal.Text = "";
            }

            List<cRuta> lstRuta = GetListRuta();
            if (lstRuta.Count == 0)
            {
                MessageBox.Show("No hay registros de ruta");
            }
            else
            {
                cmbRuta1.SelectedText = "nombreRuta";
                cmbRuta1.SelectedValue = "idRuta";

                for (int i = 0; i < lstRuta.Count; i++)
                {
                    string text = lstRuta[i].idRuta + " " + lstRuta[i].nombreRuta;
                    lstRuta[i].nombreRuta = text;
                    cmbRuta1.Items.Add(lstRuta[i]);
                }

                cmbRuta1.Text = "";
            }

            if (cargaDatos)
            {
                for (int i = 0; i < cmbPersonal.Items.Count; i++)
                {
                    cPersonal item = cmbPersonal.Items[i] as cPersonal;
                    if (item.idPersonal == this.idPersonal)
                    {
                        cmbPersonal.SelectedItem = item;
                    }
                }

                for (int i = 0; i < cmbRuta1.Items.Count; i++)
                {
                    cRuta item = cmbRuta1.Items[i] as cRuta;
                    if (item.idRuta == this.idRuta)
                    {
                        cmbRuta1.SelectedItem = item;
                    }
                }

                this.dtFechaFin.Value = DateTime.Parse(this.fechaFin);
                btnAgregarRuta.Text = "Actualizar";
                lblTitulo.Text = "Actualizar Ruta";
            }
        }

        public List<cPersonal> GetListPersonal()
        {
            List<cPersonal> LisPersonal = new List<cPersonal>();
            string query = @"SELECT * FROM PAQUETERIA.personal WHERE tipoEmpleado = 'Camionero'";

            try
            {
                DB dB = new DB();
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return LisPersonal;
        }

        public List<cRuta> GetListRuta()
        {
            List<cRuta> ListRuta = new List<cRuta>();
            string query = @"SELECT R.*, SO.direccion + ' - ' + SD.direccion AS nombreRuta
                          FROM PAQUETERIA.ruta R
                          INNER JOIN PAQUETERIA.sucursal SO ON SO.idSucursal = R.idSucursalOrigen
                          INNER JOIN PAQUETERIA.sucursal SD ON SD.idSucursal = R.idSucursalDestino";

            try
            {
                DB dB = new DB();
                SqlDataReader reader = dB.DoQuery(query);

                while (reader.Read())
                {
                    cRuta p = new cRuta();
                    p.idRuta = Convert.ToInt32(reader["idRuta"]);
                    p.idCamion = Convert.ToInt32(reader["idCamion"]);
                    p.idSucursalDestino = Convert.ToInt32(reader["idSucursalDestino"]);
                    p.idSucursalOrigen = Convert.ToInt32(reader["idSucursalOrigen"]);
                    p.horario = Convert.ToString(reader["horario"]);
                    p.nombreRuta = Convert.ToString(reader["nombreRuta"]);

                    ListRuta.Add(p);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ListRuta;
        }
    }
}
