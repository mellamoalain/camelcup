using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{

    public class Loseta
    {
        private Jugador jug;
        private bool activada;
        private int resultado;

        public Loseta()
        {
            this.jug = null;
            this.activada = false;
            this.resultado = 0;
        }

        public Loseta(Jugador jugador, int res)
        {
            this.jug = jugador;
            this.activada = true;
            this.resultado = res;
        }

        //Propiedades
        public Jugador Jug
        {
            get
            {
                return jug;
            }
            set
            {
                jug = value;
            }
        }
        public bool Activada
        {
            get
            {
                return activada;
            }
            set
            {
                activada = value;
            }
        }
        public int Resultado
        {
            get
            {
                return resultado;
            }
            set
            {
                resultado = value;
            }
        }

        public override string ToString()
        {
            string res = jug.Nombre;
		    if(activada)
		    {
			    res += " Res: " + resultado;
		    }
		    else
		    {
                res += " Sin activar";
		    }
            return res;
        }
    }
}
