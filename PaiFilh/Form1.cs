using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaiFilh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void janelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form2 novaMDIFilha = new Form2();

            novaMDIFilha.MdiParent = this;
            novaMDIFilha.Show();   
        }
    }
}
