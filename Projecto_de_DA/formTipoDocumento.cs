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
    public partial class formTipoDocumento : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formTipoDocumento()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDados();
            tbxDescricaoDocumento.Text = "";
            tbxDescricaoDocumento.ReadOnly = false;
            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;
            btnAdicionar.Text = "Adicionar";

        }
        private void lerDados()
        {

            bsTipoDocumento.DataSource = camara.TipoDocumentoSet.ToList<TipoDocumento>();
            bsTipoDocumento.ResetBindings(false);
            listboxTipoDocumneto.SelectedIndex = -1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (tbxDescricaoDocumento.ReadOnly == true)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                //Torna as textboxes possiveis de se escrever
                tbxDescricaoDocumento.ReadOnly = false;


                //preencher as textboxes com os valores nulos
                tbxDescricaoDocumento.Text = "";



                //alterar o text do botão Adicionar
                btnAdicionar.Text = "Adicionar";
            }
            else
            {
                try
                {
                    if (tbxDescricaoDocumento.Text != "")
                    {
                        camara.TipoDocumentoSet.Add(new TipoDocumento(tbxDescricaoDocumento.Text));
                        camara.SaveChanges();
                        lerDados();

                        tbxDescricaoDocumento.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar este Tipo de Projecto, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Falha ao adicionar este Tipo de Projecto, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxTipoDocumneto.SelectedIndex != -1)
            {
                try 
                {
                    camara.TipoDocumentoSet.Remove((TipoDocumento)listboxTipoDocumneto.SelectedItem);
                    camara.SaveChanges();
                    lerDados();

                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    tbxDescricaoDocumento.ReadOnly = false;


                    //preencher as textboxes com os valores nulos
                    tbxDescricaoDocumento.Text = "";



                    //alterar o text do botão Adicionar
                    btnAdicionar.Text = "Adicionar";

                    tbxDescricaoDocumento.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este Tipo de Documento está associado a algum Documento. Elimine o Documento associado a este Tipo de Documento", "FALHA A ELIMINAR O PROMOTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
            else
                MessageBox.Show("Por Favor, selecione o Tipo de Documento que pretende eliminar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            TipoDocumento documento = (TipoDocumento)listboxTipoDocumneto.SelectedItem;
            documento.Designacao = tbxDescricaoDocumento.Text;
            camara.SaveChanges();

            //Torna as textboxes possiveis de se escrever
            tbxDescricaoDocumento.ReadOnly = false;

            //preencher as textboxes com os valores nulos
            tbxDescricaoDocumento.Text = "";

            btnAdicionar.Enabled = true;
            btnEliminar.Enabled = true;

            lerDados();

            tbxDescricaoDocumento.Text = "";

            //Torna o botao atualizar invivivel e disabled
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;


        }

        private void listboxTipoDocumneto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxTipoDocumneto.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                TipoDocumento documento = (TipoDocumento)listboxTipoDocumneto.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                tbxDescricaoDocumento.Text = documento.Designacao;


                //Torna as textboxes impossiveis de se escrever
                tbxDescricaoDocumento.ReadOnly = true;


                //alterar o text do botão adicionar
                btnAdicionar.Text = "Limpar Dados";
                //lerDados();
                //amara.Dispose();
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxTipoDocumneto.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Tipo de Documento?", "Alterar dados do Tipo de Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    tbxDescricaoDocumento.ReadOnly = false;
                    //tbxNumeroFuncionarioReadOnly = false;
                    tbxDescricaoDocumento.ReadOnly = false;


                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    btnAdicionar.Enabled = false;
                    btnEliminar.Enabled = false;

                    //Torna o botao atualizar vivivel e enabled
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;
                }
            }
        }
    }
}
