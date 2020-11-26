using System;
using System.Collections.Generic;
using System.Text;

namespace TecnoMixRecaudacion.Dominio.Comandos
{
    public class ComandoCrearZona:ComandoZona
    {
        public ComandoCrearZona(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
