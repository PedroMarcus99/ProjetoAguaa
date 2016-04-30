using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAgua.DTO;

namespace ProjetoAgua.Controller
{
    class ArmazenarControl
    {
        double somarHistorico;
        string mensagem;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="armazena"></param>
        /// <returns></returns>
        public double CarregarHistorico(DTOHistorico armazena)
        {
            return armazena.Historico;
        }

        /// <summary>
        /// Soma o novo consumo mensal inserido com os valores anteriores;
        /// </summary>
        /// <param name="armazena"></param>
        /// <param name="valor"></param>
        public void InserirNoHistorico(DTOHistorico armazena, double valor)
        {
            somarHistorico += valor;
            armazena.Historico = somarHistorico;
        }

        /// <summary>
        /// Recupera o histórico de consumos.
        /// </summary>
        /// <param name="armazena"></param>
        /// <returns></returns>
        public double CarregarInsercao(DTOHistorico armazena)
        {
            return armazena.Insercoes;
        }

        public void InserirNaInsercao(DTOHistorico armazena, double valorNovaInsercao)
        {
            armazena.Insercoes = valorNovaInsercao;
        }


        /// <summary>
        /// Confere o aumento, estabilidade ou redução do consumo mensal.
        /// </summary>
        /// <param name="armazena"></param>
        /// <param name="novaInsercaoDeConsumo"></param>
        /// <returns></returns>
        public string ConferirAumentoDeConsumo(DTOHistorico armazena, double novaInsercaoDeConsumo)
        {
            if (armazena.Insercoes > novaInsercaoDeConsumo)
            {
                mensagem = "Você conseguiu reduzir seu consumo, parabéns!";
            }
            else if (armazena.Insercoes < novaInsercaoDeConsumo)
            {
                mensagem = "Opa! Seu consumo aumentou!";
            }
            else if (armazena.Insercoes == novaInsercaoDeConsumo)
            {
                mensagem = "Seu consumo se manteve estável. ^^";
            }
            else
            {
                mensagem = "Deu bug!";
            }

            return mensagem;
        }
    }
}
