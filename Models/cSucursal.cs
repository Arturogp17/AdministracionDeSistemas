using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    class cSucursal
    {
        public double idSucursal;
        public string direccion;
        public string nombre;


        public override string ToString()
        {
            return idSucursal.ToString();
        }
    }

    
}
