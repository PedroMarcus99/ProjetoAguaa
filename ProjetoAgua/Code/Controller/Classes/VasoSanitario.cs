using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.Controller.Classes
{
    public class VasoSanitario
    {
        private double constanteMedia = 2;

        public double Descarga(int segundos)
        {
            return Math.Round(segundos * constanteMedia, 2);
        }
    }
}
