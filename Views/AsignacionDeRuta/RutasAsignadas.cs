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
    public partial class RutasAsignadas : Form
    {
        public RutasAsignadas()
        {
            InitializeComponent();

            grdAsignacionDeRutas.Columns.Add("idAsignacionRuta", "idAsignacionRuta");
            grdAsignacionDeRutas.Columns.Add("idPersonal", "idPersonal");
            grdAsignacionDeRutas.Columns.Add("nombrePersonal", "nombrePersonal");
            grdAsignacionDeRutas.Columns.Add("idRuta", "idRuta");
            grdAsignacionDeRutas.Columns.Add("Direcciones", "Direcciones");
            grdAsignacionDeRutas.Columns.Add("fechaInicio", "fechaInicio");
            grdAsignacionDeRutas.Columns.Add("fechaFin", "fechaFin");

            // grdAsignacionDeRutas.Columns["idAsignacionRuta"].Visible = false;
        }

        private void Btn_FormAgregar_Click(object sender, EventArgs e)
        {
            AsignacionDeRuta frmAsignacionDeRuta = new AsignacionDeRuta();
            if (frmAsignacionDeRuta.ShowDialog() == DialogResult.OK)
            {
                LoadAsignacionRutas();
            }
        }

        private void RutasAsignadas_Load(object sender, EventArgs e)
        {
            LoadAsignacionRutas();
        }

        private void LoadAsignacionRutas()
        {
            grdAsignacionDeRutas.Rows.Clear();

            List<cAsignacionDeRuta> lstAsignacionPersonal = GetListPersonal();

            foreach (cAsignacionDeRuta item in lstAsignacionPersonal)
            {
                int index = grdAsignacionDeRutas.Rows.Add();
                grdAsignacionDeRutas.Rows[index].Cells["idAsignacionRuta"].Value = item.idAsignacionRuta;
                grdAsignacionDeRutas.Rows[index].Cells["idPersonal"].Value = item.idPersonal;
                grdAsignacionDeRutas.Rows[index].Cells["nombrePersonal"].Value = item.nombrePersonal;
                grdAsignacionDeRutas.Rows[index].Cells["idRuta"].Value = item.idRuta;
                grdAsignacionDeRutas.Rows[index].Cells["Direcciones"].Value = item.Direcciones;
                grdAsignacionDeRutas.Rows[index].Cells["fechaInicio"].Value = item.fechaInicio;
                grdAsignacionDeRutas.Rows[index].Cells["fechaFin"].Value = item.fechaFin;
            }
        }

        public List<cAsignacionDeRuta> GetListPersonal()
        {
            List<cAsignacionDeRuta> ListAsignacionPersonal = new List<cAsignacionDeRuta>();
            string query = @"SELECT ADR.idAsignacionRuta,
                    P.idPersonal,
                    P.nombre as nombrePersonal,
                    ADR.idRuta,
                    O.direccion + ' - ' + D.direccion AS Direcciones,
                    ADR.fechaInicio,
                    ADR.fechaFin
                    FROM PAQUETERIA.asignacionDeRutas ADR
                    INNER JOIN PAQUETERIA.personal P ON P.idPersonal = ADR.idPersonal
                    INNER JOIN PAQUETERIA.ruta R ON R.idRuta = ADR.idRuta
                    INNER JOIN PAQUETERIA.sucursal O ON O.idSucursal = R.idSucursalOrigen
                    INNER JOIN PAQUETERIA.sucursal D ON D.idSucursal = R.idSucursalDestino";

            try
            {
                DB dB = new DB();
                SqlDataReader reader = dB.DoQuery(query);

                while (reader.Read())
                {
                    cAsignacionDeRuta p = new cAsignacionDeRuta();

                    p.idAsignacionRuta = Convert.ToInt32(reader["idAsignacionRuta"]);
                    p.idPersonal = Convert.ToInt32(reader["idPersonal"]);
                    p.nombrePersonal = Convert.ToString(reader["nombrePersonal"]);
                    p.idRuta = Convert.ToInt32(reader["idRuta"]);
                    p.Direcciones = Convert.ToString(reader["Direcciones"]);
                    p.fechaInicio = Convert.ToDateTime(reader["fechaInicio"]).ToString("dd/MM/yyyy");
                    p.fechaFin = Convert.ToDateTime(reader["fechaFin"]).ToString("dd/MM/yyyy");

                    ListAsignacionPersonal.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ListAsignacionPersonal;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (grdAsignacionDeRutas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar");
            }
            else
            {
                int iSel = int.Parse(grdAsignacionDeRutas.SelectedRows[0].Cells["idAsignacionRuta"].Value.ToString());
                EliminarAsignacionDeRuta(iSel);
                LoadAsignacionRutas();
            }
        }

        private bool EliminarAsignacionDeRuta(int idAsignacionRuta)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idAsignacionRuta",  idAsignacionRuta)
            };

            string query = @"DELETE PAQUETERIA.asignacionDeRutas WHERE idAsignacionRuta = @idAsignacionRuta";
            DB dB = new DB();
            int res = dB.UpdateQuery(query, parameters);
            if (res <= 0)
            {
                MessageBox.Show("Ha ocurrido un error eliminar una asignacion de rutas");
                return false;
            }

            return true;
        }

        private void GrdAsignacionDeRutas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAsignacionDeRutas.SelectedRows.Count > 0)
            {
                int idRuta = int.Parse(grdAsignacionDeRutas.SelectedRows[0].Cells["idRuta"].Value.ToString());
                int idAsignacionRuta = int.Parse(grdAsignacionDeRutas.SelectedRows[0].Cells["idAsignacionRuta"].Value.ToString());
                int idPersonal = int.Parse(grdAsignacionDeRutas.SelectedRows[0].Cells["idPersonal"].Value.ToString());
                string fechaFin = grdAsignacionDeRutas.SelectedRows[0].Cells["fechaFin"].Value.ToString();

                AsignacionDeRuta frmAsignacionDeRuta = new AsignacionDeRuta(idAsignacionRuta, idRuta, idPersonal, fechaFin);
                if (frmAsignacionDeRuta.ShowDialog() == DialogResult.OK)
                {
                    LoadAsignacionRutas();
                }
            }
        }
    }
}
