using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Dominio.Core.Comandos;

namespace TecnoMixRecaudacion.Dominio.Comandos
{
    public abstract class ComandoZona: Comando
    {
        public string Nombre { get; protected set; }

        public string Descripcion { get; protected set; }


    }
}
