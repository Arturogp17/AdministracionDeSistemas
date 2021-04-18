using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    public class cRuta
    {
        public int idRuta;
        public int idCamion;
        public int idSucursalOrigen;
        public int idSucursalDestino;
        public string horario;
        public string nombreRuta;

        public override string ToString()
        {
            return nombreRuta;
        }
    }
}
