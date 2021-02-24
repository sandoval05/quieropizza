using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
   public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int id { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
