using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TecnoMixRecaudacion.Aplicacion.Interfaces;
using TecnoMixRecaudacion.Aplicacion.Servicios;
using TecnoMixRecaudacion.Dominio.Comandos;
using TecnoMixRecaudacion.Dominio.Core.Bus;
using TecnoMixRecaudacion.Dominio.Interfaces;
using TecnoMixRecaudacion.Dominio.ManejadorComandos;
using TecnoMixRecaudacion.Infra.Bus;
using TecnoMixRecaudacion.Infra.Data.Context;
using TecnoMixRecaudacion.Infra.Data.Repositorios;

namespace TecnoMixRecaudacion.Infra.IoC
{
    public class ContenedorDependencias
    {
        public static void RegistroServicios(IServiceCollection servicios)
        {
            // Dominio InMemoryBus MediatR
            servicios.AddScoped<IMediatorHandler, InMemoryBus>();

            //Dominio Handlers
            servicios.AddScoped<IRequestHandler<ComandoCrearZona, bool>, ManejadorComandosZona>();

            //Capa de Aplicacion
            servicios.AddScoped<IZonaServicio, ZonaServicio>();


            //Capa Infra.Data
            servicios.AddScoped<IZonaRepositorio, ZonaRepositorio>();


            servicios.AddScoped<TecnomixRecaudacionDBContext>();


        }
    }
}
