using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAgua.DTO;

namespace ProjetoAgua.Controller
{
    class DatasControl
    {
        /// <summary>
        /// Recupera a data de início do Projeto
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string DataInicioProjeto(DTODatas data)
        {
            return data.DataInicio;
        }

        /// <summary>
        /// Recupera a data atual em comparação a data de início
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string DataHojeProjeto(DTODatas data)
        {
            return data.DataHoje;
        }
    }
}
