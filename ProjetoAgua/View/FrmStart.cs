using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgua.DTO;
using ProjetoAgua.Controller;
using ProjetoAgua.Code.DTO;
using ProjetoAgua.Code.Controller;

namespace ProjetoAgua.View
{
    public partial class FrmStart : Form
    {

        DTODatas data = new DTODatas();
        DatasControl datactrl = new DatasControl();       

        public FrmStart()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            data.DataInicio = "17/2/2016";
            data.DataHoje = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            lbInicioProjeto.Text = datactrl.DataInicioProjeto(data);
            lbDataHoje.Text = datactrl.DataHojeProjeto(data);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //FrmConsumoDiario abrir = new FrmConsumoDiario();
            //abrir.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOPessoa tryEntrarDTO = new DTOPessoa();

                tryEntrarDTO.Nome = txtUsuario.Text;
                tryEntrarDTO.Senha = txtSenha.Text;

                PessoaControl control = new PessoaControl();
                string permitir = control.PessoaEntrar(tryEntrarDTO);
                if (permitir == "Acesso Permitido")
                {
                    FrmMenuPrincipal abrir = new FrmMenuPrincipal();
                    abrir.Show();

                    this.Hide();
                    lblErroLogin.Visible = false;
                }
                else
                {
                    lblErroLogin.Text = "Oops! O usuário ou senha estão incorretos!";
                    lblErroLogin.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O Banco de Dados pode estar offline :(" + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ErroLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            ErroLogin();
        }

        private void ErroLogin()
        {
            lblErroLogin.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmNovoFamiliar abrir = new FrmNovoFamiliar();
            abrir.Show();
        }
    }
}
