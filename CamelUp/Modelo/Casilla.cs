using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    	
    public class Casilla
    {
	    private int id;
	    private List<Camello> camellos;
        private Loseta losetaEnCasilla;
    
	    public Casilla(int ident)
	    {
		    this.id = ident;
		    this.Camellos = new List<Camello>();
		    this.losetaEnCasilla = new Loseta();
	    }
	
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
        public List<Camello> Camellos
        {
            get
            {
                return camellos;
            }
            set
            {
                camellos = value;
            }
        }
        public Loseta LosetaEnCasilla
        {
            get
            {

			    return losetaEnCasilla;
            }

            set
            {
                losetaEnCasilla = value;
            }
        }
    
        /// <summary>
        /// Indica si la casilla está vacía, sin camellos.
        /// </summary>
        public bool hayCamellos()
	    {
		    if(this.camellos.Count == 0)
			    return true;
		    return false;
	    }

	    /// <summary>
	    /// Indica si hay loseta en la casilla
	    /// </summary>
        public bool hayLoseta()
	    {
		    if(losetaEnCasilla == null || !losetaEnCasilla.Activada)
			    return false;
		    return true;
	    }

        public bool estaVacia()
        {
            if (!hayCamellos() && !hayLoseta())
                return true;
            return false;
        }
	
	    /// <summary>
	    /// Añadir camello en ultima posicion
	    /// </summary>
	    /// <param name="c">Camello que se añade</param>
        public void addCamello(Camello c) {
		    camellos.Add(c);
	    }
	
	    /// <summary>
	    /// Eliminar camello de la casilla
	    /// </summary>
	    /// <param name="c">Camello que se elimina</param>
        public void removeCamello(Camello c) {
		    camellos.Remove(c);
	    }
	
	    //Quitar loseta de la casilla
	    public void quitarLoseta() 
	    {
		    this.losetaEnCasilla = new Loseta();
	    }

        public override string ToString()
        {
            string res = id + " - ";
            if (camellos.Count > 0)
            {
                foreach (Camello c in camellos)
                {
                    res += c.Nombre;
                    if (c.Id != camellos[camellos.Count - 1].Id)
                    {
                        res += ", ";
                    }
                }
            }
            else
            {
                res += " Sin camellos";
            }
            if (hayLoseta())
            {
                res += losetaEnCasilla.ToString();
            }
            else
            {
                res += " - Sin loseta";
            }
            return res;
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            Casilla c = obj as Casilla;
            if ((System.Object)c == null)
            {
                return false;
            }

            // Return false if the fields do not match
            if (c.id != this.id)
            {
                return false;
            }
            return true;
        }

        public bool Equals(Casilla c)
        {
            // If parameter is null return false:
            if ((object)c == null)
            {
                return false;
            }

            // Return false if the fields do not match:
            if (c.id != this.id)
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
