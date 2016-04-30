using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgua.Code.Controller;
using ProjetoAgua.Code.DTO;

namespace ProjetoAgua.View
{
    public partial class FrmNovoFamiliar : Form
    {
        CRUD acaoNaTelaSelecionada;
        string nome = "";
        public FrmNovoFamiliar()
        {
            InitializeComponent();
        }
        public FrmNovoFamiliar(CRUD crud, DTOPessoa pessoa)
        {
            InitializeComponent();
            acaoNaTelaSelecionada = crud;
            switch (crud)
            {
                case CRUD.Alterar:
                    Text = "Alterar "+ pessoa.Nome;
                    PreencheFrm(pessoa);
                    break;
                case CRUD.Consultar:
                    Text = "Consultar Pessoa";
                    PreencheFrm(pessoa);
                    break;
                case CRUD.Deletar:
                    Text = "Excluir Pessoa";
                    break;
                case CRUD.Inserir:
                    Text = "Inserir Pessoa";
                    break;
                default:
                    break;
            }
        }

        private void PreencheFrm(DTOPessoa pessoa)
        {            
            txtNome.Text = pessoa.Nome;
            if (pessoa.Sexo == "Masculino")
            {
                radioMasc.Checked = true;
            }
            else
            {
                radioFem.Checked = true;
            }
            lblCodigo.Text = pessoa.Id.ToString();

            PessoaControl control = new PessoaControl();

            dateNascimento.Text = pessoa.Idade;
            txtSenha.Enabled = false;
            txtSenhaConfirma.Enabled = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TransformarNome();

            if (acaoNaTelaSelecionada == CRUD.Alterar)
            {
                SalvarDadosAlterados();
            }
            else
            {
                SalvarDadosInseridos();             
            }
        }

        private void TransformarNome()
        {
            txtNome.CharacterCasing = CharacterCasing.Lower;
            nome = txtNome.Text;
            char[] arrayCharNome = nome.ToCharArray();
            nome = "";
            nome += Char.ToUpper(arrayCharNome[0]);
            for (int indice = 1; indice < arrayCharNome.Length; indice++)
            {
                nome += arrayCharNome[indice];
            }
            txtNome.CharacterCasing = CharacterCasing.Normal;
        }

        private void SalvarDadosAlterados()
        {
            DTOPessoa pessoa = new DTOPessoa();
            PessoaControl control = new PessoaControl();

            pessoa.Idade = dateNascimento.Value.ToString();

            pessoa.Nome = txtNome.Text;
            HomemOuMulher(pessoa);

            pessoa.Id = int.Parse(lblCodigo.Text);

            DialogResult resultado = MessageBox.Show(control.PessoaAlterar(pessoa), "Alterar Familiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                LimparCampos();
            }
        }

        private void SalvarDadosInseridos()
        {
            if (txtSenha.Text.Length < 4 || txtSenha.Text.Length > 16)
            {
                MessageBox.Show("A senha deve ter entre 4 e 16 caracteres, tente novamente", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
            }
            else
            {
                if (txtSenha.Text != txtSenhaConfirma.Text)
                {
                    MessageBox.Show("As senhas nao se coincidem", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenhaConfirma.BackColor = Color.Tomato;
                }
                else
                {
                    txtSenhaConfirma.BackColor = Color.White;
                    try
                    {
                        DTOPessoa pessoa = new DTOPessoa();
                        PessoaControl control = new PessoaControl();

                        string theDate = dateNascimento.Value.ToShortDateString();

                        theDate.Replace('/', '-');

                        pessoa.Idade = theDate;

                        pessoa.Nome = nome;

                        HomemOuMulher(pessoa);

                        pessoa.Senha = txtSenha.Text;
                        DialogResult resultado = MessageBox.Show(control.PessoaInserir(pessoa), "Novo Familiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (resultado == DialogResult.OK)
                        {
                            LimparCampos();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível armazenar os dados preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void HomemOuMulher(DTOPessoa pessoa)
        {
            if (radioMasc.Checked == true)
            {
                pessoa.Sexo = radioMasc.Text;
            }
            else
            {
                pessoa.Sexo = radioFem.Text;
            }
        }


        private void LimparCampos()
        {
            txtNome.Clear();
            txtSenha.Clear();
            txtSenhaConfirma.Clear();
            radioMasc.Checked = false;
            radioFem.Checked = false;
            dateNascimento.Text = "31/12/2013";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmNovoFamiliar_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar(e);
        }

        private static void Validar(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar)) e.Handled = false;

                else if (char.IsControl(e.KeyChar)) e.Handled = false;

                else if (char.IsSeparator(e.KeyChar)) e.Handled = false;

                else e.Handled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNome.Text;

            if (!(texto.Equals('%') || texto.Equals('_') || texto.Equals('-') || texto.Equals('@')))
            {
                txtNome.Text = texto;
            }
        }
    }
}
