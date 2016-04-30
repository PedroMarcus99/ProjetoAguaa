using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgua.Code.Controller.Classes;
using ProjetoAgua.Code.DTO;
using ProjetoAgua.Code.Controller;

namespace ProjetoAgua.View
{
    public partial class FrmConsumoDiario : Form
    {
        Segundos segundos = new Segundos();

        string objetoUsado = "";
        string mangueira_tipoFluxo = "";

        double somaLitrosTorneira;

        public FrmConsumoDiario()
        {
            InitializeComponent();
        }

        private void btnEnviarChv_Click(object sender, EventArgs e)
        {
            try
            {
                int hrEmSeg = segundos.HoraParaSegundos(int.Parse(udHrChuveiro.Text));
                int minEmSeg = segundos.MinutoParaSegundos(int.Parse(udMinChuveiro.Text));
                int seg = int.Parse(udSegChuveiro.Text);

                int segundosTotais = hrEmSeg + minEmSeg + seg;

                switch (objetoUsado)
                {
                    case "Chuveiro": CalculaLitrosChuveiro(segundosTotais);
                        break;

                    case "Carro": CalculaLitrosCarroMangueira(segundosTotais);
                        break;

                    case "Máquina de Lavar": CalculaLitrosMaquinaLavar();
                        break;

                    case "Plantas": CalculaLitrosPlanta(segundosTotais);
                        break;

                    case "Torneira": CalculaLitrosMangueira(segundosTotais);
                        break;

                    case "Vaso Sanitário": CalculaLitrosVasoSanitario(segundosTotais); ;
                        break;
                }
            }
            catch
            {

            }
        }

        private void CalculaLitrosChuveiro(int segundosTotais)
        {
            Chuveiro chuveiro = new Chuveiro();
            txtChuveiro.Text = chuveiro.AbrirChuveiro(segundosTotais).ToString();
        }

        private void CalculaLitrosVasoSanitario(int segundosTotais)
        {
            VasoSanitario privada = new VasoSanitario();
            txtDescarga.Text = privada.Descarga(segundosTotais).ToString();
        }

        private void CalculaLitrosMangueira(int segundosTotais)
        {
            Torneira torneira = new Torneira();
            somaLitrosTorneira += torneira.AbrirTorneira(segundosTotais);
            txtTorneira.Text = somaLitrosTorneira.ToString();
        }

        private void CalculaLitrosPlanta(int segundosTotais)
        {
            mangueira_tipoFluxo = cbFluxoAgua.Text;
            Mangueira mangueira = new Mangueira();
            txtMangueiraPlanta.Text = mangueira.UsarMangueira(segundosTotais, mangueira_tipoFluxo).ToString();
        }

        private void CalculaLitrosMaquinaLavar()
        {
            string nivelAgua = cbNivel.Text;

            int quilos = int.Parse(udKgRoupas.Text);
            int vezes = int.Parse(udVezes.Text);
            Maquina maquina = new Maquina();
            txtMaquina.Text = maquina.UsarMaquina(nivelAgua, quilos, vezes).ToString();
        }

        private void CalculaLitrosCarroMangueira(int segundosTotais)
        {
            mangueira_tipoFluxo = cbFluxoAgua.Text;
            Mangueira mangueiraCar = new Mangueira();
            txtMangueiraCar.Text = mangueiraCar.UsarMangueira(segundosTotais, mangueira_tipoFluxo).ToString();
        }

        private void FrmConsumoDiario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aguaaDataSet.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.aguaaDataSet.Pessoa);
            // TODO: This line of code loads data into the 'aguaaDataSet2.Pessoa' table. You can move, or remove it, as needed.
            cbBanheiro.Text = "Chuveiro";
        }

        private void cbBanheiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            udHrChuveiro.Text = "00";
            udMinChuveiro.Text = "00";
            udSegChuveiro.Text = "00";
            if (cbBanheiro.Text != "Máquina de Lavar")
            {
                CarregarAparenciaPadrao();

                if (cbBanheiro.Text == "Plantas" || cbBanheiro.Text == "Carro")
                {
                    CarregarAparenciaPlantasECarro();
                }
                else
                {
                    btnEnviar.Location = new Point(17, 100);
                }
                
            }
            else
            {
                CarregarAparenciaMaquinaDeLavar();
            }

            objetoUsado = cbBanheiro.Text;

            if (cbBanheiro.Text == "Torneira do Banheiro" || cbBanheiro.Text == "Torneira da Cozinha" || cbBanheiro.Text == "Torneira do Quintal")
            {
                objetoUsado = "Torneira";
            }
        }

        private void CarregarAparenciaMaquinaDeLavar()
        {
            cbNivel.Visible = true;
            lbNivel.Visible = true;

            lblMaquinaKG.Visible = true;
            udKgRoupas.Visible = true;

            udVezes.Visible = true;
            lblVezes.Visible = true;

            lblTime.Visible = false;
            lblTime.Location = new Point(13, 136);

            udHrChuveiro.Location = new Point(15, 162);
            udMinChuveiro.Location = new Point(69, 162);
            udSegChuveiro.Location = new Point(123, 162);
            udHrChuveiro.Visible = false;
            udMinChuveiro.Visible = false;
            udSegChuveiro.Visible = false;

            cbFluxoAgua.Visible = false;
            lblFluxoAgua.Visible = false;
            btnEnviar.Location = new Point(17, 147);
        }

        private void CarregarAparenciaPlantasECarro()
        {
            cbFluxoAgua.Visible = true;
            cbFluxoAgua.Location = new Point(93, 100);
            lblFluxoAgua.Visible = true;
            lblFluxoAgua.Location = new Point(9, 103);
            btnEnviar.Location = new Point(17, 130);

            udHrChuveiro.Location = new Point(15, 72);
            udMinChuveiro.Location = new Point(69, 72);
            udSegChuveiro.Location = new Point(123, 72);
        }

        private void CarregarAparenciaPadrao()
        {
            cbNivel.Visible = false;
            lbNivel.Visible = false;
            lblMaquinaKG.Visible = false;
            udKgRoupas.Visible = false;
            udVezes.Visible = false;
            lblVezes.Visible = false;
            lblTime.Visible = true;
            lblTime.Location = new Point(8, 55);
            udHrChuveiro.Location = new Point(15, 72);
            udMinChuveiro.Location = new Point(69, 72);
            udSegChuveiro.Location = new Point(123, 72);
            udHrChuveiro.Visible = true;
            udMinChuveiro.Visible = true;
            udSegChuveiro.Visible = true;
            cbFluxoAgua.Visible = false;
            lblFluxoAgua.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOConsumos dtoConsumos = new DTOConsumos();
                dtoConsumos.Descarga = Convert.ToDouble(txtDescarga.Text);
                dtoConsumos.Torneira = Convert.ToDouble(txtTorneira.Text);
                dtoConsumos.Chuveiro = Convert.ToDouble(txtChuveiro.Text);
                dtoConsumos.MaquinaLavar = Convert.ToDouble(txtMaquina.Text);
                dtoConsumos.Mangueira = Convert.ToDouble(txtMangueiraCar.Text);
                dtoConsumos.Plantas = Convert.ToDouble(txtMangueiraPlanta.Text);
                dtoConsumos.Balde = Convert.ToDouble(txtBalde.Text);

                dtoConsumos.idPessoaConsumo = Convert.ToInt32(cbPessoas.SelectedValue);

                string mes = "";

                string dia = "";

                if (DateTime.Now.Day < 10)  dia = "0" + DateTime.Now.Day;
                else dia = DateTime.Now.Day.ToString();

                if (DateTime.Now.Month < 10) mes = "0" + DateTime.Now.Month;
                else mes = DateTime.Now.Month.ToString();

                dtoConsumos.Data = dia + "/" + mes + "/" + DateTime.Now.Year;

                ConsumoDiarioControl consumoControl = new ConsumoDiarioControl();
                MessageBox.Show(consumoControl.NovoConsumoDiario(dtoConsumos));
            }
            catch
            {

            }
        }

        private void cbBanheiro_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargaClean_Click(object sender, EventArgs e)
        {
            txtDescarga.Text = 0.ToString();
        }

        private void btnChuveiroClean_Click(object sender, EventArgs e)
        {
            txtChuveiro.Text = 0.ToString();
        }

        private void btnMangueiraCarClean_Click(object sender, EventArgs e)
        {
            txtMangueiraCar.Text = 0.ToString();
        }

        private void btnBaldeClean_Click(object sender, EventArgs e)
        {
            txtBalde.Text = 0.ToString();
        }

        private void btnMaquinaClean_Click(object sender, EventArgs e)
        {
            txtMaquina.Text = 0.ToString();
        }

        private void btnTorneiraClean_Click(object sender, EventArgs e)
        {
            txtTorneira.Text = 0.ToString();
            somaLitrosTorneira = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDescarga.Text = 0.ToString();
            txtChuveiro.Text = 0.ToString();
            txtMaquina.Text = 0.ToString();
            txtBalde.Text = 0.ToString();
            txtMangueiraCar.Text = 0.ToString();
            txtTorneira.Text = 0.ToString();
            txtMangueiraPlanta.Text = 0.ToString();

            somaLitrosTorneira = 0;
        }

        private void btnMangueiraPlantasClean_Click(object sender, EventArgs e)
        {
            txtMangueiraPlanta.Text = 0.ToString();
        }

        private void orderToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pessoaTableAdapter.Order(this.aguaaDataSet.Pessoa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pessoaTableAdapter.Fill(this.aguaaDataSet.Pessoa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pessoaTableAdapter.OrdernarPadrao(this.aguaaDataSet.Pessoa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
