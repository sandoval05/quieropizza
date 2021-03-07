using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
   public  class Cliente
    {
        public Cliente()
        {
            Activo = true;
        }
        
        public int id { get; set; }
        public string nombre { get; set; }
        public int numero { get; set; }
        public string direccion { get; set; }
        public bool Activo { get; set; }
    }
}
