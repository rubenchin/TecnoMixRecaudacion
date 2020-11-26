using System;
using System.Collections.Generic;
using System.Text;
using TecnoMixRecaudacion.Dominio.Interfaces;
using TecnoMixRecaudacion.Dominio.Modelos;
using TecnoMixRecaudacion.Infra.Data.Context;

namespace TecnoMixRecaudacion.Infra.Data.Repositorios
{
    public class ZonaRepositorio:IZonaRepositorio
    {
        private TecnomixRecaudacionDBContext _ctx;

        public ZonaRepositorio(TecnomixRecaudacionDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Zona> ObtenerZonas()
        {
            string proveedor= _ctx.Database.ProviderName;
            bool puedeConnect = _ctx.Database.CanConnect();
            return _ctx.Zona;
        }
    }
}
