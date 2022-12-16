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
    public partial class tn_Cliente : Form
    {
        public tn_Cliente()
        {
            InitializeComponent();
        }

        private void tbl_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_clienteTableAdapter.Fill(this.db_aluguelDataSet.tbl_cliente);
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_clienteTableAdapter.Fill(this.db_aluguelDataSet.tbl_cliente);
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_clienteTableAdapter.Fill(this.db_aluguelDataSet.tbl_cliente);
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet1.tbl_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_clienteTableAdapter.Fill(this.db_aluguelDataSet.tbl_cliente);

        }

        private void tbl_clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }

        private void tbl_clienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }

        private void tbl_clienteBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }
    }
}
