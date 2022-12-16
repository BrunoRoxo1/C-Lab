using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            textNome.Text = "Bruno";
        }

        private void btnAlterarCor_Click(object sender, EventArgs e)
        {
            label5.Text = "Trocou";
            label5.ForeColor= System.Drawing.Color.Green;
            
        }
    }
}
