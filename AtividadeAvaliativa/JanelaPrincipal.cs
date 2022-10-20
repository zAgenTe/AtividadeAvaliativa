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
    public partial class JanelaPrincipal : Form
    {

        private static JanelaPrincipal janela;
        public JanelaPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

        public static JanelaPrincipal GetInstance()
        {

            if (janela == null || janela.IsDisposed)
            {

                janela = new JanelaPrincipal();
            }

            return janela;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaPedidos wpedidos = JanelaPedidos.GetInstance();
            wpedidos.MdiParent = this;
            wpedidos.WindowState = FormWindowState.Normal;
            wpedidos.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaProduto wprodutos = JanelaProduto.GetInstance();
            wprodutos.MdiParent = this;
            wprodutos.WindowState = FormWindowState.Normal;
            wprodutos.Show();
        }
    }
}
