using Prode.Core.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Formateadores
{
    public class SuperFormateador : IFormateador
    {
        public string NombreCompleto(IEquipo equipo)
        {
            return $"***{equipo.Nombre}**";
        }
    }
}
