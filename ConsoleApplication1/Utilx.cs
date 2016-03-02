using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace Consola.Modelo
{
  

    public static class Utilx
    {
	
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
	
      
    }
}
