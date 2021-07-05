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
    public partial class formEspecialista : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formEspecialista()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosEspecialistas();
            lerDadosTiposProjetos();
            lerDadosFuncionarios();
            permitirInserir();
        }

#region Ler Dados
        private void lerDadosEspecialistas()
        {
            bsEspecialistas.DataSource = camara.EspecialistaSet.ToList<Especialista>();
            bsEspecialistas.ResetBindings(false);
            listboxEspecialistas.SelectedIndex = -1;
        }
        private void lerDadosTiposProjetos()
        {

            bsTipoProjetos.DataSource = camara.TipoProjetoSet.ToList<TipoProjeto>();
            bsTipoProjetos.ResetBindings(false);
            cbxTipoProjeto.SelectedIndex = -1;
        }
        private void lerDadosFuncionarios()
        {

            bsFuncionarios.DataSource = camara.FuncionarioSet.ToList<Funcionario>();
            bsFuncionarios.ResetBindings(false);
            cbxFuncionarios.SelectedIndex = -1;
        }
#endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(cbxFuncionarios.Enabled == false)
            {
                permitirInserir();
            }
            else
            {
                try
                {
                    TipoProjeto tipoprojeto = (TipoProjeto)cbxTipoProjeto.SelectedItem;
                    Funcionario funcionario = (Funcionario)cbxFuncionarios.SelectedItem;
                    camara.EspecialistaSet.Add(new Especialista(tipoprojeto, funcionario));
                    camara.SaveChanges();
                    lerDadosEspecialistas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao adicionar este Especialista, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxEspecialistas.SelectedIndex != -1)
            {
                camara.EspecialistaSet.Remove((Especialista)listboxEspecialistas.SelectedItem);
                camara.SaveChanges();
                lerDadosEspecialistas();
                permitirInserir();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listboxEspecialistas.SelectedIndex != -1)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                Especialista especialista = (Especialista)listboxEspecialistas.SelectedItem;
                especialista.TipoProjeto = (TipoProjeto)cbxTipoProjeto.SelectedItem;
                especialista.Funcionario = (Funcionario)cbxFuncionarios.SelectedItem;
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

                lerDadosEspecialistas();
                permitirInserir();
            }
        }

        private void listboxEspecialistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxEspecialistas.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                Especialista especialista = (Especialista)listboxEspecialistas.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                cbxTipoProjeto.SelectedItem = especialista.TipoProjeto;
                cbxFuncionarios.SelectedItem = especialista.Funcionario;


                //Torna as textboxes impossiveis de se escrever
                cbxTipoProjeto.Enabled = false;
                cbxFuncionarios.Enabled = false;

                //alterar o text do botão adicionar
                btnAdicionar.Text = "Limpar Dados";
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxEspecialistas.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados desta Especialidade?", "Alterar dados da Especialidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes impossiveis de se escrever
                    //cbxTipoProjeto.Enabled = true;
                    cbxFuncionarios.Enabled = true;

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
            listboxEspecialistas.SelectedIndex = -1;
            cbxTipoProjeto.SelectedIndex = -1;
            cbxFuncionarios.SelectedIndex = -1;

            cbxTipoProjeto.Enabled = true;
            cbxFuncionarios.Enabled = true;

            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

            btnAdicionar.Text = "Adicionar";
        }
    }
}
