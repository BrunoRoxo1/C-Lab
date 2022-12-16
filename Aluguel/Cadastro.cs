using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aluguel
{
    public partial class Tn_Cadastro : Form
    {
        public Tn_Cadastro()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tn_Cliente principal = new tn_Cliente();
            principal.ShowDialog();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tn_Jogo principal = new tn_Jogo();
            principal.ShowDialog();
        }

        private void produtoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tn_Produtora principal = new tn_Produtora();
            principal.ShowDialog();

        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tn_Genero principal = new tn_Genero();
            principal.ShowDialog();

        }
    }
}
