using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades.Interfaces
{
    public interface IPartido
    {
         IEquipo EquipoLocal { get; set; }

         IEquipo EquipoVisitante { get; set; }

         int GolesLocales { get; set; }

         int GolesVisitantes { get; set; }

         DateTime Fecha { get; set; }

        string InformacionResultado { get; set; }
    }
}
