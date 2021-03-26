using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    class cSucursal
    {
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }

        public string idNombre { get { return idSucursal + "-" + nombre; } }


        public override string ToString()
        {
            return idSucursal.ToString();
        }
    }

    
}
