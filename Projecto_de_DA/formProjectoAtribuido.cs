using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_de_DA
{
    public partial class formProjectoAtribuido : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formProjectoAtribuido()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosProjetosAtribuidos();
            lerDadosProjetos();
            lerDadosFuncionarios();
            permitirInserir();
        }
        #region Ler Dados
        private void lerDadosProjetosAtribuidos()
        {
            bsProjectosAtribuidos.DataSource = camara.ProjetoAtribuidoSet.ToList<ProjetoAtribuido>();
            listboxProjetosAtribuidos.SelectedIndex = -1;
        }
        private void lerDadosProjetos()
        {

            bsProjectos.DataSource = camara.ProjetoSet.ToList<Projeto>();
            bsProjectos.ResetBindings(false);
            cbxProjeto.SelectedIndex = -1;
        }
        private void lerDadosFuncionarios()
        {

            bsFuncionarios.DataSource = camara.FuncionarioSet.ToList<Funcionario>();
            bsFuncionarios.ResetBindings(false);
            cbxFuncionario.SelectedIndex = -1;
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(cbxFuncionario.Enabled == false)
            {
                permitirInserir();
            }
            else
            {
                try
                {
                    Projeto projeto = (Projeto)cbxProjeto.SelectedItem;
                    Funcionario funcionario = (Funcionario)cbxFuncionario.SelectedItem;
                    camara.ProjetoAtribuidoSet.Add(new ProjetoAtribuido(dataAtribuicao.Value, projeto, funcionario));
                    camara.SaveChanges();
                    lerDadosProjetosAtribuidos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao adicionar esta Atribuição, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxProjetosAtribuidos.SelectedIndex != -1)
            {
                camara.ProjetoAtribuidoSet.Remove((ProjetoAtribuido)listboxProjetosAtribuidos.SelectedItem);
                camara.SaveChanges();
                lerDadosProjetosAtribuidos();
                permitirInserir();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listboxProjetosAtribuidos.SelectedIndex != -1)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                ProjetoAtribuido projetoatribuido = (ProjetoAtribuido)listboxProjetosAtribuidos.SelectedItem;
                projetoatribuido.Data = dataAtribuicao.Value;
                projetoatribuido.Projeto = (Projeto)cbxProjeto.SelectedItem;
                projetoatribuido.Funcionario = (Funcionario)cbxFuncionario.SelectedItem;
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


                //Torna o botao atualizar invivivel e disabled
                btnAtualizar.Enabled = false;
                btnAtualizar.Visible = false;

                lerDadosProjetosAtribuidos();

                permitirInserir();
            }
        }

        private void listboxProjetosAtribuidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxProjetosAtribuidos.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                ProjetoAtribuido projetoatribuido = (ProjetoAtribuido)listboxProjetosAtribuidos.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                dataAtribuicao.Value = projetoatribuido.Data;
                cbxProjeto.SelectedItem = projetoatribuido.Projeto;
                cbxFuncionario.SelectedItem = projetoatribuido.Funcionario;

                //Torna as textboxes impossiveis de se escrever
                dataAtribuicao.Enabled = false;
                cbxProjeto.Enabled = false;
                cbxFuncionario.Enabled = false;

                //alterar o text do botão adicionar
                btnAdicionar.Text = "Limpar Dados";
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxProjetosAtribuidos.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados desta Atribuição?", "Alterar dados da Atribuição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes impossiveis de se escrever
                    dataAtribuicao.Enabled = true;
                    cbxProjeto.Enabled = true;
                    cbxFuncionario.Enabled = true;

                    //alterar o text do botão adicionar
                    btnAdicionar.Text = "Adicionar";


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;


                    //Torna o botao atualizar vivivel e enabled
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;
                }
            }
        }

        private void permitirInserir()
        {
            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

            //Torna as textboxes impossiveis de se escrever
            dataAtribuicao.Enabled = true;
            cbxProjeto.Enabled = true;
            cbxFuncionario.Enabled = true;

            //alterar o text do botão adicionar
            btnAdicionar.Text = "Adicionar";

            dataAtribuicao.Value = DateTime.Now;
            cbxProjeto.SelectedIndex = -1;
            cbxFuncionario.SelectedIndex = -1;
        }
    }
}
