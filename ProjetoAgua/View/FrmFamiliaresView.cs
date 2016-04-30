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
    public partial class FrmFamiliaresView : Form
    {
        public FrmFamiliaresView()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text != "Offline")
            {
                FrmNovoFamiliar abrir = new FrmNovoFamiliar();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("O Banco de Dados não está disponível no momento, tente novamente mais tarde", "System");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFamiliares.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma pessoa selecionada.");
                    return;
                }
                DTOPessoa pessoaSelecionada = (dataGridViewFamiliares.SelectedRows[0].DataBoundItem as DTOPessoa);
                FrmNovoFamiliar frmNovoFamiliar = new FrmNovoFamiliar(CRUD.Alterar, pessoaSelecionada);
                DialogResult resultado = frmNovoFamiliar.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    AtualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro inesperado aconteceu, algo está errado! :(\n"+ex.Message, "System");
            }
        }

        private void FrmFamiliaresView_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Offline";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("O Banco de Dados não está disponível no momento, tente novamente mais tarde\n\n\n" + ex.Message, "System");
            }
        }
        public void AtualizarGrid()
        {
            PessoaCollection pessoaCollection = new PessoaCollection();
            PessoaControl pessoaCtrl = new PessoaControl();

            pessoaCollection = pessoaCtrl.ConsultarPorNome(txtPesquisaNome.Text);
            dataGridViewFamiliares.DataSource = null;
            dataGridViewFamiliares.DataSource = pessoaCollection;
            dataGridViewFamiliares.Update();
            dataGridViewFamiliares.Refresh();

            lblStatus.Text = "Online";
            lblStatus.ForeColor = Color.Green;
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblStatus.Text != "Offline")
                {
                    AtualizarGrid();
                }
            }
            catch
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewFamiliares.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma pessoa selecionada.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            DTOPessoa pessoaSelecionada = (dataGridViewFamiliares.SelectedRows[0].DataBoundItem as DTOPessoa);
            PessoaControl pessoaControl = new PessoaControl();
            string retorno = pessoaControl.PessoaDeletar(pessoaSelecionada);
            try
            {
                MessageBox.Show(retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("O Banco de Dados não está disponível no momento, tente novamente mais tarde/n/n/n" + ex.Message, "System");
            }
        }
    }
}
