using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Intefaz juego = new Intefaz();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Comienza el juego");

            while (juego.camellos.Count(s => s.Casilla > 15) == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    juego.TirarDado();
                    if(juego.camellos.Count(s => s.Casilla > 15) != 0)
                    {
                        break;
                    }
                }
                string color = juego.camellos.OrderByDescending(s => s.Casilla).ThenByDescending(s => s.AlturaCasilla).First().Color;

                Console.ForegroundColor = Intefaz.MapColor(color);
                Console.WriteLine("Camello en cabeza: " +  color);
                juego.ReiniciarDado();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("Camello ganador: " +
                    juego.camellos.OrderByDescending(s => s.Casilla).ThenByDescending(s => s.AlturaCasilla).First().Color);

            Console.WriteLine("Clasificacion Final");
            Console.WriteLine("*******");
            int pos = 1;
            juego.camellos.OrderByDescending(s => s.Casilla).ThenByDescending(s => s.AlturaCasilla).ToList().ForEach
                (
                c =>
                {
                    Console.ForegroundColor = Intefaz.MapColor(c.Color);
                    Console.WriteLine(pos.ToString() + ". " + "Camello " + c.Color);
                    pos++;
                }
                );

            Console.ReadLine();
        }



      
    }
}
