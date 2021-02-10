using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
        var producto1 = new Producto();
        producto1.id = 1;
        producto1.descripcion = "Pizza de 9 quesos";
        producto1.precio = 180;

        var producto2 = new Producto();
        producto2.id = 2;
        producto2.descripcion = "Pizza de 4 Estaciones";
        producto2.precio = 220;

        var producto3 = new Producto();
        producto3.id = 3;
        producto3.descripcion = "Pizza de Jamon y Queso";
        producto3.precio = 250;

        var listadeproductos = new List<Producto>();
        listadeproductos.Add(producto1);
        listadeproductos.Add(producto2);
        listadeproductos.Add(producto3);

            return listadeproductos;
         }
   
    }
}
