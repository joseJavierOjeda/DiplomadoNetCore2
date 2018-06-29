using Prode.Core.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Equipo : IEquipo
    {
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
    }
}
