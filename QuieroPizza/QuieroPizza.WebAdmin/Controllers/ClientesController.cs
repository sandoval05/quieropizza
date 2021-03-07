using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.WebAdmin.Controllers
{
    public class ClientesController : Controller
    {
        ClienteBL _clientesBL;

        public ClientesController()
        {
            _clientesBL = new ClienteBL();
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var listadeClientes = _clientesBL.ObtenerClientes();

            return View(listadeClientes);
        }

        public ActionResult Crear()
        {
            var nuevoCliente = new Cliente();

            return View(nuevoCliente);
        }

        [HttpPost]
        public ActionResult Crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (cliente.nombre != cliente.nombre.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La Descripcion no debe contener espacios");
                    return View(cliente);
                }
                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);

        }

        public ActionResult Editar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (cliente.nombre != cliente.nombre.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La Descripcion no debe contener espacios");
                    return View(cliente);
                }
                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Detalle(int Id)
        {
            var cliente = _clientesBL.ObtenerCliente(Id);
            return View(cliente);
        }

        public ActionResult Eliminar(int Id)
        {
            var cliente = _clientesBL.ObtenerCliente(Id);
            return View(cliente);
        }

        [HttpPost]

        public ActionResult Eliminar(Cliente cliente)
        {
            _clientesBL.EliminarCliente(cliente.id);
            return RedirectToAction("Index");
        }
    }

}