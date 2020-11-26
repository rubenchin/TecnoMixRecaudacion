using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TecnoMixRecaudacion.Dominio.Core.Comandos;

namespace TecnoMixRecaudacion.Dominio.Core.Bus
{
   public interface IMediatorHandler
   {
       Task SendCommand<T>(T command) where T : Comando;
   }
}
