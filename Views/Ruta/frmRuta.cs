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

namespace ProyectoABD.Views.Ruta
{
    public partial class frmRuta : Form
    {
        public int idRuta;
        public int idCamion;
        public string hora;
        public int idSucO;
        public int idSucD;

        List<cSucursal> sucursales = new List<cSucursal>();
        List<cSucursal> sucursalesdest = new List<cSucursal>();
        List<cCamionPrueba> camiones = new List<cCamionPrueba>();

        public int comboBoxSOrigen;
        public int comboBoxSDest;

        public frmRuta(int idRuta, int idCamion, string hora, int idSucO, int idSucD)
        {
            InitializeComponent();
            this.idRuta = idRuta;
            this.idCamion = idCamion;
            this.hora = hora;
            this.idSucO = idSucO;
            this.idSucD = idSucD;
            this.comboBoxSOrigen = 0;
            this.comboBoxSDest = 0;
        }

        private void frmRuta_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM PAQUETERIA.sucursal";
                string queryc = @"SELECT * FROM PAQUETERIA.camion";

                DB dB = new DB();
                SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    cSucursal sucursal = new cSucursal();
                    sucursal.idSucursal = Convert.ToInt32(reader["idSucursal"]);
                    sucursal.nombre = Convert.ToString(reader["nombre"]);
                    sucursales.Add(sucursal);
                    sucursalesdest.Add(sucursal);
                }
                /*cbSucOrigen.DataSource = sucursales;
                cbSucOrigen.ValueMember = "idSucursal";
                cbSucOrigen.DisplayMember = "idNombre";

                cbSucDestino.DataSource = sucursalesdest;
                cbSucDestino.ValueMember = "idSucursal";
                cbSucDestino.DisplayMember = "idNombre";*/

                cbSucOrigen.Items.Clear();
                foreach (cSucursal a in sucursales)
                {
                    cbSucOrigen.Items.Add(a.idSucursal + "-" + a.nombre);
                }

                cbSucDestino.Items.Clear();
                foreach (cSucursal a in sucursalesdest)
                {
                    cbSucDestino.Items.Add(a.idSucursal + "-" + a.nombre);
                }

                SqlDataReader readerCam = dB.DoQuery(queryc);
                while (readerCam.Read())
                {
                    cCamionPrueba camion = new cCamionPrueba();
                    camion.idCamion = Convert.ToInt32(readerCam["idCamion"]);
                    camion.placa = Convert.ToString(readerCam["placa"]);
                    camion.idSucursal = Convert.ToInt32(readerCam["idSucursal"]);
                    camion.modelo = Convert.ToString(readerCam["modelo"]);
                    camion.marca = Convert.ToString(readerCam["marca"]);
                    camion.anio = Convert.ToInt32(readerCam["año"]);
                    camiones.Add(camion);
                }

                cbCamion.DataSource = camiones;
                cbCamion.ValueMember = "idCamion";
                cbCamion.DisplayMember = "CamionFK";

                if (idRuta > 0)
                {
                    cbCamion.SelectedValue = idCamion;
                    tbHora.Text = hora;
                    cbSucOrigen.Text = Convert.ToString(idSucO);
                    cbSucDestino.Text = Convert.ToString(idSucD);
                    lbRuta.Text = "Modificar Ruta";
                    btAñadirRuta.Text = "Modificar";
                    cbSucDestino.Items.Clear();
                    foreach (cSucursal a in sucursalesdest)
                    {
                        if (a.idSucursal != idSucO)
                        {
                            cbSucDestino.Items.Add(a.idSucursal + "-" + a.nombre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSucOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSucO = Convert.ToInt32(cbSucOrigen.SelectedIndex);
            comboBoxSOrigen = sucursales[idSucO].idSucursal;
            cbSucDestino.SelectedIndex = -1;
            cbSucDestino.Items.Clear();
            foreach (cSucursal a in sucursalesdest)
            {
                if(a.idSucursal != comboBoxSOrigen)
                {
                    cbSucDestino.Items.Add(a.idSucursal + "-" + a.nombre);
                }    
            }
        }

        private void btAñadirRuta_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            int res = 0;

            double indSuc0 = sucursales.Find(x => x.idSucursal == Convert.ToInt32(cbSucOrigen.Text.Split('-')[0])).idSucursal;
            double indSucD = sucursales.Find(x => x.idSucursal == Convert.ToInt32(cbSucDestino.Text.Split('-')[0])).idSucursal;

            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idRuta", idRuta),
                new DBParameter("@idCamion", Convert.ToInt32(cbCamion.SelectedValue)),
                new DBParameter("@horario", tbHora.Text),
                new DBParameter("@idSucursalOrigen", indSuc0),
                new DBParameter("@idSucursalDestino", indSucD)
            };
            try
            {
                if (idRuta > 0)
                {
                    parameters.Add(new DBParameter("@idRutaMod", idRuta));
                    query = "UPDATE PAQUETERIA.ruta SET idCamion = @idCamion, horario = @horario, idSucursalOrigen = @idSucursalOrigen, idSucursalDestino = @idSucursalDestino " +
                        "WHERE idRuta = @idRutaMod";
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.ruta (idCamion, horario,idSucursalOrigen,idSucursalDestino ) " +
                        "VALUES (@idCamion,@horario,@idSucursalOrigen,@idSucursalDestino)";
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
