using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAgua.DTO;

namespace ProjetoAgua.Controller
{
    class AnaliseControl
    {
        private double consumos = 0;
        private int contarInsercoes = 5;
        private double retornaTotal = 0;

        /// <summary>
        /// Recebe um consumo mensal.
        /// </summary>
        /// <param name="consumo"></param>
        public void InserirConsumo(DTOConsumo consumo)
        {
            consumos += consumo.Consumo;

            AumentarInsercao();
        }

        /// <summary>
        /// Retorna a análise final.
        /// </summary>
        private void RetornaAnalise()
        {
            contarInsercoes = 5;
            retornaTotal = consumos / contarInsercoes;
            consumos = 0;
        }

        /// <summary>
        /// Contagem regressiva para terminar a análise.
        /// </summary>
        private void AumentarInsercao()
        {
            contarInsercoes--;
        }

        /// <summary>
        /// Mostra a Quantidade de Inserções restantes para o fim da análise.
        /// </summary>
        /// <returns></returns>
        public int MostrarInsercoesRestantes()
        {
            return contarInsercoes;
        }

        /// <summary>
        /// Solicitar média de consumo a partir da análise.
        /// </summary>
        /// <returns></returns>
        public double SolicitarMedia()
        {
            if (contarInsercoes == 0)
            {
                RetornaAnalise();
            }
            return retornaTotal;
        }
    }
}
