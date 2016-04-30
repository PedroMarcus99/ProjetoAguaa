using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.DTO
{
    class DTOCasa
    {
        public int Id { get; set; }
        public int NumeroDaCasa { get; set; }
        public string CEP { get; set; }
        public int QuantidadeMoradores { get; set; }
        public double ConsumoTotal { get; set; }
    }
}
