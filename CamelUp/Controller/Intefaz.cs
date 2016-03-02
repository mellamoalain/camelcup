using CamelUp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Controller
{

    public enum COLOR
    {
        Amarillo,
        Azul,
        Blanco,
        Naranja,
        Verde
    }

    public class Camel
    {
        //Identificador único del camello, de 1 a 5
        public int Id;
        //Colores del camello ==> ENUM COLOR
        public string Color;
        //Casilla en la que se encuentra el camello, por defecto 0 (casilla inicial)
        public int Casilla = 0;
        //Altura en esa casilla (entre 1 a 5). 1 ==> el camello esta abajo; 2 ==> el camello está encima de uno mas ; 3 ==> el camello está encima de dos más
        public int AlturaCasilla = 0;
        //Número sacado en dado del camello. 0 significa que aún no ha salido ese dado
        public int Dado = 0;

        public Camel(int id)
        {
            Id = id;
            Color =  Enum.GetName(typeof(COLOR), id-1);
        }
    }

    class Intefaz
    {
        public List<Camel> camellos = new List<Camel>();
        public void Main()
        {
           camellos.Add(new Camel(1));
           camellos.Add(new Camel(2));
           camellos.Add(new Camel(3));
           camellos.Add(new Camel(4));
           camellos.Add(new Camel(5));
        }


        public string TirarDado()
        {
            //Camellos pendientes de mover
            string mensaje = "";
            List<Camel> camellos_pendientes =  camellos.Where(s=>s.Dado == 0).ToList();
            int dadoColor = Utilx.numAleatorio(1,camellos_pendientes.Count());
            Camel camello_a_mover = camellos_pendientes[dadoColor-1];
            int tirada = Utilx.numAleatorio(1,3);
            int totalCamellosEnCasillaDestino = camellos.Count(s => s.Casilla == camello_a_mover.Casilla + tirada);
            camellos.Where(
                    s => s.Casilla == camello_a_mover.Casilla
                    && s.AlturaCasilla >= camello_a_mover.AlturaCasilla).ToList().
                    ForEach(
                    c => 
                        {
                            c.Casilla = c.Casilla + tirada;
                            c.AlturaCasilla = c.AlturaCasilla + totalCamellosEnCasillaDestino;
                            mensaje = "Camello " + c.Color + " se coloca en casilla " + c.Casilla.ToString();
                        }
                    );
            return mensaje;
        }
    }
}
