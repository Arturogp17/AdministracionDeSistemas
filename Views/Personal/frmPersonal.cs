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

namespace ProyectoABD.Views.Personal
{
    public partial class frmPersonal : Form
    {
        private double idPersonal = 0;
        private double nss;
        private double idSucursal;
        private string nombre;
        private string numeroCelular;
        private int edad;
        private string fechaNacimiento;
        private string direccion;
        private string email;
        private string tipoEmpleado;
        private double salario;
        private string cuentaBanca;
        List<cSucursal> sucursales;       

        public frmPersonal(double idP = 0, double numero_ss = 0, double idS = 0, string nom = "", string numCel = "", int ed = 0, string fechNaci = "", string dire = "", string em = "", string tiEmpleado = "", double sal = 0, string cueBan="")
        {
            InitializeComponent();

            idPersonal = idP;
            nss = numero_ss;
            idSucursal = idS;
            nombre = nom;
            numeroCelular = numCel;
            edad = ed;
            fechaNacimiento = fechNaci;
            direccion = dire;
            email = em;
            tipoEmpleado = tiEmpleado;
            salario = sal;
            cuentaBanca = cueBan;
        }


        private void frmPersonal_Load(object sender, EventArgs e)
        {
            List<cPersonal> LisPersonal = new List<cPersonal>();
            sucursales = new List<cSucursal>();

            string query = @"SELECT * FROM PAQUETERIA.personal";
            string querySuc = @"SELECT * FROM PAQUETERIA.sucursal";


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
                    p.cuentaBancaria = Convert.ToString(reader["cuenta"]);

                    LisPersonal.Add(p);

                }

                SqlDataReader readerSuc = dB.DoQuery(querySuc);
                while (readerSuc.Read())
                {

                    cSucursal s = new cSucursal();
                    s.idSucursal = Convert.ToInt32(readerSuc["idSucursal"]);
                    s.nombre = Convert.ToString(readerSuc["nombre"]);
                    s.direccion = Convert.ToString(readerSuc["direccion"]);
                    sucursales.Add(s);
                }

                CBSucursal.Items.Clear();
                foreach(cSucursal a in sucursales)
                {
                    CBSucursal.Items.Add(a.idSucursal+" "+a.nombre);
                }
                

                if (idPersonal > 0)
                {
                    CBSucursal.Text = idSucursal.ToString();
                    TBNombre.Text = nombre;
                    TBNSS.Text = nss.ToString();
                    TBNumCelular.Text = numeroCelular;
                    DTPFechaNacimiento.Text = fechaNacimiento;
                    TBDireccion.Text = direccion;
                    TBEmail.Text = email;
                    CBTipoEmpleado.Text = tipoEmpleado;
                    TBCuenta.Text = cuentaBanca;
                    lbPersonal.Text = "Modifica Personal";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btAñadirPersonal_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            int res = 0;

            int r = 0;
            double indSuc = sucursales.Find(x => x.idSucursal == Convert.ToInt32(CBSucursal.Text.Split(' ')[0])).idSucursal;
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter("@idPersonal",  idPersonal),
                new DBParameter("@nss", TBNSS.Text),
                new DBParameter("@idSucursal", indSuc),
                new DBParameter("@nombre", TBNombre.Text),
                new DBParameter("@numeroCelular", TBNumCelular.Text),
                new DBParameter("@edad", "20"),//Corregir edad
                new DBParameter("@fechaNacimiento", DTPFechaNacimiento.Text),
                new DBParameter("@direccion", TBDireccion.Text),
                new DBParameter("@email", TBEmail.Text),
                new DBParameter("@tipoEmpleado", CBTipoEmpleado.Text),
                new DBParameter("@salario", "2000"),//Corregir Salario                 
                new DBParameter("@cuenta", TBCuenta.Text)

            };
            try
            {
                if (idSucursal > 0)
                {
                    parameters.Add(new DBParameter("@idPersonalMod", idPersonal));
                    query = "UPDATE PAQUETERIA.personal SET nss = @nss, idSucursal = @idSucursal, nombre = @nombre, numeroCelular = @numeroCelular, edad = @edad, direccion = @direccion, email = @email, tipoEmpleado = @tipoEmpleado, cuenta = @cuenta  WHERE idPersonal = @idPersonalMod";
                }
                else
                {
                    query = "INSERT INTO PAQUETERIA.personal (nss,idSucursal,nombre,numeroCelular,edad,fechaNacimiento,direccion,email,tipoEmpleado,salario,cuenta) VALUES (@nss, @idSucursal,@nombre,@numeroCelular,@edad,@fechaNacimiento,@direccion,@email,@tipoEmpleado,@salario, @cuenta)";
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

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
