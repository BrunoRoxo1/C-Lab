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
    public partial class tn_Jogo : Form
    {
        public tn_Jogo()
        {
            InitializeComponent();
        }

        private void tbl_JogoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_JogoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }

        private void tn_Jogo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_Jogo'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_JogoTableAdapter.Fill(this.db_aluguelDataSet.tbl_Jogo);

        }

        private void nome_GeneroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void avaliacao_JogoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_ProdutoraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numCopia_JogoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_JogoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
