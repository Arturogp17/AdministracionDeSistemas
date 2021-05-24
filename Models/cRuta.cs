using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{

    class cRuta
    {
        public int idRuta { get; set; }
        public int idCamion { get; set; }
        public int idSucursalOrigen { get; set; }
        public int idSucursalDestino { get; set; }
        public String horario { get; set; }
        public String nombreSO { get; set; }
        public String nombreSD { get; set; }
        public String placa { get; set; }
        public String marca { get; set; }
        public int anio { get; set; }

    }
     public override string ToString()
      {
          return nombreRuta;
      }
}
