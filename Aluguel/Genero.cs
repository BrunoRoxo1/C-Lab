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
    public partial class tn_Genero : Form
    {
        public tn_Genero()
        {
            InitializeComponent();
        }

        private void tbl_GeneroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_GeneroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_aluguelDataSet);

        }

        private void tn_Genero_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_Genero'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_GeneroTableAdapter.Fill(this.db_aluguelDataSet.tbl_Genero);

        }
    }
}
