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

        public void GuardarProducto(Producto producto)
        {

            if(producto.id == 0)
            {
                _contexto.Productos.Add(producto);
            }else
            {
                var productoExistente = _contexto.Productos.Find(producto.id);
                productoExistente.descripcion = producto.descripcion;
                productoExistente.precio = producto.precio;
            }
           
            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
   
    }
}
