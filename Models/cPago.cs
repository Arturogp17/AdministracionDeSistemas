﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABD.Models
{
    class cPago
    {
        public int idPersonal { get; set; }
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public string Sucursal { get; set; }
        public int diastrabajados { get; set; }
        public string cuenta { get; set; }
        public string NSS { get; set; }
        public double monto { get; set; }
        public double salario { get; set; }
        public DateTime fecha { get; set; }

    }
}