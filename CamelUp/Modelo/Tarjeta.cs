using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    public class Tarjeta
    {
        private Camello cam;
        private int puntos;

        public Tarjeta(Camello c, int punt)
        {
            this.cam = c;
            this.puntos = punt;
        }

        public Camello Camel
        {
            get
            {
                return cam;
            }
            set
            {
                cam = value;
            }
        }
        public int Puntos
        {
            get
            {
                return puntos;
            }
            set
            {
                puntos = value;
            }
        }

        public override string ToString()
        {
            string res = "Tarjeta del camello " + cam.Nombre + ". +";
            res += puntos + " monedas";
            return res;
        }
    }
}
