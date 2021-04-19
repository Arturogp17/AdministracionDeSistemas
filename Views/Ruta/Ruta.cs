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
using ProyectoABD.Models;
using ProyectpABD.Models;

namespace ProyectoABD.Views.Ruta
{
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
            FillGrid();
        }

        public void FillGrid()
        {
            gridRutas.Rows.Clear();
            List<cRuta> rutas = new List<cRuta>();
            List<cRuta> rutas2 = new List<cRuta>();
            List<cRuta> rutas3 = new List<cRuta>();
            string query = @"SELECT * FROM PAQUETERIA.ruta  
                        INNER JOIN PAQUETERIA.sucursal ON PAQUETERIA.ruta.idSucursalOrigen = PAQUETERIA.sucursal.idSucursal ";
            string query2 = @"SELECT * FROM PAQUETERIA.ruta  
                        INNER JOIN PAQUETERIA.sucursal ON PAQUETERIA.ruta.idSucursalDestino = PAQUETERIA.sucursal.idSucursal ";
            string query3 = @"SELECT * FROM PAQUETERIA.ruta  
                        INNER JOIN PAQUETERIA.camion ON PAQUETERIA.ruta.idCamion = PAQUETERIA.camion.idCamion ";
            try
            {
                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cRuta r = new cRuta();
                    r.idRuta = Convert.ToInt32(reader["idRuta"]);
                    r.idCamion = Convert.ToInt32(reader["idCamion"]);
                    r.horario = Convert.ToString(reader["horario"]);
                    r.idSucursalOrigen = Convert.ToInt32(reader["idSucursalOrigen"]);
                    r.idSucursalDestino = Convert.ToInt32(reader["idSucursalDestino"]);
                    r.nombreSO = Convert.ToString(reader["nombre"]);
                    rutas.Add(r);
                }
                SqlDataReader reader2 = dB.DoQuery(query2);
                while (reader2.Read())
                {
                    cRuta r = new cRuta();
                    r.nombreSD = Convert.ToString(reader2["nombre"]);
                    rutas2.Add(r);
                }
                SqlDataReader reader3 = dB.DoQuery(query3);
                while (reader3.Read())
                {
                    cRuta r = new cRuta();
                    r.placa = Convert.ToString(reader3["placa"]);
                    r.marca = Convert.ToString(reader3["marca"]);
                    r.anio = Convert.ToInt32(reader3["año"]);
                    rutas3.Add(r);
                }
                string nomD;
                string infoCamion;
                int index = 0;
                foreach (var item in rutas)
                {
                    nomD = rutas2[index].nombreSD;
                    infoCamion = rutas3[index].placa + "-"+rutas3[index].marca +"-"+ Convert.ToString(rutas3[index].anio);
                    index++;
                    string[] row = new string[] { item.idRuta.ToString(), item.idCamion.ToString(),infoCamion, item.horario.ToString(), item.idSucursalOrigen.ToString(),item.nombreSO.ToString(), item.idSucursalDestino.ToString(), nomD};
                    gridRutas.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAñadirRuta_Click(object sender, EventArgs e)
        {
            frmRuta fp = new frmRuta(0,0,"",0,0);
            fp.Text = "Añadir nueva ruta";
            if (fp.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void btEliminarRuta_Click(object sender, EventArgs e)
        {
            if (gridRutas.SelectedRows.Count > 0)
            {
                try
                {
                    int res = 0;
                    List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@idRuta", Convert.ToInt32(gridRutas.SelectedRows[0].Cells[0].Value))
                    };
                    string query = "DELETE FROM PAQUETERIA.ruta WHERE idRuta = @idRuta";
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

        private void gridRutas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRuta = Convert.ToInt32(gridRutas.Rows[e.RowIndex].Cells["idRuta"].Value);
            int idCamion = Convert.ToInt32(gridRutas.Rows[e.RowIndex].Cells["idCamion"].Value);
            string horario = Convert.ToString(gridRutas.Rows[e.RowIndex].Cells["horario"].Value);
            int idSO = Convert.ToInt32(gridRutas.Rows[e.RowIndex].Cells["idSucursalOrigen"].Value);
            int idSD = Convert.ToInt32(gridRutas.Rows[e.RowIndex].Cells["idSucursalDestino"].Value);
            frmRuta fs = new frmRuta(idRuta, idCamion, horario, idSO, idSD);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }
    }


}
