using Prode.Core.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Formateador : IFormateador
    {
        private string Id { get; set; }

        public Formateador()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string NombreCompleto(IEquipo equipo)
        {
            return $"Nombre Completo {equipo.Nombre} ({equipo.Abreviatura}) {Id}";
        }
    }
}
