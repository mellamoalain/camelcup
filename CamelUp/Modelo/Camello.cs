using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CamelUp.Modelo
{
    public class Camello
    {
	    private int id;
	    private string nombre;
	    private Color colorCam;
	
        public Camello(int ident, string nom, Color col)
	    {
		    this.id = ident;
		    this.nombre = nom;
		    this.colorCam = col;
	    }
	
        //Propiedades
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
	    public Color ColCam
        {
            get
            {
                return colorCam;
            }
            set
            {
                colorCam = value;
            }
        }
	
	    public override string ToString()
        {
            return id + " - " + nombre;
        }

        public bool Equals(Camello c)
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


    }
}
