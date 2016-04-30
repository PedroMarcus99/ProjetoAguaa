using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.Controller.Classes
{
    public class Segundos
    {
        public int MinutoParaSegundos(int minutos)
        {
            return minutos * 60;
        }
        public int HoraParaSegundos(int hora)
        {
            return hora * 3600;
        }
    }
}
