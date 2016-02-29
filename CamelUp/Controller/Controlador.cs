using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamelUp.Modelo;

namespace CamelUp.Controller
{
    class Controlador
    {
        private Juego miJuego;

        public Juego MiJuego
        {
            get
            {

                return miJuego;
            }

            set
            {
                miJuego = value;
            }
        }
        
    }
}
