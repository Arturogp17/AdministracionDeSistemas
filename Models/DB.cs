using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectpABD.Models
{
    class DBIDisposable
    {
        //Luis Cardona: "localhost\\SQLEXPRESS"
        private string DB_SERVER = "localhost\\SQLEXPRESS";
        private string DATABASE = "paqueteriaSLP";
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


        /*
         * COMO USAR DOQUERY
         * List<Alumno> alumnos = new List<Alumno>();
            string query = @"SELECT idAlumno, T1.idPersona, nombreCarrera, T1.nombre + ' ' + T1.apellidoParterno + ' ' + T1.apellidoMaterno nombreCompleto 
                                FROM ADMINBD.alumno T0
                                JOIN ADMINBD.persona T1 on T1.idPersona = T0.idPersona";
            try
            {
                using DB dB = new DB();
                using SqlDataReader reader = dB.DoQuery(query);
                while (reader.Read())
                {
                    Alumno a = new Alumno();
                    a.idAlumno = Convert.ToInt32( reader["idAlumno"]);
                    a.idPersona = Convert.ToInt32(reader["idPersona"]);
                    a.nombreCarrera = Convert.ToString(reader["nombreCarrera"]);
                    a.nombrePersona = Convert.ToString(reader["nombreCompleto"]);
                    alumnos.Add(a);
                }
                foreach (var item in alumnos)
                {
                    string[] row = new string[] { item.idAlumno.ToString(), item.idPersona.ToString(), item.nombrePersona, item.nombreCarrera };
                    gridAlumnos.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         * */
        public SqlDataReader DoQuery(string Query, List<DBParameter> Parameters = null)
        {
            try
            {

                string strConnection = "Data Source=" + DB_SERVER + ";" +
                                        "Initial Catalog=" + DATABASE + ";" +
                                        "integrated security = true";

                sqlConnection = new SqlConnection(strConnection);
                {

                    if (sqlConnection.State == ConnectionState.Closed)
                        sqlConnection.Open();

                    sqlCommand = new SqlCommand(Query, sqlConnection);
                    {

                        if (Parameters != null)
                        {
                            foreach (DBParameter parameter in Parameters)
                            {
                                sqlCommand.Parameters.AddWithValue(parameter.Id, parameter.Value);
                            }
                        }

                        return sqlCommand.ExecuteReader();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ArgumentException(ex.Message);
            }
        }

        /*
         * EJEMPLO COMO USAR UPDATEQUERY
         * try
                    {
                        List<DBParameter> parameters = new List<DBParameter>
                    {
                        new DBParameter("@IdAlumno", Convert.ToInt32(gridAlumnos.SelectedRows[0].Cells[0].Value))
                    };
                        string query = "DELETE FROM ADMINBD.alumno WHERE idAlumno = @idAlumno";
                        using (DB dB = new DB())
                        {
                            res = dB.UpdateQuery(query, parameters);
                        }
                        if (res > 0)
                        {
                            FillGrid();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
         */
        public int UpdateQuery(string Query, List<DBParameter> Parameters = null)
        {
            try
            {

                string strConnection = "Data Source=" + DB_SERVER + ";" +
                                        "Initial Catalog=" + DATABASE + ";" +
                                        "integrated security = true";

                sqlConnection = new SqlConnection(strConnection);
                {

                    if (sqlConnection.State == ConnectionState.Closed)
                        sqlConnection.Open();

                    sqlCommand = new SqlCommand(Query, sqlConnection);
                    {

                        if (Parameters != null)
                        {
                            foreach (DBParameter parameter in Parameters)
                            {
                                sqlCommand.Parameters.AddWithValue(parameter.Id, parameter.Value);
                            }
                        }

                        return sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ArgumentException(ex.Message);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);



            GC.Collect();
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                if (sqlCommand != null)
                    sqlCommand.Dispose();

                if (sqlConnection != null)
                    sqlConnection.Dispose();

            }

            disposed = true;
        }
    }
}
