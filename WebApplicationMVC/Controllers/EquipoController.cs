using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prode.Core.Entidades;
using Prode.Core.Entidades.Interfaces;

namespace WebApplicationMVC.Controllers
{
    public class EquipoController : Controller
    {
        private readonly IFormateador formateador;

        public EquipoController(IFormateador formateador)
        {
            this.formateador = formateador;
        }
        // GET: Equipo
        public ActionResult Index()
        {
            var argentina = new Equipo {
                Nombre = "Argentina",
                Abreviatura = "ARG"
            };

            ViewBag.Nombre = formateador.NombreCompleto(argentina);

            return View();
        }

        // GET: Equipo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Equipo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Equipo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}