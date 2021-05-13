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
        }

        private void lerDados()
        {
            bsPromotores.DataSource = camara.PromotorSet.ToList<Promotor>();
            listBox1.DataSource = bsPromotores;
            listBox1.SelectedIndex = -1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //camara.PromotorSet.Add(new Promotor(tbx));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
            
                Promotor promotor = new Promotor();
                promotor = (Promotor)listBox1.SelectedItem;
                tbxNomePromotor.Text = promotor.Nome;
                tbxNIFPromotor.Text = Convert.ToString(promotor.NIF);
                //tbxNomePromotor.Text = promotor.Nome;
                tbxEmailPromotor.Text = promotor.Email;
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;
                tbxNomePromotor.ReadOnly = true;
                tbxNIFPromotor.ReadOnly = true;
                //tbxNomePromotor.Text = promotor.Nome;
                tbxEmailPromotor.ReadOnly = true;
            }
            else 
            {
                tbxNomePromotor.Text = "";
                tbxNIFPromotor.Text = "";
                //tbxNomePromotor.Text = promotor.Nome;
                tbxEmailPromotor.Text = "";
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;
                tbxNomePromotor.ReadOnly = false;
                tbxNIFPromotor.ReadOnly = false;
                //tbxNomePromotor.Text = promotor.Nome;
                tbxEmailPromotor.ReadOnly = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            camara.Dispose();
            this.Close();       
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende alterar os dados deste Promotor?", "Alterar dados do Promotor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;
                tbxNomePromotor.ReadOnly = false;
                tbxNIFPromotor.ReadOnly = false;
                //tbxNomePromotor.Text = promotor.Nome;
                tbxEmailPromotor.ReadOnly = false;
            }
        }
    }
}
