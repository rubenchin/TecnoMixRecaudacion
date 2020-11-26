using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using TecnoMixRecaudacion.Aplicacion.Interfaces;
using TecnoMixRecaudacion.Aplicacion.Servicios;
using TecnoMixRecaudacion.Dominio.Interfaces;
using TecnoMixRecaudacion.Infra.Data.Repositorios;

namespace TecnoMixRecaudacion.Infra.IoC
{
    public class ContenedorDependencias
    {
        public static void RegistroServicios(IServiceCollection servicios)
        {
            //Capa de Aplicacion
            servicios.AddScoped<IZonaServicio, ZonaServicio>();


            //Capa Infra.Data
            servicios.AddScoped<IZonaRepositorio, ZonaRepositorio>();




        }
    }
}
