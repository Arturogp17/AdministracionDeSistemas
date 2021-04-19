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

namespace ProyectoABD.Views.Telefono
{
    public partial class frmTelefono : Form
    {
        private int idTelefono;
        private int idSucursal;
        private string numtelefono;
        public frmTelefono(int idTel, int idS = 0, string telefono = "")
        {
            InitializeComponent();
            idTelefono = idTel;
            idSucursal = idS;
            numtelefono = telefono;
        }

        private void frmTelefono_Load(object sender, EventArgs e)
        {
            try
            {
                List<cSucursal> sucursales = new List<cSucursal>();
                string query = @"SELECT * FROM PAQUETERIA.sucursal";

                DB dB = new DB();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cSucursal sucursal = new cSucursal();
                    sucursal.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                    sucursal.nombre = Convert.ToString(reader["nombre"]);
                    sucursales.Add(sucursal);
                }
                cbSucursales.DataSource = sucursales;
                cbSucursales.ValueMember = "idSucursal";
                cbSucursales.DisplayMember = "idNombre";

                if (idSucursal > 0)
                {
                    cbSucursales.SelectedValue = idSucursal;
                    tbNumTelefono.Text = numtelefono.ToString();
                    lbAddTel.Text = "Modifica Teléfono";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btAñadirSucursal_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            int res = 0;
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idTelefono", idTelefono),
                new DBParameter("@idSucursal", Convert.ToInt32(cbSucursales.SelectedValue)),
                new DBParameter("@telefono", tbNumTelefono.Text)
            };
            try
            {
                if (idSucursal > 0 && idTelefono > 0)
                {
                    parameters.Add(new DBParameter("@idTelefonoMod", idTelefono));
                    query = "UPDATE PAQUETERIA.telefono SET idSucursal = @idSucursal, telefono = @telefono WHERE idTelefono = @idTelefonoMod";
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.telefono (idSucursal, telefono) VALUES (@idSucursal, @telefono)";
                }
                DB dB = new DB();

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
