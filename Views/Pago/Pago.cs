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

namespace ProyectoABD.Views.Pago
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {   
            try
            {
                if(DateTime.Now.Day > 15)
                {
                    dpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 16);
                    dpFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                }
                else
                {
                    dpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    dpFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
                }
                List<cSucursal> sucursales = new List<cSucursal>();
                string query = @"SELECT * FROM PAQUETERIA.sucursal";
                using (DB dB = new DB())
                {
                    using (SqlDataReader reader = dB.DoQuery(query))
                    {
                        while (reader.Read())
                        {
                            cSucursal sucursal = new cSucursal();
                            sucursal.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                            sucursal.nombre = Convert.ToString(reader["nombre"]);
                            sucursales.Add(sucursal);
                        }
                    }
                }
                ddlSucursal.DataSource = sucursales;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshGrid(int idSuc)
        {
            try
            {
                string query = @"SELECT T0.idPersonal, T0.nombre, nss, cuenta, T1.nombre, T0.salario,
                                        (select count(idPersonal) from PAQUETERIA.asistencia WHERE @inicioFecha <= fecha AND fecha <= @finFecha) contadorAsistencia
                                        FROM PAQUETERIA.personal T0
                                        JOIN PAQUETERIA.sucursal T1 ON T1.idSucursal = T0.idSucursal 
                                        where T0.idSucursal = @idSucursal 
                                        AND (SELECT COUNT(idPago) from PAQUETERIA.pago pago WHERE pago.idPersonal = T0.idPersonal AND fechaFinPeriodo =  @finFecha) = 0";
                List<DBParameter> parameters = new List<DBParameter>
                {
                    new DBParameter("@idSucursal", idSuc),
                    new DBParameter("@inicioFecha", dpInicio.Value),
                    new DBParameter("@finFecha", dpFin.Value),
                };
                List<cPago> pagos = new List<cPago>();
                using (DB dB = new DB())
                {
                    using (SqlDataReader reader = dB.DoQuery(query, parameters))
                    {
                        while (reader.Read())
                        {
                            cPago c = new cPago();
                            c.nombre = Convert.ToString(reader["nombre"]);
                            c.NSS = Convert.ToString(reader["nss"]);
                            c.cuenta = Convert.ToString(reader["cuenta"]);
                            c.diastrabajados = Convert.ToInt32(reader["contadorAsistencia"]);
                            c.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                            c.salario = Convert.ToDouble(reader["salario"]);
                            pagos.Add(c);
                        }
                    }
                }
                gridPagos.Rows.Clear();
                foreach (var item in pagos)
                {
                    int rowIndex = gridPagos.Rows.Add();
                    DataGridViewRow dr = gridPagos.Rows[rowIndex];
                    dr.Cells[0].Value = item.idPersonal;
                    dr.Cells[1].Value = item.nombre;
                    dr.Cells[2].Value = item.NSS;
                    dr.Cells[3].Value = item.cuenta;
                    dr.Cells[4].Value = item.diastrabajados;
                    dr.Cells[5].Value = item.salario;
                    dr.Cells[6].Value = item.salario / 30 * item.diastrabajados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlSucursal.SelectedValue != null)
            {
                RefreshGrid((int)ddlSucursal.SelectedValue);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridPagos.RowCount; i++)
            {
                cPago p = new cPago();
                p.idPersonal = Convert.ToInt32(gridPagos.Rows[i].Cells[0].Value);
                p.idSucursal = Convert.ToInt32(ddlSucursal.SelectedValue);
                p.monto = Convert.ToDouble(gridPagos.Rows[i].Cells[6].Value);
                p.asistencias = Convert.ToInt32(gridPagos.Rows[i].Cells[4].Value);
                p.inicioPeriodo = dpInicio.Value;
                p.finPeriodo = dpFin.Value;
                GenerarPago(p);
            }
            RefreshGrid((int)ddlSucursal.SelectedValue);
        }

        private void GenerarPago(cPago pago)
        {
            try
            {
                string query = @"INSERT INTO PAQUETERIA.pago VALUES (@idSucursal, @idPersonal, @monto, @asistencias, @fechaInicio, @fechaFin)";
                List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idSucursal", pago.idSucursal),
                new DBParameter("@idPersonal", pago.idPersonal),
                new DBParameter("@monto", pago.monto),
                new DBParameter("@asistencias", pago.asistencias),
                new DBParameter("@fechaInicio", dpInicio.Value),
                new DBParameter("@fechaFin", dpFin.Value),

            };
                List<cPago> pagos = new List<cPago>();
                using (DB dB = new DB())
                {
                    dB.UpdateQuery(query, parameters);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
