using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Dominio.Modelos;

namespace TecnoMixRecaudacion.Aplicacion.ViewModels
{
    public class ZonaViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable<Zona> Zonas { get; set; }

    }
}
