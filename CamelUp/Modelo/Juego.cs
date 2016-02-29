using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    public class Juego
    {
        private List<Jugador> jugadores;
        private List<Casilla> tablero;
        private List<Apuesta> ganador;
        private List<Apuesta> perdedor;
        private List<Tarjeta> tarjetas;
        private List<Camello> clasificacion;
        private int[] premioFinalGanador = {8,5,3,2,1,-1};
        private int[] premioFinalPerdedor = {8,5,3,2,1,-1};
        private int[] dados;
        private string ultimaAccion;
        private ArrayList log;
	
        public Juego(int numJugadores)
        {
	        this.jugadores = Utilx.getJugadoresIniciales(numJugadores);
	        tableroInicial();
	        this.ganador = new List<Apuesta>();
	        this.perdedor = new List<Apuesta>();
            log = new ArrayList();
	        tarjetasPrincipioRonda();
	        inicializarDados();
	        addLog("Comienzo de partida");


            //pruebas
            tablero[3].Camellos.Add(new Camello(2, "Azul", System.Drawing.Color.Blue));
            dados[0] = 1;
            dados[1] = 1;
            dados[2] = 0;
            dados[3] = 2;
        }
	
        public List<Jugador> Jugadores
        {
            get
            {
                return jugadores;
            }
            set
            {
                jugadores = value;
            }
        }
        public List<Casilla> Tablero
        {
            get
            {
                return tablero;
            }
            set
            {
                tablero = value;
            }
        }
        public List<Apuesta> Ganador
        {
            get
            {
                return ganador;
            }
            set
            {
                ganador = value;
            }
        }
        public List<Apuesta> Perdedor
        {
            get
            {
                return perdedor;
            }
            set
            {
                perdedor = value;
            }
        }
        public List<Tarjeta> Tarjetas
        {
            get
            {
                return tarjetas;
            }
            set
            {
                tarjetas = value;
            }
        }
        public int[] Dados
        {
            get { return dados; }
            set { dados = value; }
        }

        public string UltimaAccion
        {
            get { return ultimaAccion; }
            set { ultimaAccion = value; }
        }
        
        
        public void reiniciarJuego()
        {
	        //Establecer nuevo jugador inicial y limpiar jugadores
	        int num = Utilx.numAleatorio(1,jugadores.Count);
	        for(int i=0; i<jugadores.Count; i++)
	        {
		        bool turno;
		        if (num == i+1)
			        turno = true;
		        else
			        turno = false;
		        jugadores[i].setTurno(turno);
		        jugadores[i].reiniciar();
	        }
		
	        tableroInicial();
	        this.ganador = new List<Apuesta>();
	        this.perdedor = new List<Apuesta>();
	        tarjetasPrincipioRonda();
	        inicializarDados();
	        addLog("Comienzo de partida");
        }
	
        public void addLog(string accion)
        {
	        ultimaAccion = accion;
	        log.Add(accion);
        }

        public ArrayList obtenerLog()
        {
	        return log;
        }
	
        public void inicializarDados()
        {
	        //Inicializa los dados a 0
	        dados = new int[5];
	        for(int i=0; i<5; i++)
	        {
		        dados[i] = 0;
	        }
        }
	
        private void tableroInicial()
        { 
            //Inicializar las 16 casillas + salida y meta
            tablero = new List<Casilla>();
	        for(int i=0; i<18; i++)
	        {
		        this.tablero.Add(new Casilla(i));
	        }

            //Colocar los cinco camellos en la casilla 0
	        foreach(Camello c in Utilx.getCamellos())
	        {
		        tablero[0].addCamello(c);
	        }
	        
        }
	
        private void tarjetasPrincipioRonda()
        {
	        tarjetas = new List<Tarjeta>();
	        foreach (Camello c in Utilx.getCamellos())
	        {
		        tarjetas.Add(new Tarjeta(c,+5));
		        tarjetas.Add(new Tarjeta(c,+3));
		        tarjetas.Add(new Tarjeta(c,+2));
	        }
        }
	
        private int numJug()
        {
	        return jugadores.Count();
        }
	
        private void lanzarDado(Jugador jug)
        {
	        addLog(jug.Nombre + " lanza un dado");

            //Obtiene un dado de color que no haya sido lanzado aun.
	        int idCam;
            do
	        {
		        idCam = Utilx.numAleatorio(0,4);
	        }
            while(dados[idCam] != 0);

            //Obtiene un resultado entre 1 y 3 y se lo asigno en el array de dados
	        int result = Utilx.numAleatorio(1,3);
	        dados[idCam] = result;

            //Muevo el camello
	        moverCamello(idCam, result);

            //Recalculo clasificacion y veo  si es final de partida.
            calcularClasificacion();
	        if(EsFinPartida())
		        finalPartida();
            else
            {
                //Si no es final de partida, compruebo si es final de ronda
                if (esFinalRonda())
	            {
		            finalRonda();
	            }
            }
        }
	
        private void moverCamello(int idCam, int numero)
        {
	        bool encontrado = false;
		    Camello camelloActual = Utilx.getCamello(idCam);

            //Si aun no ha salido de la casilla de salida (esta en la casilla 0)
	        if(ubicacion(idCam)==0)
	        {
		       
		        tablero[numero].addCamello(camelloActual);
		        //Eliminarlo de la casilla vieja
		        tablero[0].removeCamello(camelloActual);
	        }
	        else
	        {
		        //buscar la casilla en la que esta ese id de cam
		        foreach (Casilla cas in tablero)
		        {
			        for (int i=0;i<cas.Camellos.Count;i++)
			        {
				        if (cas.Camellos[i].Id == idCam || encontrado)
				        {
					        //control de fin de partida. Para que no de error fuera de indice, si el camello va a ganar
					        if(cas.Id + numero > 17)
					        {
						        numero = 17 - cas.Id;
					        }
					        //añadir en otra casilla a ese camello
					        tablero[cas.Id + numero].addCamello(camelloActual);
					        //Eliminarlo de la casilla vieja
					        tablero[cas.Id].removeCamello(camelloActual);
					        encontrado = true;
				        }
			        }
			        if(encontrado)
				        break;
		        }
	        }
	        addLog(idCam + " avanza " + numero + " posiciones");
        }
	
        private void colocarLoseta(Jugador jug, int idCasilla, bool positiva)
        {
	        int puntos = 0;
	        if(positiva)
		        puntos = 1;
	        else
		        puntos = -1;
		
	        //Si la casilla no está vacía de camellos o losetas
	        if(colocable(idCasilla))
	        {
		        //Elimina la anterior loseta de ese jugador
		        for(int i=0; i<tablero.Count; i++)
		        {
		            if (tablero[i].LosetaEnCasilla.Activada && jug.Equals(tablero[i].LosetaEnCasilla.Jug))
			        {
				        tablero[i].quitarLoseta();
				        break;
			        }
		        }

		        //Asigna la nueva loseta a esa casilla
		        tablero[idCasilla].LosetaEnCasilla=new Loseta((jug), puntos);
		        addLog(jug.Nombre + " coloca un " + puntos + " en la casilla " + idCasilla);
	        }
	        else
	        {
		        //lanzar excepcion intento de poner loseta donde ya había otra
                throw new Exception();
	        }	
        }
	
        private void cogerTarjeta(Jugador jug, int id) 
        {
	        addLog("Apuesta de ronda: " + jug.Nombre + " por " + tarjetas[id]);
	        jug.addTarjeta(tarjetas[id]);
            tarjetas.Remove(tarjetas[id]);	
        }
	
        private void apostarGanador(Jugador jug, Camello c)
        {
	        addLog(jug.Nombre + " apuesta por un ganador");
	        ganador.Add(new Apuesta(jug, c));
	        jugadores[jug.Id-1].Cartas.Remove(c);
        }
	
        private void apostarPerdedor(Jugador jug, Camello c)
        {
	        addLog(jug.Nombre + " apuesta por un perdedor");
	        perdedor.Add(new Apuesta(jug, c));
            jugadores[jug.Id - 1].Cartas.Remove(c);
        }


        public bool esFinalRonda()
        {
            for(int i=0; i<dados.Length; i++)
            {
                if (dados[i]==0)
	            {
		            return false;
	            }
            }
            return true;
        }
        
        private bool EsFinPartida()
        {
	        if (tablero[16].Camellos.Count > 0)
		        return true;
	        return false;
        }

        private void finalRonda()
        {
	        inicializarDados();
	        foreach (Jugador j in jugadores)
	        {
		        j.gana(j.DadosLanzados);
		        foreach (Tarjeta t in j.TarjetasRonda)
		        {
			        //Si coincide con camello en cabeza
			        if (t.Camel.Equals(camelloEnCabeza()))
				        j.gana(t.Puntos);
			        else
			        {
				        //Si coincide con segundo
				        if(t.Camel.Equals(camelloSegundo()))
					        j.gana(1);
				        else
					        j.gana(-1);
			        }
		        }
	        }
	        tarjetasPrincipioRonda();
        }
	
        private void finalPartida()
        {
	        finalRonda();
		
            //Se evalúa cada apuesta por el ganador final
	        int i = 0;
	        foreach (Apuesta ap in ganador)
	        {
		        if (ap.Camel.Equals(camelloEnCabeza()))
		        {
			        ap.Jug.gana(premioFinalGanador[i]);
			        i++;
		        }
		        else
			        ap.Jug.gana(-1);
	        }

            //Se evalua cada apuesta por el perdedor final
	        i = 0;
	        foreach (Apuesta ap in perdedor)
	        {
		        if (ap.Camel.Equals(camelloEnCola()))
		        {
			        ap.Jug.gana(premioFinalPerdedor[i]);
			        i++;
		        }
		        else
			        ap.Jug.gana(-1);
	        }
        }
      
        private void calcularClasificacion()
        {
	        clasificacion = new List<Camello>();
	        foreach (Casilla cas in tablero)
	        {
		        foreach (Camello c in cas.Camellos)
		        {
			        clasificacion.Add(c);
		        }
	        }
	        clasificacion.Reverse();
        }
	
        public Camello camelloEnCabeza()
        {
	        return clasificacion[0];
        }
        public Camello camelloSegundo()
        {
	        return clasificacion[1];
        }
        public Camello camelloEnCola()
        {
	        return clasificacion[4];
        }
	
        public Casilla getCasillabyId(int idCasilla)
        {
            foreach(Casilla c in tablero)
            {
                if (c.Id == idCasilla)
	            {
		            return c;
	            }
            }
            return null;
        }

        //Indica si se puede usar la casilla para colocar una loseta
        public bool colocable(int idCasilla)
        {
            Casilla casActual = getCasillabyId(idCasilla);
            Casilla casSup = getCasillabyId(idCasilla+1);
            Casilla casInf = getCasillabyId(idCasilla-1);

            //Caso especial 1: la salida y la meta y la casilla inicial no son colocables
	        if (casActual.Id == 0 || casActual.Id == 1 || casActual.Id == 17)
		        return false;

            //Caso especial 2: La ultima casilla (16) solo miras si hay loseta en la anterior
            if(!casInf.hayLoseta() && casActual.estaVacia())
                return true;

            //Caso normal: Casillas adyacentes sin loseta y casilla actual vacia(sin camellos y sin loseta)
	        if(!casSup.hayLoseta() && !casInf.hayLoseta() && casActual.estaVacia())
		        return true;
	        return false;
        }
	
        //Numero de casilla según posicion en la clasificacion. 
        public int ubicacionPos(int posicion) 
        {
	        //Obtiene el camello que va en esa posición
	        Camello c = clasificacion[posicion-1];
	        return ubicacion(c.Id);
        }
	
        //Numero de casilla de un camello
        public int ubicacion(int idCam)
        {
	        foreach(Casilla c in tablero)
	        {
                foreach(Camello cam in c.Camellos)
                {
		            if (cam.Id == idCam)
		            {
			            return c.Id;
		            }
                }
	        }
	        return -1;
        }
	
        //Devuelve el jugador al que le toca
        public Jugador elTurno()
        {
	        foreach(Jugador j in jugadores)
	        {
		        if (j.isTurno())
			        return j;
	        }
	        //lanzar excepcion. nadie tiene el turno
            throw new Exception();
        }
	
        public void avanzaTurno()
        {
	        int i = 0;
	        foreach(Jugador jug in jugadores)
	        {
		        if (jug.isTurno())
		        {
			        jugadores[i].setTurno(false);
			        if(i+1==jugadores.Count)
				        jugadores[0].setTurno(true);
			        else
				        jugadores[i].setTurno(true);
		        }
		        i++;
	        }
        }
  
        #region IA
	
	/*
        public void mueveIA()
        {
	        Jugador jug = elTurno();
	        AleatorioMax(jug);
		
	        avanzaTurno();
        }
	
        public void AleatorioMax(Jugador jug)
        {
	        int opcion;
	        if(buenMomentoFinal())
			
		        opcion = numAleatorio(1,4);
	        switch (opcion)
	        {
		        case 1: lanzarDado(jug); break;
		        case 2: colocarLoseta(jug, idCasilla, positivo); break;
		        case 3: cogerTarjeta(Jugador, id); break;
		        case 4: 
			        if(numAleatorio(0,1)==0)
				        apostarGanador(jug,c);
			        else
				        apostarPerdedor(jug,c);
		        break;
		        default:
			        //excepcion
		        break;
			
	        }
        }
	
        public void Optimizado(Jugador jug)
        {
	        //Recoge los camellos que tienen posibilidades de ganar
	        ArayList candidatos = posibleGanador();
        }
	
        public bool buenMomentoFinal()
        {
		
		
		
        }
	
	
        public simulacion()
        {
	        //Teniendo en cuenta los camellos que faltan por mover ese turno, rellena el array probabilidades[],
	        //añadiendo +1 con cada posibilidad de dado
		
	        //Copia el tablero en una simulacion
	        copiarTablero();
		
	        for() //Camellos que faltan por mover
	        {
		        for(de uno a tres, resultado de dado)
		        {
			        //moverCamello en tablero simulado
			        //ver el camelloEncabeza, sumar 1 al contador
		        }
	        }
        }
	
        public copiarTablero()
        {
	        //Instanciar un nuevo tablero, recorrer el viejo y copiarlo en el nuevo
        }
	
	*/

	
	
	    #endregion
    }
}
