using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjetoAgua.Code.DTO;
using ProjetoAgua.Code.Model;

namespace ProjetoAgua.Code.Controller
{
    class PessoaControl
    {
        ModelMySql acessoDadosMySql = new ModelMySql();

        /// <summary>
        /// Adiciona uma nova pessoa no Banco de Dados
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
                        
        public string PessoaInserir(DTOPessoa pessoa)
        {
            string retorno;
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("nomeParam", pessoa.Nome);
                acessoDadosMySql.AdicionarParametros("idadeParam", pessoa.Idade);
                acessoDadosMySql.AdicionarParametros("sexoParam", pessoa.Sexo);
                acessoDadosMySql.AdicionarParametros("senhaParam", pessoa.Senha);
                retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "sp_PessoaInserir").ToString();
            }
            catch (Exception ex)
            {
                retorno = "Banco " + ex.Message;

            }
            return retorno;
        }

        /// <summary>
        /// Altera uma pessoa existente no Banco de Dados.
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        public string PessoaAlterar(DTOPessoa pessoa)
        {
            string retorno;
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idParam", pessoa.Id);
                acessoDadosMySql.AdicionarParametros("nomeParam", pessoa.Nome);
                acessoDadosMySql.AdicionarParametros("idadeParam", pessoa.Idade);
                acessoDadosMySql.AdicionarParametros("sexoParam", pessoa.Sexo);
                retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "sp_PessoaAlterar").ToString();
            }
            catch (Exception ex)
            {
                retorno = "Banco " + ex.Message;
            }
            return retorno;
        }

        /// <summary>
        /// Remove os dados sobre uma pessoa no Banco de Dados.
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        public string PessoaDeletar(DTOPessoa pessoa)
        {
            string retorno;
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idParam", pessoa.Id);
                retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "sp_PessoaExcluir").ToString();
            }
            catch (Exception ex)
            {
                retorno = "Banco " + ex.Message;
            }
            return retorno;
        }

        public string PessoaDataNascimento(DTOPessoa pessoa)
        {
            string retorno;
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idParam", pessoa.Id);
                retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "sp_PessoaDataNasc").ToString();
            }
            catch (Exception ex)
            {
                retorno = "Banco " + ex.Message;
            }
            return retorno;
        }

        /// <summary>
        /// Procura os dados das pessoas mediante uma pesquisa.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public PessoaCollection ConsultarPorNome(string nome)
        {
            try
            {
                PessoaCollection pessoaCollection = new PessoaCollection();
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("nomeParam", nome);

                DataTable dataTableCandidato = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "sp_PessoaSelecionar");

                foreach (DataRow linha in dataTableCandidato.Rows)
                {
                    DTOPessoa pessoa = new DTOPessoa();

                    pessoa.Id = Convert.ToInt16(linha["idPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Idade = Convert.ToString(linha["Idade"]);
                    pessoa.Sexo = Convert.ToString(linha["Sexo"]);
                    pessoa.Total = Convert.ToDouble(linha["TotalGastos"]);
                    pessoa.Porcentagem = Convert.ToDecimal(linha["TotalPorcentagem"]);
                    pessoaCollection.Add(pessoa);
                }
                return pessoaCollection;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar por Nome. Detalhes: " + exception.Message);
            }
        }

        public string PessoaEntrar(DTOPessoa pessoa)
        {
            string retorno;
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("nomeParam", pessoa.Nome);
                acessoDadosMySql.AdicionarParametros("senhaParam", pessoa.Senha);
                retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "sp_LoginEntrar").ToString();
            }
            catch 
            {
                retorno = "";
            }
            return retorno;
        }
    }
}
