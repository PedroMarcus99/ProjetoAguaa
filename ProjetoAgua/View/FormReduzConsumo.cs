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
    public partial class FormReduzConsumo : Form
    {
        DTOConsumo consumo = new DTOConsumo();
        ConsumoControl consumoctrl = new ConsumoControl();

        FrmMenuPrincipal formCompartilhado = new FrmMenuPrincipal();

        public FormReduzConsumo()
        {
            InitializeComponent();
        }

        public FormReduzConsumo(FrmMenuPrincipal form)
        {
            formCompartilhado = form;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            consumo.Consumo = Convert.ToDouble(txtGastos.Text);

            consumoctrl.InserirMeuNovoConsumo(consumo);

            txtResultado.Text = consumoctrl.ReceberNovoGasto().ToString();
            MessageBox.Show(consumoctrl.MostrarPorcentagem(consumo).ToString() + "%");

            CarregarValoresFormInicio();
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
    }
}
