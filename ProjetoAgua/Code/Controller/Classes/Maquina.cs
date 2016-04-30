using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgua.Code.Controller.Classes
{
    class Maquina
    {
        private double litros = 27;   // São gastos em média 27 litros por quilo de roupa em uma máquina cheia
        private double quilos = 1;
        private double nivelAgua = 0; // Nivel 1 = Alto | Nivel 2 = Médio | Nivel 3 = Baixo | Nível 4 = Extra Baixo
        private double vezesNaSemana = 1;

        private double retorno = 0;

        /// <summary>
        /// Usa a máquina de lavar atribuindo o nível da água, quantidade em quilos de roupa e quantas vezes lavou roupas na semana.
        /// </summary>
        /// <param name="nivel"></param>
        /// <param name="kg"></param>
        /// <param name="vezes"></param>
        /// <returns></returns>
        public double UsarMaquina(string nivel, double kg, int vezes)
        {
            switch (nivel)
            {
                case "Alto": nivelAgua = 1;
                    break;
                case "Médio": nivelAgua = 2;
                    break;
                case "Baixo": nivelAgua = 3;
                    break;
                case "Extra Baixo": nivelAgua = 4;
                    break;
            }
            CalcularGastos(kg, vezes);
            return retorno;
        }

        private void CalcularGastos(double kg, int vezes)
        {
            double result = 0;

            quilos = kg;
            vezesNaSemana = vezes;
            while (vezesNaSemana != 0)
            {
                vezesNaSemana--;
                switch (nivelAgua.ToString())
                {
                    // Nivel de Água : Alto
                    // No nível alto, utilizamos toda a capacidade em kg da máquina de lavar.
                    case "1": result = litros * quilos;
                        break;

                    // Nível de Água : Médio
                    // No nível médio, utilizamos metade da capacidade em kg da máquina de lavar.
                    case "2": result = (litros * quilos) / 2;
                        break;

                    // Nível de Água : Baixo
                    // No nível baixo, utilizamos três quartos (3/4) da capacidade em kg da máquina de lavar.
                    case "3": result = (litros * quilos) / 4;
                        break;

                    // Nível de Água : Extra Baixo
                    // No nível extra baixo, utilizamos a menor capacidade em kg da máquina de lavar, ou, quatro quartos (4/4) da capacidade total.
                    case "4": result = (litros * quilos) / 8;
                        break;
                }
                // Arredonda resultados antes de retornar ao método chamado
                Math.Round(result, 2);
                SomarLitrosGastosNaSemana(result);
            }
        }

        public void SomarLitrosGastosNaSemana(double litros)
        {
            retorno += litros;
        }
    }
}

