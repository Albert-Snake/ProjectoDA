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
    public partial class formTipoProjecto : Form
    {
        private GestaoCamaraMunicipalContainer camara;
        public formTipoProjecto()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosTipoProjectos();
            permitirInserir();
        }
        #region Ler Dados
        private void lerDadosTipoProjectos()
        {
            bsTipoProjectos.DataSource = camara.TipoProjetoSet.ToList<TipoProjeto>();
            bsTipoProjectoCBX.DataSource = camara.TipoProjetoSet.ToList<TipoProjeto>();
            listBoxTiposProjectos.SelectedIndex = -1;
            cbxTipoProjecto.SelectedIndex = -1;
            cbxTipoProjecto.Enabled = false;
            chekboxTipoPorjecto.Checked = false;
        }
        #endregion

        #region Eventos click dos botoes do form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Adiciona o novo projecto a tabela TipoProjecto
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (tbxDesignacao.Enabled == false)
            {
                permitirInserir();
            }
            else
            {
                //caso tenha um Tipo de projecto pendente
                if (chekboxTipoPorjecto.Checked == true)
                {
                    if (tbxDesignacao.Text != "" && numericNumerodeDias.Value > 0 && cbxTipoProjecto.SelectedIndex != -1)
                    {
                        TipoProjeto tipoprojeto = (TipoProjeto)cbxTipoProjecto.SelectedItem;
                        camara.TipoProjetoSet.Add(new TipoProjeto(Convert.ToInt32(numericNumerodeDias.Value), tbxDesignacao.Text, tipoprojeto));
                        camara.SaveChanges();
                        lerDadosTipoProjectos();
                        permitirInserir();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar este Tipo de Projeto, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                //caso não tenha um Tipo de projecto pendente
                else
                {
                    if (tbxDesignacao.Text != "" && numericNumerodeDias.Value > 0)
                    {
                        camara.TipoProjetoSet.Add(new TipoProjeto(Convert.ToInt32(numericNumerodeDias.Value), tbxDesignacao.Text));
                        camara.SaveChanges();
                        lerDadosTipoProjectos();
                        permitirInserir();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar este Tipo de Projeto, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
           
        }

        //elimina o tipo de projecto selecionado apartir da listbox
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxTiposProjectos.SelectedIndex != -1)
            {
                try
                {
                    camara.TipoProjetoSet.Remove((TipoProjeto)listBoxTiposProjectos.SelectedItem);
                    camara.SaveChanges();
                    lerDadosTipoProjectos();
                    permitirInserir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este Tipo de Projeto está associado a algum Projeto. Elimine o Projeto associado a este Tipo de Projeto", "FALHA A ELIMINAR O TIPO DE PROJETO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(listBoxTiposProjectos.SelectedIndex != -1)
            {
                TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposProjectos.SelectedItem;
                tipoprojeto.NrDiasAprovacao = Convert.ToInt32(numericNumerodeDias.Value);
                tipoprojeto.Designacao = tbxDesignacao.Text;
                tipoprojeto.TipoProjeto2 = (TipoProjeto)cbxTipoProjecto.SelectedItem;
                camara.SaveChanges();
                lerDadosTipoProjectos();
                permitirInserir();

                //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                btnAdicionar.Enabled = true;
                btnEliminar.Enabled = true;

                //Torna o botao atualizar invivivel e disabled
                btnAtualizar.Enabled = false;
                btnAtualizar.Visible = false;
            }

        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listBoxTiposProjectos.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Tipo de Projeto?", "Alterar dados do Tipo de Projeto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    numericNumerodeDias.Enabled = true;
                    tbxDesignacao.Enabled = true;
                    chekboxTipoPorjecto.Enabled = true;
                    if (chekboxTipoPorjecto.Checked == true)
                        cbxTipoProjecto.Enabled = true;


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;

                    //Torna o botao atualizar vivivel e enabled
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;

                }

            }
        }

        #endregion


        // Caso a check box seja selecionada altera a combox para Enabled e permite selecionar um valor da tabela TipoProjeto
        private void chekboxTipoPorjecto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTipoProjecto.Enabled == false)
            {
                cbxTipoProjecto.Enabled = true;
                
            }
            else
            {
                cbxTipoProjecto.Enabled = false;
                cbxTipoProjecto.SelectedIndex = -1;
            }

        }


        private void listBoxTiposProjectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTiposProjectos.SelectedIndex != -1)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposProjectos.SelectedItem;
                numericNumerodeDias.Value = Convert.ToInt32(tipoprojeto.NrDiasAprovacao);
                tbxDesignacao.Text = tipoprojeto.Designacao;
                cbxTipoProjecto.SelectedItem = tipoprojeto.TipoProjeto2;
                numericNumerodeDias.Enabled = false;
                tbxDesignacao.Enabled = false;
                cbxTipoProjecto.Enabled = false;
                chekboxTipoPorjecto.Enabled = false;

                btnAdicionar.Text = "Limpar Dados";
            }
        }

        private void cbxTipoProjecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoProjecto.SelectedIndex != -1)
            {
                chekboxTipoPorjecto.Checked = true;
            }
            else
            {
                chekboxTipoPorjecto.Checked = false;
            }
        }

        private void permitirInserir()
        {
            //Torna as textboxes possiveis de se escrever
            numericNumerodeDias.Enabled = true;
            tbxDesignacao.Enabled = true;
            chekboxTipoPorjecto.Checked = false;

            numericNumerodeDias.Value = 0;
            tbxDesignacao.Text = "";
            chekboxTipoPorjecto.Checked = false;
            cbxTipoProjecto.SelectedIndex = -1;
            cbxTipoProjecto.Enabled = false;


            //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
            btnAdicionar.Enabled = true;
            btnEliminar.Enabled = true;
            chekboxTipoPorjecto.Enabled = true;

            //Torna o botao atualizar invivivel e disabled
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;

            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

            btnAdicionar.Text = "Adiconar";
        }
    }
}
