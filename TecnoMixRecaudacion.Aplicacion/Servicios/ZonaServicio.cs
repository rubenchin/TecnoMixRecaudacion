using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Aplicacion.Interfaces;
using TecnoMixRecaudacion.Aplicacion.ViewModels;
using TecnoMixRecaudacion.Dominio.Comandos;
using TecnoMixRecaudacion.Dominio.Core.Bus;
using TecnoMixRecaudacion.Dominio.Interfaces;

namespace TecnoMixRecaudacion.Aplicacion.Servicios
{
    public class ZonaServicio : IZonaServicio
    {
        private IZonaRepositorio _zonaRepositorio;
        private readonly IMediatorHandler _bus;
        public ZonaServicio(IZonaRepositorio zonaRepositorio, IMediatorHandler bus)
        {
            _zonaRepositorio = zonaRepositorio;
            _bus = bus;


        }
        public ZonaViewModel ObtenerZonas()
        {
            return  new ZonaViewModel()
            {
                Zonas=_zonaRepositorio.ObtenerZonas()
            };
        }

        void IZonaServicio.Crear(ZonaViewModel zonaViewModel)
        {
            var comandoCrearZona = new ComandoCrearZona(
                zonaViewModel.Nombre,
                zonaViewModel.Descripcion
                );

            _bus.SendCommand(comandoCrearZona);
        }

    }
}
