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
    public partial class frGenero : Form
    {
        public frGenero()
        {
            InitializeComponent();
        }

        private void tbl_GeneroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_GeneroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_jogosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_jogosDataSet.tbl_Genero'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_GeneroTableAdapter.Fill(this.db_jogosDataSet.tbl_Genero);

        }
    }
}
