using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Dominio.Core.Eventos;

namespace TecnoMixRecaudacion.Dominio.Core.Comandos
{
    public abstract class Comando: Mensaje
    {
        public DateTime Timestamp { get; protected set; }

        public Comando()
        {
            Timestamp=DateTime.Now;
        }
    }
}
