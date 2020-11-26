using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Aplicacion.Interfaces;
using TecnoMixRecaudacion.Aplicacion.ViewModels;
using TecnoMixRecaudacion.Dominio.Interfaces;

namespace TecnoMixRecaudacion.Aplicacion.Servicios
{
    public class ZonaServicio : IZonaServicio
    {
        private IZonaRepositorio _zonaRepositorio;

        public ZonaServicio(IZonaRepositorio zonaRepositorio)
        {
            _zonaRepositorio = zonaRepositorio;

        }
        public ZonaViewModel ObtenerZonas()
        {
            return  new ZonaViewModel()
            {
                Zonas=_zonaRepositorio.ObtenerZonas()
            };
        }
    }
}
