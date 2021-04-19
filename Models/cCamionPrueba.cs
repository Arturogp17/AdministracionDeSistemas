using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    class cCamionPrueba
    {
        public int idCamion { get; set; }
        public string placa { get; set; }
        public int idSucursal { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public string CamionFK { get { return placa + "-" + marca + "-"+ anio; } }
    }
}
