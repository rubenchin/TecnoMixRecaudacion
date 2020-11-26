using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TecnoMixRecaudacion.Dominio.Comandos;
using TecnoMixRecaudacion.Dominio.Interfaces;
using TecnoMixRecaudacion.Dominio.Modelos;

namespace TecnoMixRecaudacion.Dominio.ManejadorComandos
{
    public class ManejadorComandosZona : IRequestHandler<ComandoCrearZona, bool>
    {
        private readonly IZonaRepositorio _zonaRepositorio;
        public ManejadorComandosZona(IZonaRepositorio zonaRepositorio)
        {
            _zonaRepositorio = zonaRepositorio;
        }
        public Task<bool> Handle(ComandoCrearZona request, CancellationToken cancellationToken)
        {
            var zona = new Zona()
            {
                Nombre = request.Nombre,
                Descripcion = request.Descripcion
            };
        _zonaRepositorio.Add(zona);
            return Task.FromResult(true);

    }

    }
}
