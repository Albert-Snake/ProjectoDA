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
    public partial class formProjectos : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formProjectos()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosProjectos();
            lerDadosProcesso();
            lerDadosTipoProjecto();
            permitirInserir();
        }

        #region Ler Dados
        private void lerDadosProjectos()
        {

            bsProjetos.DataSource = camara.ProjetoSet.ToList<Projeto>();
            bsProjetos.ResetBindings(false);
            listboxProjetos.SelectedIndex = -1;
        }

        private void lerDadosTipoProjecto()
        {

            bsTipoProjeto.DataSource = camara.TipoProjetoSet.ToList<TipoProjeto>();
            bsTipoProjeto.ResetBindings(false);
            cbxProcesso.SelectedIndex = -1;
        }
        private void lerDadosProcesso()
        {

            bsProcesso.DataSource = camara.ProcessoSet.ToList<Processo>();
            bsProcesso.ResetBindings(false);
            cbxProcesso.SelectedIndex = -1;
        }

#endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            TipoProjeto tipoprojeto = (TipoProjeto)cbxTipoProjeto.SelectedItem;
            Processo processo = (Processo)cbxProcesso.SelectedItem;
            camara.ProjetoSet.Add(new Projeto(tbxNomeProjeto.Text, DataInicio.Value, DataAprovecao.Value, tipoprojeto, processo));
            camara.SaveChanges();
            lerDadosProjectos();
            permitirInserir();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxProjetos.SelectedIndex != -1)
            {
                camara.ProjetoSet.Remove((Projeto)listboxProjetos.SelectedItem);
                camara.SaveChanges();
                lerDadosProjectos();
                permitirInserir();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Projeto projeto = (Projeto)listboxProjetos.SelectedItem;
            projeto.EstadoProjeto = tbxNomeProjeto.Text;
            projeto.DataEntrada = DataInicio.Value;
            projeto.DataAprovacao = DataAprovecao.Value;
            projeto.TipoProjeto = (TipoProjeto)cbxTipoProjeto.SelectedItem;
            projeto.Processo = (Processo)cbxProcesso.SelectedItem; 
            camara.SaveChanges();
            lerDadosProjectos();
            permitirInserir();


        }

        private void listboxProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxProjetos.SelectedIndex != -1)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                Projeto projeto = (Projeto)listboxProjetos.SelectedItem;
                tbxNomeProjeto.Text = projeto.EstadoProjeto;
                DataInicio.Value = projeto.DataEntrada;
                DataAprovecao.Value = projeto.DataAprovacao;
                cbxTipoProjeto.SelectedItem = projeto.TipoProjeto;
                cbxProcesso.SelectedItem = projeto.Processo;

                tbxNomeProjeto.Enabled = false;
                DataInicio.Enabled = false;
                DataAprovecao.Enabled = false;
                cbxTipoProjeto.Enabled = false;
                cbxProcesso.Enabled = false;
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxProjetos.SelectedIndex != -1)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                tbxNomeProjeto.Enabled = true;
                DataInicio.Enabled = true;
                DataAprovecao.Enabled = true;
                cbxTipoProjeto.Enabled = true;
                cbxProcesso.Enabled = true;

                buttonGuardar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void permitirInserir()
        {
            tbxNomeProjeto.ReadOnly = false;

            tbxNomeProjeto.Enabled = true;
            DataInicio.Enabled = true;
            DataAprovecao.Enabled = true;
            cbxTipoProjeto.Enabled = true;
            cbxProcesso.Enabled = true;

            tbxNomeProjeto.Text = "";

            cbxProcesso.SelectedIndex = -1;
            cbxTipoProjeto.SelectedIndex = -1;




        }
    }
}