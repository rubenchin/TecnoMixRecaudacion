using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TecnoMixRecaudacion.Dominio.Core.Bus;
using TecnoMixRecaudacion.Dominio.Core.Comandos;

namespace TecnoMixRecaudacion.Infra.Bus
{
    public sealed class InMemoryBus: IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Comando
        {
            return _mediator.Send(command);
        }
    }
}
