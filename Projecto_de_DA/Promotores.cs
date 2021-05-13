﻿using System;
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
            if (tbxNomePromotor.ReadOnly == true)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                //Torna as textboxes possiveis de se escrever
                tbxNomePromotor.ReadOnly = false;
                tbxNIFPromotor.ReadOnly = false;
                tbxMoradaPromotor.ReadOnly = false;
                tbxEmailPromotor.ReadOnly = false;
                tbxTelemovelPromotor.ReadOnly = false;
                tbxCodigoAcessoPromotor.ReadOnly = false;
                tbxSenhaPromotor.ReadOnly = false;

                //torna a propriedade UseSystemPassordChar off
                tbxCodigoAcessoPromotor.UseSystemPasswordChar = false;
                tbxSenhaPromotor.UseSystemPasswordChar = false;

                //preencher as textboxes com os valores nulos
                tbxNomePromotor.Text = "";
                tbxNIFPromotor.Text = "";
                tbxMoradaPromotor.Text = "";
                tbxEmailPromotor.Text = "";
                tbxTelemovelPromotor.Text = "";
                tbxCodigoAcessoPromotor.Text = "";
                tbxSenhaPromotor.Text = "";
            }
            else 
            {
                camara.PromotorSet.Add(new Promotor(Convert.ToInt32(tbxNIFPromotor.Text), tbxNomePromotor.Text, tbxMoradaPromotor.Text, tbxTelemovelPromotor.Text, tbxEmailPromotor.Text, tbxCodigoAcessoPromotor.Text, tbxSenhaPromotor.Text));
                camara.SaveChanges();
                lerDados();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
            
                Promotor promotor = new Promotor();
                promotor = (Promotor)listBox1.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                tbxNomePromotor.Text = promotor.Nome;
                tbxNIFPromotor.Text = Convert.ToString(promotor.NIF);
                tbxMoradaPromotor.Text = promotor.Morada;
                tbxEmailPromotor.Text = promotor.Email;
                tbxTelemovelPromotor.Text = promotor.Telemovel;
                tbxCodigoAcessoPromotor.Text = promotor.CodigoAcesso;
                tbxSenhaPromotor.Text = promotor.Senha;

                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                //Torna as textboxes impossiveis de se escrever
                tbxNomePromotor.ReadOnly = true;
                tbxNIFPromotor.ReadOnly = true;
                tbxMoradaPromotor.ReadOnly = true;
                tbxEmailPromotor.ReadOnly = true;
                tbxTelemovelPromotor.ReadOnly = true;
                tbxCodigoAcessoPromotor.ReadOnly = true;
                tbxSenhaPromotor.ReadOnly = true;

                //torna a propriedade UseSystemPassordChar on
                tbxCodigoAcessoPromotor.UseSystemPasswordChar = true;
                tbxSenhaPromotor.UseSystemPasswordChar = true;
            }
            else 
            {
                //preencher as textboxes com os valores nulos
                tbxNomePromotor.Text = "";
                tbxNIFPromotor.Text = "";
                tbxMoradaPromotor.Text = "";
                tbxEmailPromotor.Text = "";
                tbxTelemovelPromotor.Text = "";
                tbxCodigoAcessoPromotor.Text = "";
                tbxSenhaPromotor.Text = "";

                //altera o icon para desbloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                //Torna as textboxes possiveis de se escrever
                tbxNomePromotor.ReadOnly = false;
                tbxNIFPromotor.ReadOnly = false;
                tbxMoradaPromotor.ReadOnly = false;
                tbxEmailPromotor.ReadOnly = false;
                tbxTelemovelPromotor.ReadOnly = false;
                tbxCodigoAcessoPromotor.ReadOnly = false;
                tbxSenhaPromotor.ReadOnly = false;

                //torna a propriedade UseSystemPassordChar off
                tbxCodigoAcessoPromotor.UseSystemPasswordChar = false;
                tbxSenhaPromotor.UseSystemPasswordChar = false;


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

                //Torna as textboxes possiveis de se escrever
                tbxNomePromotor.ReadOnly = false;
                tbxNIFPromotor.ReadOnly = false;
                tbxMoradaPromotor.ReadOnly = false;
                tbxEmailPromotor.ReadOnly = false;
                tbxTelemovelPromotor.ReadOnly = false;
                tbxCodigoAcessoPromotor.ReadOnly = false;
                tbxSenhaPromotor.ReadOnly = false;

                //torna a propriedade UseSystemPassordChar off
                tbxCodigoAcessoPromotor.UseSystemPasswordChar = false;
                tbxSenhaPromotor.UseSystemPasswordChar = false;
            }
            //else
            //{
            //    btnDesbloquear.BackgroundImage = Properties.Resources._lock;

            //    //Torna as textboxes impossiveis de se escrever
            //    tbxNomePromotor.ReadOnly = true;
            //    tbxNIFPromotor.ReadOnly = true;
            //    tbxMoradaPromotor.ReadOnly = true;
            //    tbxEmailPromotor.ReadOnly = true;
            //    tbxTelemovelPromotor.ReadOnly = true;
            //    tbxCodigoAcessoPromotor.ReadOnly = true;
            //    tbxSenhaPromotor.ReadOnly = true;

            //    //torna a propriedade UseSystemPassordChar on
            //    tbxCodigoAcessoPromotor.UseSystemPasswordChar = true;
            //    tbxSenhaPromotor.UseSystemPasswordChar = true;
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            camara.PromotorSet.Remove((Promotor)listBox1.SelectedItem);
            camara.SaveChanges();
            lerDados();
        }
    }
}
