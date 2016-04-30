using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAgua.DTO;

namespace ProjetoAgua.Controller
{
    class ConsumoControl
    {
        private double valorConsumido;
        private double enviarNovoConsumo;
        private double porcentagem;

        private string mensagem;

        public void InserirMeuNovoConsumo(DTOConsumo consumo)
        {
            valorConsumido = consumo.Consumo;            
        }

        public double ReceberNovoGasto()
        {
            if (valorConsumido <= 6000)
            {
                porcentagem = 0.0;
            }
            else if (valorConsumido > 6001 && valorConsumido <= 8000)
            {
                porcentagem = 0.02;
            }
            else if (valorConsumido > 8001 && valorConsumido <= 10000)
            {
                porcentagem = 0.04;
            }
            else if (valorConsumido > 10001 && valorConsumido <= 12000)
            {
                porcentagem = 0.045;
            }
            else if (valorConsumido > 12001 && valorConsumido <= 14000)
            {
                porcentagem = 0.05;
            }
            else if (valorConsumido >= 14001 && valorConsumido <= 20000)
            {
                porcentagem = 0.06;
            }
            else if (valorConsumido > 20000)
            {
                porcentagem = 0.10;
            }

            enviarNovoConsumo = CalculoFinal(valorConsumido, porcentagem);


            return enviarNovoConsumo;
        }

        public double MostrarPorcentagem(DTOConsumo consumo)
        {
            consumo.Porcentagem = porcentagem * 100;
            return consumo.Porcentagem;
        }

        public string ConferirAumentoDeConsumo(DTOHistorico armazena, double novaInsercaoDeConsumo)
        {
            if (armazena.Historico > novaInsercaoDeConsumo)
            {
                mensagem = "Você conseguiu reduzir seu consumo, parabéns!";
            }
            else if (armazena.Historico < novaInsercaoDeConsumo)
            {
                mensagem = "Opa! Seu consumo aumentou!";
            }
            else if (armazena.Historico == novaInsercaoDeConsumo)
            {
                mensagem = "Seu consumo se manteve estável. ^^";
            }

            return mensagem;
        }

        private double CalculoFinal(double valor, double porcentagem)
        {
            double retirarPorcentagemDoConsumo, total;
            retirarPorcentagemDoConsumo = valor * porcentagem;
            total = valor - retirarPorcentagemDoConsumo;
            return total;
        }
    }
}
