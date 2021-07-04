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
    public partial class formTipoProcessos : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formTipoProcessos()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDados();
            tbxDescricaoProcesso.Text = "";
            tbxDescricaoProcesso.ReadOnly = false;
            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;
            btnAdicionar.Text = "Adicionar";

        }
        private void lerDados()
        {

            bsTipoProcesso.DataSource = camara.EstadoProcessoSet.ToList<EstadoProcesso>();
            bsTipoProcesso.ResetBindings(false);
            listboxEstadosProcessos.SelectedIndex = -1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (tbxDescricaoProcesso.ReadOnly == true)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                //Torna as textboxes possiveis de se escrever
                tbxDescricaoProcesso.ReadOnly = false;


                //preencher as textboxes com os valores nulos
                tbxDescricaoProcesso.Text = "";



                //alterar o text do botão Adicionar
                btnAdicionar.Text = "Adicionar";

                lerDados();
            }
            else
            {
                if (tbxDescricaoProcesso.Text != "")
                {
                    try
                    {
                        camara.EstadoProcessoSet.Add(new EstadoProcesso(tbxDescricaoProcesso.Text));
                        camara.SaveChanges();
                        lerDados();

                        tbxDescricaoProcesso.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha ao adicionar este Tipo de Processo, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Falha ao adicionar este Tipo de Processo, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxEstadosProcessos.SelectedIndex != -1)
            {
                try
                {
                    camara.EstadoProcessoSet.Remove((EstadoProcesso)listboxEstadosProcessos.SelectedItem);
                    camara.SaveChanges();
                    lerDados();

                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    tbxDescricaoProcesso.ReadOnly = false;


                    //preencher as textboxes com os valores nulos
                    tbxDescricaoProcesso.Text = "";



                    //alterar o text do botão Adicionar
                    btnAdicionar.Text = "Adicionar";

                    tbxDescricaoProcesso.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este Tipo de Processo está associado a algum Processo. Elimine o Processo associado a este Tipo de Processo", "FALHA A ELIMINAR O PROMOTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }


            }
            else
                MessageBox.Show("Por Favor, selecione o Tipo de Documento que pretende eliminar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            EstadoProcesso processo = (EstadoProcesso)listboxEstadosProcessos.SelectedItem;
            processo.DescricaoEstado = tbxDescricaoProcesso.Text;
            camara.SaveChanges();

            //Torna as textboxes possiveis de se escrever
            tbxDescricaoProcesso.ReadOnly = false;

            //preencher as textboxes com os valores nulos
            tbxDescricaoProcesso.Text = "";

            btnAdicionar.Enabled = true;
            btnEliminar.Enabled = true;

            lerDados();

            tbxDescricaoProcesso.Text = "";

            //Torna o botao atualizar invivivel e disabled
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;


        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxEstadosProcessos.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Tipo de Processo?", "Alterar dados do Tipo de Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    tbxDescricaoProcesso.ReadOnly = false;
                    //tbxNumeroFuncionarioReadOnly = false;
                    tbxDescricaoProcesso.ReadOnly = false;


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;

                    //Torna o botao atualizar vivivel e enabled
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;
                }
            }
        }


        private void listboxTipoDocumneto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxEstadosProcessos.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                EstadoProcesso processo = (EstadoProcesso)listboxEstadosProcessos.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                tbxDescricaoProcesso.Text = processo.DescricaoEstado;


                //Torna as textboxes impossiveis de se escrever
                tbxDescricaoProcesso.ReadOnly = true;


                //alterar o text do botão adicionar
                btnAdicionar.Text = "Limpar Dados";
                //lerDados();
                //amara.Dispose();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
