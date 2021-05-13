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
    public partial class Promotores : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public Promotores()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDados();
            listBox1.SelectedIndex = -1;
        }

        private void lerDados()
        {
            bsPromotores.DataSource = camara.PromotorSet.ToList<Promotor>();
            listBox1.DataSource = bsPromotores;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //camara.PromotorSet.Add(new Promotor(tbx));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            promotor = (Promotor)listBox1.SelectedItem;
            //textBox1.Text = promotor.Email;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            camara.Dispose();
            this.Close();       
        }
    }
}
