using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.Controller.Classes
{
    public class Chuveiro
    {
        private double consumoMedio = 0.16; //0.16L por segundo no chuveiro

        public double AbrirChuveiro(int segundos)
        {
            return Math.Round(segundos * consumoMedio, 2);
        }
    }
}
