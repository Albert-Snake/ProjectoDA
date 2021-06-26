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
            TipoDocumento tipodocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
            Projeto projeto = (Projeto)cbxProjecto.SelectedItem;
            camara.DocumentoSet.Add(new Documento(tbxNomeDocumento.Text, dtDataEntrega.Value, tipodocumento, projeto));
            camara.SaveChanges();
            lerDadosDocumentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxDocumentos.SelectedIndex != -1)
            {
                camara.DocumentoSet.Remove((Documento)listboxDocumentos.SelectedItem);
                camara.SaveChanges();
                lerDadosDocumentos();
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
            }
            
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            //altera o icon para bloqueado
            btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

            //Torna as textboxes impossiveis de se escrever
            tbxNomeDocumento.Enabled = true;
            dtDataEntrega.Enabled = true;
            cbxTipoDocumento.Enabled = true;
            cbxProjecto.Enabled = true;

            //alterar o text do botão adicionar
            buttonGuardar.Text = "Adicionar";
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
    }
}
