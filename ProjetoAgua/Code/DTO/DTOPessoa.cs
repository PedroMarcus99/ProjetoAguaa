using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.DTO
{
    public class DTOPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Senha { get; set; }
        public double Total { get; set; }
        public decimal Porcentagem { get; set; }
    }
}
