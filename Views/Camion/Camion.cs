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
    public partial class Camion : Form
    {
        public Camion()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCamion fc = new frmCamion();
            if(fc.ShowDialog() == DialogResult.OK)
            {
                Camion_Load(this, null);
            }
            fc.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridCamiones.SelectedRows.Count > 0)
                {
                    int res = 0;
                    if (MessageBox.Show("Esta seguro que desea eliminar el camion con las placas: " + gridCamiones.SelectedRows[0].Cells[1].Value.ToString(), "Eliminar Camion", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        List<DBParameter> parameters = new List<DBParameter>
                        {
                            new DBParameter("@idCamion", gridCamiones.SelectedRows[0].Cells[0].Value)
                        };
                        using (DB db = new DB())
                        {
                            string query = String.Empty;
                            if (gridCamiones.SelectedRows[0].Cells[6].Value.ToString() == "Comprado")
                            {
                                query = "DELETE FROM PAQUETERIA.comprado WHERE idCamion = @idCamion";

                            }
                            else
                            {
                                query = "DELETE FROM PAQUETERIA.arrendado WHERE idCamion = @idCamion";
                            }
                            res = db.UpdateQuery(query, parameters);
                            query = "DELETE FROM PAQUETERIA.camion WHERE idCamion = @idCamion";

                            res = db.UpdateQuery(query, parameters);
                        }
                        Camion_Load(this, null);
                    }
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridCamiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCamion fc = new frmCamion();
            fc.idCamion = Convert.ToInt32(gridCamiones.Rows[e.RowIndex].Cells[0].Value);
            if (fc.ShowDialog() == DialogResult.OK)
            {
                Camion_Load(this, null);
            }
            fc.Dispose();
        }

        private void Camion_Load(object sender, EventArgs e)
        {
            List<cCamion> camiones = new List<cCamion>();
            string query = @"SELECT 
	                            T0.*, T1.nombre Sucursal,
	                            ISNULL((SELECT idCamion from PAQUETERIA.comprado WHERE idCamion = T0.idCamion), 0) Estado
                            FROM paqueteria.camion T0
                            JOIN PAQUETERIA.sucursal T1 on T0.idSucursal = T1.idSucursal";
            try
            {
                using (DB dB = new DB())
                {
                    using (SqlDataReader reader = dB.DoQuery(query))
                    {
                        while (reader.Read())
                        {
                            cCamion c = new cCamion();
                            c.idCamion = Convert.ToInt32(reader["idCamion"]);
                            c.Placa = Convert.ToString(reader["placa"]);
                            c.Sucursal = Convert.ToString(reader["Sucursal"]);
                            c.Modelo = Convert.ToString(reader["modelo"]);
                            c.Marca = Convert.ToString(reader["marca"]);
                            c.Anio = Convert.ToInt32(reader["año"]);
                            c.Edo = Convert.ToInt32(reader["Estado"]);
                            camiones.Add(c);
                        }
                    }
                }
                gridCamiones.Rows.Clear();
                foreach (var item in camiones)
                {
                    
                    int rowIndex = gridCamiones.Rows.Add();
                    DataGridViewRow dr = gridCamiones.Rows[rowIndex];
                    dr.Cells[0].Value = item.idCamion;
                    dr.Cells[1].Value = item.Placa;
                    dr.Cells[2].Value = item.Sucursal;
                    dr.Cells[3].Value = item.Marca;
                    dr.Cells[4].Value = item.Modelo;
                    dr.Cells[5].Value = item.Anio;
                    dr.Cells[6].Value = item.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
