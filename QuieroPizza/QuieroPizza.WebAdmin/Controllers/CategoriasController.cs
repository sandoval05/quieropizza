﻿using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevaCategoria = new Categoria();

            return View(nuevaCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if(categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La Descripcion no debe contener espacios");
                    return View(categoria);
                }
                _categoriasBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
           
        }

        public ActionResult Editar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);

            return View(categoria);
        }

        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La Descripcion no debe contener espacios");
                    return View(categoria);
                }
                _categoriasBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Detalle(int Id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(Id);
            return View(categoria);
        }

        public ActionResult Eliminar(int Id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(Id);
            return View(categoria);
        }

        [HttpPost]

        public ActionResult Eliminar(Categoria categoria)
        {
            _categoriasBL.EliminarCategoria(categoria.Id);
            return RedirectToAction("Index");
        }
    }
}