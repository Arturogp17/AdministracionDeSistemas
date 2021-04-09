using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    public class cPersonal
    {
        public double idPersonal;
        public double nss;
        public double idSucursal;
        public string nombre;
        public string numeroCelular;
        public int edad;
        public string fechaNacimiento;
        public string direccion;
        public string email;
        public string tipoEmpleado;
        public double salario;
        public string cuentaBancaria;
        public int contadorAsistencias;
            

        public override string ToString()
        {
            return nombre;
        }
    }
}
