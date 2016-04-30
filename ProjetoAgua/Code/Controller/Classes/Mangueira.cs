using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.Controller.Classes
{
    class Mangueira
    {
        private double vazao_baixa = 0.15; // vazão de aproximadamente 150ml por segundo
        private double vazao_media = 0.45; // vazão de aproximadamente 450ml por segundo 
        private double vazao_alta = 0.75;  // vazão de aproximadamente 750ml por segundo

        /* Calcula os gastos de água de acordo com vazão de água da mangueira 
        e o tempo de utilização para lavar o quintal */
        public double UsarMangueira(int segundos, string vazao)
        {
            double retorno = 0;
            switch(vazao)
            {
                case "Baixa": retorno = vazao_baixa * segundos;
                    break;
                case "Média": retorno = vazao_media * segundos;
                    break;
                case "Alta": retorno = vazao_alta * segundos;
                    break;
            }
            return retorno;
        }

        /* Calcula os gastos de água de acordo com vazão de água da mangueira 
        e o tempo de utilização para lavar a Janela */
        public double Lavar_Janela(int TmpMin, int vazaoJ)
        {
            double vazaoSegundo = 0;
            double tempoSegundo = TmpMin * 60; // tempo em segundos de utilização da mangueira
            if (vazaoJ == 1)
            {
                vazaoSegundo = vazao_baixa;
            }
            else if (vazaoJ == 2)
            {
                vazaoSegundo = vazao_media;
            }
            else if (vazaoJ == 3)
            {
                vazaoSegundo = vazao_alta;
            }
            double LavarJanela = (vazaoSegundo * tempoSegundo);
            return LavarJanela; //retorna o valor da conta 
        }

        /* Calcula os gastos de água de acordo com vazão de água da mangueira 
        e o tempo de utilização para lavar o carro */
        public double Lavar_Carro(int TempoSeg, int vazaoC)
        {
            double vazaoSeg = 0;
            double Tempo = TempoSeg * 60; // tempo em segundos de utilização da mangueira
            if (vazaoC == 1)
            {
                vazaoSeg = vazao_baixa;
            }
            else if (vazaoC == 2)
            {
                vazaoSeg = vazao_media;
            }
            else if (vazaoC == 3)
            {
                vazaoSeg = vazao_alta;
            }
            double LavarCarro = (vazaoSeg * Tempo);
            return LavarCarro; // retorna o valor da conta.       
        }


        /* Calcula os gastos de água de acordo com vazão de água da mangueira 
        e o tempo de utilização regar plantas*/

        public double regar_plantas(int TempoP, int vazaoP)
        {
            double segundos = 0;
            double tempo = TempoP * 60; // tempo em segundos de utilização da mangueira          
            if (vazaoP == 1)
            {
                segundos = vazao_baixa;
            }
            else if (vazaoP == 2)
            {
                segundos = vazao_media;
            }
            double RegarPlanta = (segundos * tempo);
            return RegarPlanta; //retorna o valor da conta 
        }

    }
}
