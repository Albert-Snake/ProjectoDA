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
    public partial class formDocumentos : Form
    {
        private GestaoCamaraMunicipalContainer camara;
        public formDocumentos()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosTipoDocumento();
            lerDadosProjecto();
            lerDadosDocumentos();
            permitirInserir();
        }

        #region Ler Dados
        private void lerDadosTipoDocumento()
        {
            bsTipoDocumentos.DataSource = camara.TipoDocumentoSet.ToList<TipoDocumento>();
            cbxTipoDocumento.SelectedIndex = -1;
        }
        private void lerDadosProjecto()
        {
            bsProjectos.DataSource = camara.ProjetoSet.ToList<Projeto>();
            cbxProjecto.SelectedIndex = -1;
        }
        private void lerDadosDocumentos()
        {

            listboxDocumentos.DataSource = camara.DocumentoSet.ToList<Documento>();
            listboxDocumentos.SelectedIndex = -1;
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(tbxNomeDocumento.Enabled == false)
            {
                permitirInserir();
            }
            else
            {
                if(tbxNomeDocumento.Text != "" && cbxProjecto.SelectedIndex != -1 && cbxTipoDocumento.SelectedIndex == -1)
                {
                    TipoDocumento tipodocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
                    Projeto projeto = (Projeto)cbxProjecto.SelectedItem;
                    camara.DocumentoSet.Add(new Documento(tbxNomeDocumento.Text, dtDataEntrega.Value, tipodocumento, projeto));
                    camara.SaveChanges();
                    lerDadosDocumentos();
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar este Documento, insira novamente todos os dados nos campos designados", "FALHA AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxDocumentos.SelectedIndex != -1)
            {
                camara.DocumentoSet.Remove((Documento)listboxDocumentos.SelectedItem);
                camara.SaveChanges();
                lerDadosDocumentos();
                permitirInserir();

            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listboxDocumentos.SelectedIndex != -1)
            {
                Documento documento = (Documento)listboxDocumentos.SelectedItem;
                documento.Titulo = tbxNomeDocumento.Text;
                documento.DataEntrega = dtDataEntrega.Value;
                documento.TipoDocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
                documento.Projeto = (Projeto)cbxProjecto.SelectedItem;
                camara.SaveChanges();
                lerDadosDocumentos();
                permitirInserir();

                //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                buttonGuardar.Enabled = true;
                btnEliminar.Enabled = true;

                //Torna o botao atualizar invivivel e disabled
                btnAtualizar.Enabled = false;
                btnAtualizar.Visible = false;

            }

        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxDocumentos.SelectedIndex != -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Documento?", "Alterar dados do Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes impossiveis de se escrever
                    tbxNomeDocumento.Enabled = true;
                    dtDataEntrega.Enabled = true;
                    cbxTipoDocumento.Enabled = true;
                    cbxProjecto.Enabled = true;

                    //bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    buttonGuardar.Enabled = false;
                    btnEliminar.Enabled = false;

                    //Torna o botao atualizar vivivel e enabled
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;
                }
            }
            ////alterar o text do botão adicionar
            //buttonGuardar.Text = "Adicionar";
        }

        private void listboxDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listboxDocumentos.SelectedIndex != -1)
            {
                //altera o icon para bloqueado
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                Documento documento = (Documento)listboxDocumentos.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                tbxNomeDocumento.Text = documento.Titulo;
                dtDataEntrega.Value = documento.DataEntrega;
                cbxTipoDocumento.SelectedItem = documento.TipoDocumento;
                cbxProjecto.SelectedItem = documento.Projeto;


                //Torna as textboxes impossiveis de se escrever
                tbxNomeDocumento.Enabled = false;
                dtDataEntrega.Enabled = false;
                cbxTipoDocumento.Enabled = false;
                cbxProjecto.Enabled = false;

                //alterar o text do botão adicionar
                buttonGuardar.Text = "Limpar Dados";
            }
        }

        private void permitirInserir() 
        {
            tbxNomeDocumento.Text = "";
            cbxProjecto.SelectedIndex = -1;
            cbxTipoDocumento.SelectedIndex = -1;

            //Torna as textboxes possiveis de se escrever
            tbxNomeDocumento.Enabled = true;
            dtDataEntrega.Enabled = true;
            cbxTipoDocumento.Enabled = true;
            cbxProjecto.Enabled = true;

            //alterar o text do botão adicionar
            buttonGuardar.Text = "Guardar";

            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;


        }
    }
}
