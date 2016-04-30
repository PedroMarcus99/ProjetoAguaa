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

namespace ProjetoAgua.View
{
    public partial class FrmGreatTests : Form
    {
        Torneira torneira = new Torneira();
        Chuveiro chuveiro = new Chuveiro();
        string consumos = "";

        int vezes;
        double resultadoFinal;

        public FrmGreatTests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tempo = int.Parse(textBox1.Text);
                //consumos = torneira.AbrirTorneira(tempo);
                label1.Text = "Entre " + consumos[0] + "L e " + consumos[1] + "L";
            }
            catch
            {
                //int tempo = 0;
                //consumos = torneira.AbrirTorneira(tempo);
                // label1.Text = "Entre " + consumos[0] + "L e " + consumos[1] + "L";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tempo = int.Parse(textBox2.Text);
                label2.Text = "Total: " + chuveiro.AbrirChuveiro(tempo);
            }
            catch
            {
                int tempo = 0;
                label2.Text = "Total: " + chuveiro.AbrirChuveiro(tempo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vezes != 0)
            {
                int segundos = int.Parse(textBox3.Text);
                resultadoFinal += chuveiro.AbrirChuveiro(segundos);
                label3.Text = resultadoFinal.ToString() + "Litros";
                vezes--;
            }
            else
            {
                MessageBox.Show("Fim");
                resultadoFinal = 0;
                vezes = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vezes = int.Parse(domainUpDown1.Text);
        }
    }
}
