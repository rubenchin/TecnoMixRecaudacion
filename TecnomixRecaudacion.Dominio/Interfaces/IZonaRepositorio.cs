using System;
using System.Collections.Generic;
using System.Text;
using TecnomixRecaudacion.Dominio.Modelos;

namespace TecnomixRecaudacion.Dominio.Interfaces
{
    public interface IZonaRepositorio
    {
        IEnumerable<Zona> ObtenerZonas();



    }
}
