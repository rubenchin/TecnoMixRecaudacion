using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Dominio.Modelos;

namespace TecnoMixRecaudacion.Dominio.Interfaces
{
    public interface IZonaRepositorio
    {
        IEnumerable<Zona> ObtenerZonas();



    }
}
