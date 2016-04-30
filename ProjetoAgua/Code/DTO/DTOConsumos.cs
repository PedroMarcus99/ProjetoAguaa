using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.DTO
{
    class DTOConsumos
    {
        public double Chuveiro { get; set; }
        public double Torneira { get; set; }
        public double Descarga { get; set; }
        public double MaquinaLavar { get; set; }
        public double Plantas { get; set; }
        public double LavarQuintal { get; set; }
        public double Mangueira { get; set; }
        public double Balde { get; set; }
        public int idPessoaConsumo { get; set; }
        public string Data { get; set; }

    }
}
