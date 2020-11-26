using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using MediatR;

namespace TecnoMixRecaudacion.Dominio.Core.Eventos
{
    public abstract class Mensaje:IRequest<bool>
    {
        public string TipoMensaje { get; protected set; }

        public Mensaje()
        {
            TipoMensaje = GetType().Name;
        }
    }
}
