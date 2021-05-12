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
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            
            try
            {
                string query = @"select idPago, T1.idSucursal as SucursalID, t1.nombre as nombreSucursal, T2.idPersonal as personalID, 
                                t2.nombre as nombrePersonal, monto, asistencias, fechaInicioPeriodo, fechaFinPeriodo
                                from PAQUETERIA.pago T0
                                Join PAQUETERIA.sucursal T1 on T1.idSucursal = T0.idSucursal
                                JOIN PAQUETERIA.personal T2 ON T2.idPersonal = T0.idPersonal";
                
                List<cPago> pagos = new List<cPago>();
                using (DB dB = new DB())
                {
                    using (SqlDataReader reader = dB.DoQuery(query))
                    {
                        while (reader.Read())
                        {
                            cPago c = new cPago();
                            c.idPago = Convert.ToInt32(reader["idPago"]);
                            c.nombre = Convert.ToString(reader["personalID"]) + "-" + Convert.ToString(reader["nombrePersonal"]);
                            c.diastrabajados = Convert.ToInt32(reader["asistencias"]);
                            c.Sucursal = Convert.ToString(reader["SucursalID"]) + "-" + Convert.ToString(reader["nombreSucursal"]);
                            c.monto = Convert.ToDouble(reader["monto"]);
                            c.inicioPeriodo = Convert.ToDateTime(reader["fechaInicioPeriodo"]);
                            c.finPeriodo = Convert.ToDateTime(reader["fechaFinPeriodo"]);
                            pagos.Add(c);
                        }
                    }
                }
                gridPagos.Rows.Clear();
                foreach (var item in pagos)
                {
                    int rowIndex = gridPagos.Rows.Add();
                    DataGridViewRow dr = gridPagos.Rows[rowIndex];
                    dr.Cells[0].Value = item.idPago;
                    dr.Cells[1].Value = item.Sucursal;
                    dr.Cells[2].Value = item.nombre;
                    dr.Cells[3].Value = item.asistencias;
                    dr.Cells[4].Value = item.monto;
                    dr.Cells[5].Value = item.inicioPeriodo;
                    dr.Cells[6].Value = item.finPeriodo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gridPagos.SelectedRows.Count > 0)
            {
                int res = 0;
                try
                {
                    string query = @"DELETE FROM PAQUETERIA.pago WHERE idPago = @idPAgo";
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idPago", gridPagos.SelectedRows[0].Cells[0].Value.ToString())
                    };
                    
                    using (DB dB = new DB())
                    {
                        res = dB.UpdateQuery(query, parameters);
                        if(res > 0)
                        {
                            frmPago_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, intenta de nuevo mas tarde");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un monto para eliminar");
            }
        }
    }
}
