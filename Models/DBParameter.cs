using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectpABD.Models
{
    class DBParameter
    {
        public string Id { get; set; }
        public dynamic Value { get; set; }

        public DBParameter()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DBParameter(string Id, dynamic Value)
        {
            this.Id = Id;
            this.Value = Value;
        }
    }
}
