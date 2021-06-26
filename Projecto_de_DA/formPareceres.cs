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
    public partial class formPareceres : Form
    {
        private GestaoCamaraMunicipalContainer camara;
        public formPareceres()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosPareceres();
            lerDadosProjetos();
            lerDadosFuncionarios();
            permitirInserir();
        }

        #region Ler Dados
        private void lerDadosPareceres()
        {

            bsPareceres.DataSource = camara.ParecerSet.ToList<Parecer>();
            bsPareceres.ResetBindings(false);
            listboxPareceres.SelectedIndex = -1;
        }
        private void lerDadosProjetos()
        {

            bsProjeto.DataSource = camara.ProjetoSet.ToList<Projeto>();
            bsProjeto.ResetBindings(false);
            cbxProjeto.SelectedIndex = -1;
        }
        private void lerDadosFuncionarios()
        {

            bsFuncionario.DataSource = camara.FuncionarioSet.ToList<Funcionario>();
            bsFuncionario.ResetBindings(false);
            cbxFuncionario.SelectedIndex = -1;
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Projeto projeto = (Projeto)cbxProjeto.SelectedItem;
            Funcionario funcionario = (Funcionario)cbxFuncionario.SelectedItem;
            camara.ParecerSet.Add(new Parecer(tbxTextoParecer.Text, dataParecer.Value, projeto, funcionario));
            camara.SaveChanges();
            lerDadosPareceres();
            permitirInserir();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(listboxPareceres.SelectedIndex != -1)
            {
                camara.ParecerSet.Remove((Parecer)listboxPareceres.SelectedItem);
                camara.SaveChanges();
                lerDadosPareceres();
                permitirInserir();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listboxPareceres.SelectedIndex != -1 )
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                Parecer parecer = (Parecer)listboxPareceres.SelectedItem;
                parecer.TextoParecer = tbxTextoParecer.Text;
                parecer.DataParecer = dataParecer.Value;
                parecer.Projeto = (Projeto)cbxProjeto.SelectedItem;
                parecer.Funcionario = (Funcionario)cbxFuncionario.SelectedItem;
                camara.SaveChanges();

                ////Torna as textboxes possiveis de se escrever
                //tbxNomeFuncionario.ReadOnly = false;
                //tbxExtencaoFuncionario.ReadOnly = false;
                //tbxNumeroFuncionario.ReadOnly = false;

                ////preencher as textboxes com os valores nulos
                //tbxNomeFuncionario.Text = "";
                //tbxExtencaoFuncionario.Text = "";
                //tbxNumeroFuncionario.Text = "";

                btnAdicionar.Enabled = true;
                btnEliminar.Enabled = true;

                lerDadosPareceres();
                permitirInserir();
            }
        }

        private void listboxPareceres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxPareceres.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                Parecer parecer = (Parecer)listboxPareceres.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                tbxTextoParecer.Text = parecer.TextoParecer;
                dataParecer.Value = parecer.DataParecer;
                cbxProjeto.SelectedItem = parecer.Projeto;
                cbxFuncionario.SelectedItem = parecer.Funcionario;

                //Torna as textboxes impossiveis de se escrever
                tbxTextoParecer.ReadOnly = true;
                dataParecer.Enabled = false;
                cbxProjeto.Enabled = false;
                cbxFuncionario.Enabled = false;

                //alterar o text do botão adicionar
                btnAdicionar.Text = "Limpar Dados";  
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxPareceres.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Parecer?", "Alterar dados do Parecer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes impossiveis de se escrever
                    tbxTextoParecer.ReadOnly = false;
                    dataParecer.Enabled = true;
                    cbxProjeto.Enabled = true;
                    cbxFuncionario.Enabled = true;

                    //alterar o text do botão adicionar
                    btnAdicionar.Text = "Adicionar";


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
        }

        private void permitirInserir()
        {
            tbxTextoParecer.ReadOnly = false;
            dataParecer.Enabled = true;
            cbxProjeto.Enabled = true;
            cbxFuncionario.Enabled = true;

            cbxFuncionario.SelectedIndex = -1;
            cbxProjeto.SelectedIndex = -1;

            //alterar o text do botão adicionar
            btnAdicionar.Text = "Adicionar";
        }
    }
}
