using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.Controller.Classes
{
    public class Torneira
    {
        double constanteMedia = 0.265;  //0.2L  são gastos para cada segundo

        /// <summary>
        /// Efetua o cálculo de uma torneira aberta.
        /// </summary>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public double AbrirTorneira(int segundos)
        {
            return Math.Round(segundos * constanteMedia, 2);
        }
    }
}
