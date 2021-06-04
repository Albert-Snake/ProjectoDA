using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_de_DA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende mesmo Sair?", "SAIR DO PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promotores myForm = new Promotores();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void gestãoDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionarios myForm = new formFuncionarios();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }
    }
}
