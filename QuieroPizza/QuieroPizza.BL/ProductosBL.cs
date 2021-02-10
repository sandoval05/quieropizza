using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Producto> Listadeproductos { get; set; }


        public ProductosBL()
        {
            _contexto = new Contexto();
            Listadeproductos = new List<Producto>();
        }


        public List<Producto> ObtenerProductos()
        {

            Listadeproductos =  _contexto.Productos.ToList();
            return Listadeproductos; 
        }
   
    }
}
