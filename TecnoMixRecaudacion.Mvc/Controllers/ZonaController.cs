using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TecnoMixRecaudacion.Aplicacion.Interfaces;
using TecnoMixRecaudacion.Aplicacion.ViewModels;

namespace TecnoMixRecaudacion.Mvc.Controllers
{
    [Authorize]
    public class ZonaController : Controller
    {
        private IZonaServicio _zonaServicio;

        public ZonaController(IZonaServicio zonaServicio)
        {
            _zonaServicio = zonaServicio;
        }
        public IActionResult Index()
        {
            ZonaViewModel modelo = _zonaServicio.ObtenerZonas();
            return View(modelo);
        }
    }
}