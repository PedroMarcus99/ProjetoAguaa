using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ProjetoAgua.Code.Model;
using ProjetoAgua.Code.DTO;

namespace ProjetoAgua.Code.Controller
{
    class ConsumoDiarioControl
    {
        ModelMySql acessoDadosMySql = new ModelMySql();

        public string NovoConsumoDiario(DTOConsumos consumos)
        {
            string retorno;
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("chuveiroParam", consumos.Chuveiro);
                acessoDadosMySql.AdicionarParametros("descargaParam", consumos.Descarga);
                acessoDadosMySql.AdicionarParametros("torneiraParam", consumos.Torneira);
                acessoDadosMySql.AdicionarParametros("plantaParam", consumos.Plantas);
                acessoDadosMySql.AdicionarParametros("maquinaParam", consumos.MaquinaLavar);
                acessoDadosMySql.AdicionarParametros("mangueiraParam", consumos.Mangueira);
                acessoDadosMySql.AdicionarParametros("baldeParam", consumos.Balde);
                acessoDadosMySql.AdicionarParametros("idParam", consumos.idPessoaConsumo);
                acessoDadosMySql.AdicionarParametros("dataParam", consumos.Data);
                retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "sp_ConsumoDiario").ToString();
            }
            catch
            {
                retorno = "";
            }
            return retorno;
        }
    }
}
