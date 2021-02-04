using QuieroPizza.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.WEB.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.id = 1;
            producto1.descripcion = "Pizza de 9 quesos";

            var producto2 = new ProductoModel();
            producto2.id = 2;
            producto2.descripcion = "Pizza de 4 Estaciones";

            var producto3 = new ProductoModel();
            producto3.id = 3;
            producto3.descripcion = "Pizza de Jamon y Queso";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return View(listadeproductos);
        }
    }
}