using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    class cCamion
    {
        public int idCamion { get; set; }
        public string Placa { get; set; }
        public string Sucursal { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Edo { get; set; }
        public int idSucursal { get; set; }

        public string Estado { get { return Edo == 0 ? "Arrendado" : "Comprado"; } }
    }
}