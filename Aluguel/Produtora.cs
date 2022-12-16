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
    public partial class tn_Produtora : Form
    {
        public tn_Produtora()
        {
            InitializeComponent();
        }

        private void tbl_ProdutoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProdutoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }

        private void tn_Produtora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_Produtora'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoraTableAdapter.Fill(this.db_aluguelDataSet.tbl_Produtora);

        }
    }
}
