using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Aplicacion.ViewModels;
using TecnoMixRecaudacion.Dominio.Modelos;

namespace TecnoMixRecaudacion.Aplicacion.Interfaces
{
    public interface IZonaServicio
    {
        ZonaViewModel ObtenerZonas();
    }
}
