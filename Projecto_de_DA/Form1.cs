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
        public Form1(string tipoperfil, string utilizador)
        {
            InitializeComponent();
            lblTipoPerfil.Text = tipoperfil;
            lblUtilizador.Text = utilizador;
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende mesmo Sair?", "SAIR DO PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            Login myForm = new Login();
            myForm.Show();
            this.Hide();
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

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTipoDocumento myForm = new formTipoDocumento();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDocumentos myForm = new formDocumentos();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void tiposProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTipoProcessos myForm = new formTipoProcessos();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProcessos myForm = new formProcessos();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void tiposDeProjectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTipoProjecto myForm = new formTipoProjecto();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void especialistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEspecialista myForm = new formEspecialista();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();

            
        }

        private void atribuirProjectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProjectoAtribuido myForm = new formProjectoAtribuido();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPareceres myForm = new formPareceres();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void gestaoDeProjectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProjectos myForm = new formProjectos();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }
    }
}
