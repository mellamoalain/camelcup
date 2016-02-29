using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    public class Perfil
    {
        private int id;
        private string nombre;

        public Perfil(int id, string nom)
        {
            this.id = id;
            this.nombre = nom;
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
        
        public override string ToString()
        {
            return id + " - " + nombre;
        }
    }
}
