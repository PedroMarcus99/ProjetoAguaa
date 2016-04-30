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
    public partial class FormAnalise : Form
    {
        DTOConsumo dtoconsumo = new DTOConsumo();
        AnaliseControl controlanalise = new AnaliseControl();

        public FormAnalise()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblConsumosRestantes.Text = "Consumos restantes para análise: ";
            dtoconsumo.Consumo = Convert.ToDouble(txtConsumo.Text);
            controlanalise.InserirConsumo(dtoconsumo);
            int faltam = controlanalise.MostrarInsercoesRestantes();           
            lblConsumosRestantes.Text += faltam;
            lblMedia.Text = controlanalise.SolicitarMedia().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAnalise_Load(object sender, EventArgs e)
        {
            int faltam = controlanalise.MostrarInsercoesRestantes();
            lblConsumosRestantes.Text += faltam;
        }
    }
}
