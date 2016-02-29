using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CamelUp.Modelo
{
    public class Jugador
    {
	    private int id;
	    private string nombre;
	    private List<Camello> cartas;
	    private int dinero;
	    private bool turno;
	    private List<Tarjeta> tarjetasRonda;
	    private int dadosLanzados;
	    private Perfil perfil;
	    const int DIN_INICIAL = 3;
	
	    public Jugador(int ident, string nom, bool turn, Perfil p)
	    {
		    this.id = ident;
		    this.nombre = nom;
		    this.cartas = Utilx.getCamellos();
		    this.perfil = p;
		
		    this.dinero = DIN_INICIAL;
		    this.turno = turn;
		    this.tarjetasRonda = new List<Tarjeta>();
		    this.dadosLanzados = 0;
	    }

        #region Propiedades Jugador
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
	    public List<Camello> Cartas
        {
            get
            {
                return cartas;
            }
            set
            {
                cartas = value;
            }
        }
	    public int Dinero
        {
            get
            {
                return dinero;
            }
            set
            {
                dinero = value;
            }
        }
	    public bool isTurno()
        {
            return turno;
        }
        public void setTurno(bool t)
        {
            turno = t;
        }
	    public List<Tarjeta> TarjetasRonda
        {
            get
            {
                return tarjetasRonda;
            }
            set
            {
                tarjetasRonda = value;
            }
        }
	    public Perfil Profile
        {
            get
            {
                return perfil;
            }
            set
            {
                perfil = value;
            }
        }
        public int DadosLanzados
        {
            get
            {
                return dadosLanzados;
            }
            set
            {
                dadosLanzados = value;
            }
        }
        #endregion

        /// <summary>
        /// Deja el jugador como al inicio de la partida
        /// </summary>
        public void reiniciar()
	    {
		    this.cartas = Utilx.getCamellos();
		    this.dinero = DIN_INICIAL;
		    this.turno = false;
		    this.tarjetasRonda = new List<Tarjeta>();
		    this.dadosLanzados = 0;
	    }

        /// <summary>
        /// El jugador gana dinero
        /// </summary>
        /// <param name="moned">numero de monedas que gana el jugador</param>
	    public void gana(int moned)
	    {
		    dinero = dinero + moned;
	    }
	
        /// <summary>
        /// El jugador coge una tarjeta de apuesta de ronda
        /// </summary>
        /// <param name="t">Tarjeta a añadir</param>
	    public void addTarjeta(Tarjeta t)
	    {
		    tarjetasRonda.Add(t);
	    }
	
	    public override string ToString()
        {
		    string res = id + " - " + nombre + "";
            return res;
        }

        public bool Equals(Jugador j)
        {
            // If parameter is null return false:
            if ((object)j == null)
            {
                return false;
            }

            // Return false if the fields do not match:
            if (j.id != this.id)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return id ^ id;
        }
    }

}
