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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_aluguelDataSet.tbl_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_clienteTableAdapter.Fill(this.db_aluguelDataSet.tbl_cliente);

        }
    }
}
