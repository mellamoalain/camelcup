using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace CamelUp.Modelo
{
  

    public static class Utilx
    {
	    public static int numJugadores;
	    public static int dificultad;
	
        /// <summary>
        /// Obtiene la lista de los 5 camellos en juego
        /// </summary>
        /// <returns>Lista de  5 camellos</returns>
	    public static List<Camello> getCamellos()
	    {
		    List<Camello> l = new List<Camello>();
		    l.Add(new Camello(1,"Blanco",Color.White));
		    l.Add(new Camello(2,"Azul",Color.Blue));
		    l.Add(new Camello(3,"Verde",Color.Green));
		    l.Add(new Camello(4,"Amarillo",Color.Yellow));
		    l.Add(new Camello(5,"Naranja",Color.Orange));
		    return l;
	    }

        public static Camello getCamello(int id)
        {
            List<Camello> l = getCamellos();
            //Linq
            return l.FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Obtiene la lista de los jugadores en juego. Selecciona un jugador inicial al azar
        /// </summary>
        /// <param name="numJug">numero de jugadores en la partida</param>
        /// <returns></returns>
	    public static List<Jugador> getJugadoresIniciales(int numJug)
	    {
		    int num = numAleatorio(1,numJug);
		    string[] nombres = {"Jug1", "Rober 'ElAnalizador'", "Lebre Aleatorium", "Xabi 'El Obstinado'", "Jug5", "Jug6", "Jug7", "Jug8"};
		    List<Jugador> l = new List<Jugador>();
		
		    for(int i=0; i<numJug; i++)
		    {
			    bool turno;
			    if (num == i+1)
				    turno = true;
			    else
				    turno = false;
                
			    l.Add(new Jugador(i+1,nombres[i],turno,null));
		    }
		    return l;
	    }
	
	    /// <summary>
	    /// Numero aleatorio entre dos números, incluidos ambos
	    /// </summary>
	    /// <param name="inf">Número inferior</param>
	    /// <param name="sup">Número superior</param>
	    /// <returns></returns>
        public static int numAleatorio(int inf, int sup)
	    {
            Random r = new Random(DateTime.Now.Millisecond);
            int num = r.Next(inf, sup);
            return num;
	    }
	
        /// <summary>
        /// Obtiene un perfil de la IA
        /// </summary>
        /// <param name="id">identificador del perfil</param>
        /// <returns></returns>
	    public static Perfil getPerfil(int id)
	    {
		    switch (id)
		    {
			    case 0: //Player 1
				    return new Perfil(id, "Jugador");
			    case 1: //Escoge al azar entre los posibles ganadores
				    return new Perfil(id, "Aleatorio");
			    case 2: //Escoge totalmente al azar
				    return new Perfil(id, "Aleatorio Max.");
			    case 3: //Apuesta por uno de los cantidatos siempre que pueda ganar, sino al azar
				    return new Perfil(id, "Obstinado");
			    case 4: //Siempre apuesta por el mismo
				    return new Perfil(id, "Obstinado Max.");
			    case 5: //Apuesta siempre por el que tenga mayor número de probabilidad
				    return new Perfil(id, "Optimizado");
			    case 6: //Otro
				    return new Perfil(id, "Otro");
			    case 7: //Otro 2
                    return new Perfil(id, "Otro 2");
			    default:
				    return null;
		    }
		
	    }
    }
}
