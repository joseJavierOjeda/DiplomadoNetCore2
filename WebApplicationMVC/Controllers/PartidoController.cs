﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prode.Core.Entidades;
using Prode.Core.Entidades.Interfaces;

namespace WebApplicationMVC.Controllers
{
    public class PartidoController : Controller
    {
        private readonly IFormateador formateador;


        public PartidoController(IFormateador formateador)
        {
            this.formateador = formateador;
        }
        // GET: Partido
        public ActionResult Index()
        {
            var argentina = new Equipo
            {
                Nombre = "Argentina",
                Abreviatura = "ARG"
            };

            var brazil = new Equipo
            {
                Nombre = "Brazil",
                Abreviatura = "BRA"
            };

            ViewBag.Argentina = formateador.NombreCompleto(argentina);

            ViewBag.Brazil = formateador.NombreCompleto(brazil);

            return View();
        }

        // GET: Partido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Partido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partido/Create
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

        // GET: Partido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Partido/Edit/5
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

        // GET: Partido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Partido/Delete/5
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

        public IActionResult ResultadoPartido()
        {

            var partido = new Partido
            {
                EquipoLocal = new Equipo
                {
                    Abreviatura = "Arg",
                    Nombre = "Argentina"
                },

                EquipoVisitante = new Equipo
                {
                    Abreviatura = "Bra",
                    Nombre = "Nigeria"
                },
                GolesLocales = 2,
                GolesVisitantes = 2,
                Fecha = DateTime.Now
            };

            return View(partido);
        }
    }
}