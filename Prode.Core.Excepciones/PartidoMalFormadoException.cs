using System;

namespace Prode.Core.Excepciones
{
    public class PartidoMalFormadoException : Exception
    {
        public string Equipo1 { get; set; }
        public string Equipo2 { get; set; }

        public override string ToString()
        {
            return $"Error en partido de {Equipo1} vs {Equipo2}, {Message}";
        }
    }
}
