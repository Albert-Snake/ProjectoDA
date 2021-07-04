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
    public partial class formFuncionarios : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formFuncionarios()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDados();
            permitirInserir();
        }
        private void lerDados()
        {

            bsFuncionarios.DataSource = camara.FuncionarioSet.ToList<Funcionario>();
            bsFuncionarios.ResetBindings(false);
            listBoxFuncionarios.SelectedIndex = -1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (tbxNomeFuncionario.ReadOnly == true)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                //Torna as textboxes possiveis de se escrever
                tbxNomeFuncionario.ReadOnly = false;
                tbxExtencaoFuncionario.ReadOnly = false;
                tbxNumeroFuncionario.ReadOnly = false;

                //preencher as textboxes com os valores nulos
                tbxNumeroFuncionario.Text = "";
                tbxExtencaoFuncionario.Text = "";
                tbxNomeFuncionario.Text = "";
                

                //alterar o text do botão Adicionar
                btnAdicionar.Text = "Adicionar";

            }
            else
            {
                try
                {
                    camara.FuncionarioSet.Add(new Funcionario(Convert.ToInt32(tbxNumeroFuncionario.Text), tbxNomeFuncionario.Text, tbxExtencaoFuncionario.Text));
                    camara.SaveChanges();
                    lerDados();
                    permitirInserir();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Falha ao adicionar este Funcionario, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                


            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedIndex > -1)
            {
                try 
                {
                    camara.FuncionarioSet.Remove((Funcionario)listBoxFuncionarios.SelectedItem);
                    camara.SaveChanges();
                    lerDados();
                    //camara.Dispose();
                    permitirInserir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este Funcionário está associado a alguma outra tarefa. Elimine essa tarefa associada a este Funcionário", "FALHA A ELIMINAR O FUNCIONÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

            Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;
            funcionario.Nome = tbxNomeFuncionario.Text;
            funcionario.Numero = Convert.ToInt32(tbxNumeroFuncionario.Text);
            funcionario.Extencao = tbxExtencaoFuncionario.Text;
            camara.SaveChanges();

            //Torna as textboxes possiveis de se escrever
            tbxNomeFuncionario.ReadOnly = false;
            tbxExtencaoFuncionario.ReadOnly = false;
            tbxNumeroFuncionario.ReadOnly = false;

            //preencher as textboxes com os valores nulos
            tbxNomeFuncionario.Text = "";
            tbxExtencaoFuncionario.Text = "";
            tbxNumeroFuncionario.Text = "";

            btnAdicionar.Enabled = true;
            btnEliminar.Enabled = true;

            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;

            lerDados();
            permitirInserir();
        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                tbxNomeFuncionario.Text = funcionario.Nome;
                tbxNumeroFuncionario.Text = Convert.ToString(funcionario.Numero);
                tbxExtencaoFuncionario.Text = funcionario.Extencao;

                //Torna as textboxes impossiveis de se escrever
                tbxNomeFuncionario.ReadOnly = true;
                tbxNumeroFuncionario.ReadOnly = true;
                tbxExtencaoFuncionario.ReadOnly = true;
               
                //alterar o text do botão adicionar
                btnAdicionar.Text = "Limpar Dados";
                //lerDados();
                //amara.Dispose();
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Funcionário?", "Alterar dados do Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    tbxNomeFuncionario.ReadOnly = false;
                    //tbxNumeroFuncionarioReadOnly = false;
                    tbxExtencaoFuncionario.ReadOnly = false;


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;

                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;
                }
            }
        }

        private void permitirInserir()
        {
            tbxNomeFuncionario.ReadOnly = false;
            tbxNumeroFuncionario.ReadOnly = false;
            tbxExtencaoFuncionario.ReadOnly = false;

            tbxNomeFuncionario.Text = "";
            tbxNumeroFuncionario.Text = "";
            tbxExtencaoFuncionario.Text = "";

            btnAdicionar.Text = "Adicionar";

            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;
        }
    }
}
