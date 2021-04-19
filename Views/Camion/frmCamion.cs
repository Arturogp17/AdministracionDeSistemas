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

namespace ProyectoABD.Views.Camion
{
    public partial class frmCamion : Form
    {
        public int idCamion = 0;
        public frmCamion()
        {
            InitializeComponent();
        }

        private void chkComprado_CheckedChanged(object sender, EventArgs e)
        {
            if(chkComprado.Checked)
            {
                grpComprado.Location = new Point(15, 203);
                grpComprado.Visible = true;
                grpArrendado.Visible = false;
            }
            else
            {
                grpArrendado.Location = new Point(15, 203);
                grpArrendado.Visible = true;
                grpComprado.Visible = false;
            }
        }

        private void frmCamion_Load(object sender, EventArgs e)
        {
            List<generic> lg = new List<generic>();
            lg.Add(new generic { value = 12 });
            lg.Add(new generic { value = 24 });
            lg.Add(new generic { value = 36 });
            lg.Add(new generic { value = 48 });
            ddlArrendadoContrato.DataSource = lg;
            List<cSucursal> sucursales = new List<cSucursal>();
            string query = @"SELECT * FROM PAQUETERIA.sucursal";
            try
            {
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

                if(idCamion > 0)
                {
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idCamion", idCamion),
                    
                    };
                    query = "SELECT T0.*, ISNULL((SELECT idCamion from PAQUETERIA.comprado WHERE idCamion = T0.idCamion), 0) Estado FROM PAQUETERIA.camion T0 WHERE T0.idCamion = @idCamion";
                    cCamion c = new cCamion();
                    using (DB dB = new DB())
                    {
                        using (SqlDataReader reader = dB.DoQuery(query, parameters))
                        {
                            while (reader.Read())
                            {
                                c = new cCamion();
                                c.Edo = Convert.ToInt32(reader["Estado"]);
                                c.idCamion = Convert.ToInt32(reader["idCamion"]);
                                c.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                                c.Placa = Convert.ToString(reader["placa"]);
                                c.Modelo = Convert.ToString(reader["modelo"]);
                                c.Marca = Convert.ToString(reader["marca"]);
                                c.Anio = Convert.ToInt32(reader["año"]);
                            }
                        }
                    }
                    txtidCamion.Text = c.idCamion.ToString();
                    txtPlaca.Text = c.Placa;
                    ddlSucursal.SelectedValue = c.idSucursal;
                    txtMarca.Text = c.Marca;
                    txtModelo.Text = c.Modelo;
                    dpAnio.Value = new DateTime(c.Anio, 1, 1);

                    if(c.Edo == 0)
                    {
                        chkArrendado.Checked = true;
                        chkComprado.Checked = false;
                        chkComprado_CheckedChanged(this, null);
                        query = "SELECT * from PAQUETERIA.arrendado where idCamion = @idCamion";
                        
                        using (DB dB = new DB())
                        {
                            using (SqlDataReader reader = dB.DoQuery(query, parameters))
                            {
                                while (reader.Read())
                                {
                                    ddlArrendadoContrato.SelectedValue = Convert.ToInt32(reader["tiempoContrato"]);
                                    numArrendadoCosto.Value = Convert.ToDecimal(reader["costoTotal"]);
                                    txtArrendadoProveedor.Text = Convert.ToString(reader["proveedor"]);
                                }
                            }
                        }
                    }
                    else
                    {
                        chkArrendado.Checked = false;
                        chkComprado.Checked = true;
                        chkComprado_CheckedChanged(this, null);
                        query = "SELECT * from PAQUETERIA.comprado where idCamion = @idCamion";

                        using (DB dB = new DB())
                        {
                            using (SqlDataReader reader = dB.DoQuery(query, parameters))
                            {
                                while (reader.Read())
                                {
                                    numCompradoCosto.Value = Convert.ToDecimal(reader["pago"]);
                                    dpCompradoFechaCompra.Value = Convert.ToDateTime(reader["fechaCompra"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int res = 0;
            string query = String.Empty;
            try
            {
                List<DBParameter> parameters = new List<DBParameter>
                {
                    
                    new DBParameter("@placa", txtPlaca.Text),
                    new DBParameter("@idSucursal", ddlSucursal.SelectedValue),
                    new DBParameter("@marca", txtMarca.Text),
                    new DBParameter("@modelo", txtModelo.Text),
                    new DBParameter("@anio", dpAnio.Value.Year)
                };
                if(chkArrendado.Checked)
                {
                    parameters.Add(new DBParameter("@arrContrato", Convert.ToInt32(ddlArrendadoContrato.SelectedValue)));
                    parameters.Add(new DBParameter("@pagoMensual", numArrendadoCosto.Value / Convert.ToDecimal(ddlArrendadoContrato.SelectedValue)));
                    parameters.Add(new DBParameter("@costoTotal", numArrendadoCosto.Value));
                    parameters.Add(new DBParameter("@proveedor", txtArrendadoProveedor.Text));
                }
                else
                {
                    parameters.Add(new DBParameter("@costo", numCompradoCosto.Value));
                    parameters.Add(new DBParameter("@fechaCompra", dpCompradoFechaCompra.Value));
                }

                if (idCamion > 0)
                {
                    parameters.Add(new DBParameter("@idCamion", idCamion));
                    query = "UPDATE PAQUETERIA.camion SET placa = @placa, idSucursal = @idSucursal, marca = @marca, modelo = @modelo, año = @anio WHERE idCamion = @idCamion";
                    using (DB db = new DB())
                    {
                        res = db.UpdateQuery(query, parameters);
                    }
                    if (chkArrendado.Checked)
                        query = "UPDATE PAQUETERIA.arrendado SET idCamion = @idCamion, tiempoContrato = @arrContrato, pagoMensual = @pagoMensual, costoTotal = @costoTotal, proveedor = @proveedor";
                    else
                        query = "UPDATE PAQUETERIA.comprado SET idCamion = @idCamion, pago = @costo, fechaCompra = @fechaCompra";
                    using (DB db = new DB())
                    {
                        res = db.UpdateQuery(query, parameters);
                    }
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.camion VALUES (@placa, @idSucursal, @marca, @modelo, @anio)";
                    using (DB db = new DB())
                    {
                        res = db.UpdateQuery(query, parameters);
                    }
                    query = "SELECT MAX(idCamion) idCamion from PAQUETERIA.camion";
                    using (DB db = new DB())
                    {
                        using (SqlDataReader reader = db.DoQuery(query))
                        {
                            while (reader.Read())
                            {
                                idCamion = Convert.ToInt32(reader["idCamion"]);
                            }
                        }
                    }
                    parameters.Add(new DBParameter("@idCamion", idCamion));
                    if (chkArrendado.Checked)
                        query = "INSERT INTO PAQUETERIA.arrendado VALUES (@idCamion, @arrContrato, @pagoMensual, @costoTotal, @proveedor)";
                    else
                        query = "INSERT INTO PAQUETERIA.comprado VALUES (@idCamion, @costo, @fechaCompra)";
                    using (DB db = new DB())
                    {
                        res = db.UpdateQuery(query, parameters);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
