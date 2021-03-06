﻿using Prode.Core.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Partido : IPartido
    {
        public IEquipo EquipoLocal { get; set; }

        public IEquipo EquipoVisitante { get; set; }

        public int GolesLocales { get; set; }

        public int GolesVisitantes { get; set; }

        public DateTime Fecha { get; set; }

        public string InformacionResultado
        {
            get { 
            var resultado = string.Empty;

            if (GolesLocales > GolesVisitantes)
            {
                resultado = $"Gano {EquipoLocal.Nombre}";
            }
            else if (GolesVisitantes > GolesLocales)
            {
                resultado = $"Gano {EquipoVisitante.Nombre}";
            }
            else
            {
                resultado = "Empate";
            }

            return resultado;
            }
            set { }
        }
    }
}
