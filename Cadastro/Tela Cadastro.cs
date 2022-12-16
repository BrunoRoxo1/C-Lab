using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Tl_Cadastro : Form
    {
        public Tl_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastar_Click(object sender, EventArgs e)
        {

        }

        private void tbl_JogoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_JogoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_jogosDataSet1);

        }

        private void Tl_Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_jogosDataSet1.tbl_Jogo'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_JogoTableAdapter.Fill(this.db_jogosDataSet1.tbl_Jogo);

        }

        private void menJogos_Click(object sender, EventArgs e)
        {
            frJogos principal = new frJogos();
            principal.ShowDialog();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frGenero principal= new frGenero();
            principal.Show();
        }

        private void produtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProdutor principal = new frProdutor();
            principal.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 janelaform4 = new Form1();
            janelaform4.ShowDialog();
        }
    }
}
