using ProyectpABD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoABD.Models;
using System.Data.SqlClient;

namespace ProyectoABD.Views.Sucursal
{
    public partial class frmSucursal : Form
    {
        private int idSucursal = 0;
        private string nombre = string.Empty;
        private string direccion = string.Empty;

        public frmSucursal(int idS = 0, string nom = "", string dir = "")
        {
            InitializeComponent();
            idSucursal = idS;
            nombre = nom;
            direccion = dir;
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                List<cSucursal> sucursales = new List<cSucursal>();
                string query = @"SELECT * FROM PAQUETERIA.sucursal";

                DBIDisposable dB = new DBIDisposable();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cSucursal sucursal= new cSucursal();
                    sucursal.idSucursal = Convert.ToInt32(reader[0]);
                    sucursal.nombre = Convert.ToString(reader[1]);
                    sucursal.direccion = Convert.ToString(reader[1]);
                    sucursales.Add(sucursal);
                }
                if (idSucursal > 0)
                {
                    tbNombre.Text = nombre;
                    tbDireccion.Text = direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            int res = 0;
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idSucursal", idSucursal),
                new DBParameter("@nombre", tbNombre.Text),
                new DBParameter("@direccion", tbDireccion.Text)
            };
            try
            {
                if (idSucursal > 0)
                {
                    parameters.Add(new DBParameter("@idSucursalMod", idSucursal));
                    query = "UPDATE PAQUETERIA.sucursal SET nombre = @nombre, direccion = @direccion WHERE idSucursal = @idSucursalMod";
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.sucursal (nombre,direccion) VALUES (@nombre, @direccion)";
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
