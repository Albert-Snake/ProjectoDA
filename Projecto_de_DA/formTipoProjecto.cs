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

            numericNumerodeDias.Enabled = true;
            tbxDesignacao.Enabled = true;

            numericNumerodeDias.Value = 0;
            tbxDesignacao.Text = "";
            cbxTipoProjecto.SelectedIndex = -1;
        }
        #region Ler Dados
        private void lerDadosTipoProjectos()
        {
            bsTipoProjectos.DataSource = camara.TipoProjetoSet.ToList<TipoProjeto>();
            bsTipoProjectoCBX.DataSource = camara.TipoProjetoSet.ToList<TipoProjeto>();
            listBoxTiposProjectos.SelectedIndex = -1;
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
            //caso tenha um Tipo de projecto pendente
            if (chekboxTipoPorjecto.Checked)
            {
                TipoProjeto tipoprojeto = (TipoProjeto)cbxTipoProjecto.SelectedItem;
                camara.TipoProjetoSet.Add(new TipoProjeto(Convert.ToInt32(numericNumerodeDias.Value), tbxDesignacao.Text, tipoprojeto));
                camara.SaveChanges();
                lerDadosTipoProjectos();
            }
            //caso não tenha um Tipo de projecto pendente
            else
            {
                camara.TipoProjetoSet.Add(new TipoProjeto(Convert.ToInt32(numericNumerodeDias.Value), tbxDesignacao.Text));
                camara.SaveChanges();
                lerDadosTipoProjectos();
            }
        }

        //elimina o tipo de projecto selecionado apartir da listbox
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxTiposProjectos.SelectedIndex != -1)
            {
                camara.TipoProjetoSet.Remove((TipoProjeto)listBoxTiposProjectos.SelectedItem);
                camara.SaveChanges();
                lerDadosTipoProjectos();
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
                //Torna o botao atualizar invivivel e disabled
                btnAtualizar.Enabled = false;
                btnAtualizar.Visible = false;
            }

        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listBoxTiposProjectos.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Promotor?", "Alterar dados do Promotor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    numericNumerodeDias.Enabled = true;
                    tbxDesignacao.Enabled = true;
                    if(chekboxTipoPorjecto.Checked == true)
                        cbxTipoProjecto.Enabled = true;


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;

                    //Torna o botao atualizar invivivel e disabled
                    btnAtualizar.Enabled = false;
                    btnAtualizar.Visible = false;

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
                cbxTipoProjecto.DataSource = bsTipoProjectos.DataSource;
                cbxTipoProjecto.SelectedIndex = -1;
            }
            else
            {
                cbxTipoProjecto.Enabled = false;
                cbxTipoProjecto.DataSource = null;
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
                if (cbxTipoProjecto.SelectedIndex != -1)
                    chekboxTipoPorjecto.Checked = true;
                numericNumerodeDias.Enabled = false;
                tbxDesignacao.Enabled = false;
                cbxTipoProjecto.Enabled = false;
            }
        }
    }
}
