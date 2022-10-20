using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class JanelaCadastrar : Form
    {

        private Pedido _pedido;

        private static JanelaCadastrar janela;

        public JanelaCadastrar()
        {
            InitializeComponent();

            _pedido = new Pedido();
           

        }
        public static JanelaCadastrar GetInstance()
        {

            if (janela == null || janela.IsDisposed)
            {

                janela = new JanelaCadastrar();
            }

            return janela;
        }




        private void btnAcrescentar_Click(object sender, EventArgs e)
        {

            Item item = new Item(Convert.ToInt16(nudQuant.Value), (Produto)lstPesquisa.SelectedItem);
            
            _pedido.AdicionarItem(item);
            lstItens.Items.Add(item);
            lblTotal.Text = "R$ " + _pedido.CalcularTotal();
            lstPesquisa.Items.Clear();
            txtCodigo.Text = null;
            txtNome.Text = null;
            nudQuant.Value = 1;
            txtCodigo.Focus();
           
            

        }

        private void txtNome_TextChanged(object sender, EventArgs e)    
        {
            
            lstPesquisa.DataSource = BancoDadosSimulado.LocalizarProdutoPorParteNome(txtNome.Text);

            BotaoAcrescentar();

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            {
                lstPesquisa.DataSource = null;
                lstPesquisa.Items.Clear();

                if (txtCodigo.Text != String.Empty && Regex.IsMatch(txtCodigo.Text, "^[0-9]+$"))
                {

                    if (BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)) != null)
                    {
                        lstPesquisa.Items.Clear();
                        lstPesquisa.Items.Add(BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)));

                        lstPesquisa.SelectedIndex = 0;
                    }
                }
                else
                {
                    lstPesquisa.DataSource = null;
                }

                BotaoAcrescentar();
                

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            if (lstItens.Items.Count > 0)
            {
                Pedido pedido = new Pedido();
                foreach (var item in _pedido.Itens)
                {
                    pedido.AdicionarItem(item);
                }

                BancoDadosSimulado.Pedidos.Add(pedido);

                lstItens.Items.Clear();
                _pedido.Itens.Clear();
                lblTotal.Text = "R$ ---";
                txtCodigo.Focus();
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
           

        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
          

        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BotaoAcrescentar()
        {
            if(lstPesquisa.Items.Count > 0)
            {
                btnAcrescentar.Enabled = true;
            }
            else
            {
                btnAcrescentar.Enabled = false;
            }
        }
    }
}
       

