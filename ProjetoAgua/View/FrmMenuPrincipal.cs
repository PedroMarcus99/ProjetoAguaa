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

namespace ProjetoAgua.View
{
    public partial class FrmMenuPrincipal : Form
    {
        ArmazenarControl histcontrol = new ArmazenarControl();
        DTOHistorico dtohist = new DTOHistorico();
        FrmStart form = new FrmStart();

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            // this.FormBorderStyle =;
        }

        // Métodos que Interagem com o FormReduzConsumo, trazendo ao FormInicio as informações
        // necessárias para a janela do Usuário

        public void ArmazenarInsercaoParaSomar(double valortxt)
        {
            histcontrol.InserirNoHistorico(dtohist, valortxt); //Insere o valor textbox do FormReduz no Histórico do FormInicio
        }

        public double ReceberNovaSoma()
        {
            return histcontrol.CarregarHistorico(dtohist); // Retorna ao FormInicio o total da soma
        }

        public void ArmazenarInsercaoParaComparar(double valortxt)
        {
            histcontrol.InserirNaInsercao(dtohist, valortxt);
        }

        public double ReceberNovoValor()
        {
            return histcontrol.CarregarInsercao(dtohist);
        }

        public string ChecarAumentoReducao(double valor){
            return histcontrol.ConferirAumentoDeConsumo(dtohist, valor);
        }      

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            lblValor.Text = histcontrol.CarregarHistorico(dtohist).ToString();
        }

        private void novoConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReduzConsumo abrir = new FrmReduzConsumo(this);
            abrir.Show();
        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();   
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void analisarConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnalise abrir = new FrmAnalise();
            abrir.Show();
        }

        private void tsmenuNovoFamiliar_Click(object sender, EventArgs e)
        {            
            FrmFamiliaresView abrir = new FrmFamiliaresView();
            abrir.Show();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consumoDiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsumoDiario abrir = new FrmConsumoDiario();
            abrir.Show();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosed(e);
        }
    }
}
