using Consola.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{

   

    public enum COLOR
    {
        Amarillo,
        Azul,
        Blanco,
        Naranja,
        Verde
    }



    public class Loseta
    {
        public int Id_jugador {get;set;}
        public int Casilla = 0;
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
        public int ProbabilidadGanar = 0;

        public Camel(int id)
        {
            Id = id;
            Color =  Enum.GetName(typeof(COLOR), id-1);
        }
    }

    class Intefaz
    {
        public static ConsoleColor MapColor(string color)
        {
            if (color == "Amarillo")
                return ConsoleColor.Yellow;
            if (color == "Naranja")
                return ConsoleColor.DarkYellow;
            if (color == "Azul")
                return ConsoleColor.Blue;
            if (color == "Verde")
                return ConsoleColor.Green;
            if (color == "Blanco")
                return ConsoleColor.White;
            return ConsoleColor.White;
        }


        public List<Camel> camellos = new List<Camel>();
        public Intefaz()
        {
           camellos.Add(new Camel(1));
           camellos.Add(new Camel(2));
           camellos.Add(new Camel(3));
           camellos.Add(new Camel(4));
           camellos.Add(new Camel(5));
        }

        public Camel GanadorMasProbable()
        {
            Camel c = new Camel(1);
          /*  List<Camel> posibles = camellos;
            foreach (Camel posible in camellos)
            {
                if(posible.Dado != 0)
                {
                    //Si ha tirado ya el dado
                    if (posible)
                    {
                    } 

                }
            } */
            
            return c;

        }


        public string TirarDado()
        {
            //Camellos pendientes de mover
            string mensaje = "";
            List<Camel> camellos_pendientes =  camellos.Where(s=>s.Dado == 0).ToList();
            System.Threading.Thread.Sleep(100);
            Random r = new Random(DateTime.UtcNow.Millisecond * DateTime.UtcNow.Millisecond);
            int dadoColor = r.Next(1,camellos_pendientes.Count()+1);
            Camel camello_a_mover = camellos_pendientes[dadoColor-1];
            System.Threading.Thread.Sleep(100);
            Random rnd = new Random(DateTime.UtcNow.Millisecond * DateTime.UtcNow.Millisecond);
            int tirada = rnd.Next(1,4);
            camello_a_mover.Dado = tirada;
            Console.WriteLine("Ha salido un " + tirada.ToString() + " en el dado " + camello_a_mover.Color);
            int totalCamellosEnCasillaDestino = camellos.Count(s => s.Casilla == camello_a_mover.Casilla + tirada);
            camellos.Where(
                    s => s.Casilla == camello_a_mover.Casilla
                    && (s.AlturaCasilla > camello_a_mover.AlturaCasilla || s.Id == camello_a_mover.Id)).OrderBy(s=>s.AlturaCasilla).ToList().
                    ForEach(
                    c => 
                        {
                            c.Casilla = c.Casilla + tirada;
                            c.AlturaCasilla = c.AlturaCasilla + totalCamellosEnCasillaDestino;
                           Console.ForegroundColor = Intefaz.MapColor(c.Color);
                           Console.WriteLine("      Camello " + c.Color + " se coloca en casilla " + c.Casilla.ToString());
                        }
                    );

            Console.ForegroundColor = ConsoleColor.Gray;
            return mensaje;
        }

        internal void ReiniciarDado()
        {
            camellos.ForEach(
                c =>
                {
                    c.Dado = 0;
                }
                );
        }
    }
}
