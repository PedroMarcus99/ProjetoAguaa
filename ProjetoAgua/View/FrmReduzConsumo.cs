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
    public partial class FrmReduzConsumo : Form
    {
        DTOConsumo consumo = new DTOConsumo();
        ConsumoControl consumoctrl = new ConsumoControl();

        FrmMenuPrincipal formCompartilhado = new FrmMenuPrincipal();

        public FrmReduzConsumo()
        {
            InitializeComponent();
        }

        public FrmReduzConsumo(FrmMenuPrincipal form)
        {
            formCompartilhado = form;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {              
                if (txtGastos.Text == "") txtGastos.Text = "0";
                consumo.Consumo = Convert.ToDouble(txtGastos.Text);

                consumoctrl.InserirMeuNovoConsumo(consumo);

                txtResultado.Text = consumoctrl.ReceberNovoGasto().ToString();
                MessageBox.Show("Sugerimos que reduza seu consumo em " + consumoctrl.MostrarPorcentagem(consumo).ToString() + "%");

                CarregarValoresFormInicio();
            }
            catch
            {

            }
        }

        private void CarregarValoresFormInicio()
        {
            formCompartilhado.lblStatus.Text = formCompartilhado.ChecarAumentoReducao(Convert.ToDouble(txtGastos.Text));
            formCompartilhado.lblStatus.Refresh();
            formCompartilhado.ArmazenarInsercaoParaComparar(Convert.ToDouble(txtGastos.Text));

            formCompartilhado.ArmazenarInsercaoParaSomar(Convert.ToDouble(txtGastos.Text));
            formCompartilhado.lblValor.Text = formCompartilhado.ReceberNovaSoma().ToString();
            formCompartilhado.lblValor.Refresh();
        }

        private void txtGastos_TextChanged(object sender, EventArgs e)
        {
            if (txtGastos.TextLength == 6)
            {
                txtGastos.BackColor = Color.Red;
            }
            else
            {
                txtGastos.BackColor = Color.White;
            }
        }

        private void txtGastos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) e.Handled = false;

                else if (char.IsControl(e.KeyChar)) e.Handled = false;

                else if (char.IsSeparator(e.KeyChar)) e.Handled = false;

                else e.Handled = true;

                if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            catch
            {

            }
        }

        private void txtGastos_Click(object sender, EventArgs e)
        {
            txtGastos.Clear();
        }        
    }
}
