using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class JanelaPedidos : Form
    {

        private static JanelaPedidos janela;
        public JanelaPedidos()
        {
            InitializeComponent();

            lstPedidos.DataSource = BancoDadosSimulado.Pedidos;
        }

        public static JanelaPedidos GetInstance()
        {

            if (janela == null || janela.IsDisposed)
            {

                janela = new JanelaPedidos();
            }

            return janela;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {

            JanelaCadastrar wcadastro = JanelaCadastrar.GetInstance();
            wcadastro.MdiParent = this.MdiParent;
            wcadastro.WindowState = FormWindowState.Normal;
            wcadastro.Show();
        }
        
        private void lstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPedidos.DataSource = BancoDadosSimulado.Pedidos;
        }
        

    }
}
