using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prode.Core.Entidades;
using Prode.Core.Entidades.Interfaces;
using Prode.Core.Excepciones;

namespace WebApplicationMVC.Controllers
{
    [Route("[controller]")]
    public class PartidoController : Controller
    {
        private readonly IFormateador formateador;
        public ILogger logger { get; set; }

        public PartidoController(IFormateador formateador, ILogger<PartidoController> logger)
        {
            this.formateador = formateador;
            this.logger = logger;
        }
        // GET: Partido
        public IActionResult Index()
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
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Partido/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Partido/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Partido/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Partido/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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

        [Route("{equipo1}-{equipo2}")]
        public IActionResult Detalle(string equipo1, string equipo2)
        {
            if (equipo1.Length > 3)
            {
                throw new ArgumentException("El equipo 1 es incorrecto");
            }
            if (equipo1.Equals("RIB", StringComparison.CurrentCultureIgnoreCase) 
                || equipo2.Equals("RIB", StringComparison.CurrentCultureIgnoreCase))
            {
                var ex =  new PartidoMalFormadoException() {
                    Equipo1 = equipo1,
                    Equipo2 = equipo2
                };

                logger.LogError(ex.ToString());
            }
            try
            {
                var resultado = equipo1.Length / (equipo2.Length - 1);
                ViewBag.Resultado = resultado;
            }
            catch (DivideByZeroException ex)
            {

                throw;
            }
            catch (Exception ex)
            {

                throw;
            }
            
            return View();
        }
    }
}