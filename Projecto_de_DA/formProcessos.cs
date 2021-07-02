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
    public partial class formProcessos : Form
    {
        private GestaoCamaraMunicipalContainer camara;

        public formProcessos()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDadosPromotores();
            lerDadosEstadoProcesso();
            lerDadosProcessos();
            listboxProcessos.SelectedIndex = -1;
            cbxPromotor.SelectedIndex = -1;
            cbxEstadoProcesso.SelectedIndex = -1;
            permitirInserir();
        }
        #region Ler Dados

        private void lerDadosProcessos()
        {
            bsProjetos.DataSource = camara.ProcessoSet.ToList<Processo>();
            listboxProcessos.SelectedIndex = -1;
        }

        private void lerDadosPromotores()
        {
            bsPromotor.DataSource = camara.PromotorSet.ToList<Promotor>();
            cbxPromotor.SelectedIndex = -1;
        }

        private void lerDadosEstadoProcesso()
        {
            bsEstadoProcesso.DataSource = camara.EstadoProcessoSet.ToList<EstadoProcesso>();
            cbxEstadoProcesso.SelectedIndex = -1;
        }

        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(cbxPromotor.Enabled == false && cbxEstadoProcesso.Enabled == false)
            {
                permitirInserir();
                buttonGuardar.Text = "Guardar";
            }
            else
            {
                Promotor promotor = (Promotor)cbxPromotor.SelectedItem;
                EstadoProcesso estadoprocesso = (EstadoProcesso)cbxEstadoProcesso.SelectedItem;
                camara.ProcessoSet.Add(new Processo(dataInicio.Value, promotor, estadoprocesso));
                camara.SaveChanges();
                lerDadosProcessos();
                lerDadosPromotores();
                lerDadosEstadoProcesso();
                permitirInserir();
            } 
        }

        private void listboxProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxProcessos.SelectedIndex != -1)
            {
                btnDesbloquear.BackgroundImage = Properties.Resources._lock;

                Processo processo = (Processo)listboxProcessos.SelectedItem;
                dataInicio.Value = Convert.ToDateTime(processo.DataInicio);
                cbxPromotor.SelectedItem = processo.Promotor;
                cbxEstadoProcesso.SelectedItem = processo.EstadoProcesso;

                dataInicio.Enabled = false;
                cbxPromotor.Enabled = false;
                cbxEstadoProcesso.Enabled = false;

                //alterar o text do botão adicionar
                buttonGuardar.Text = "Limpar Dados";
            }
            else 
            {
                permitirInserir();
                buttonGuardar.Text = "Guardar";
                btnDesbloquear.BackgroundImage = Properties.Resources.unlock;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listboxProcessos.SelectedIndex != -1)
            {
                try 
                {
                    camara.ProcessoSet.Remove((Processo)listboxProcessos.SelectedItem);
                    camara.SaveChanges();
                    lerDadosProcessos();
                    lerDadosProcessos();
                    lerDadosPromotores();
                    lerDadosEstadoProcesso();
                    permitirInserir();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Este Processo está associado a algum Projeto . Elimine o Projeto associado a este Processo", "FALHA A ELIMINAR O PROCESSO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
               
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Processo processo = (Processo)listboxProcessos.SelectedItem;
            processo.DataInicio = dataInicio.Value;
            processo.Promotor = (Promotor)cbxPromotor.SelectedItem;
            processo.EstadoProcesso = (EstadoProcesso)cbxEstadoProcesso.SelectedItem;
            camara.SaveChanges();
            lerDadosProcessos();
            lerDadosEstadoProcesso();
            lerDadosPromotores();
            permitirInserir();

            //Torna o botao atualizar invivivel e disabled
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listboxProcessos.SelectedIndex > -1)
            {
                if (MessageBox.Show("Pretende alterar os dados deste Promotor?", "Alterar dados do Promotor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnDesbloquear.BackgroundImage = Properties.Resources.unlock;

                    //Torna as textboxes possiveis de se escrever
                    dataInicio.Enabled = true;
                    cbxPromotor.Enabled = true;
                    cbxEstadoProcesso.Enabled = true;

                    //Torna o botao atualizar vivivel e enabled
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Visible = true;


                    ////bloqueia a propriedade de adicionar ou remover caso o botão desbloquear seja pressionado
                    //buttonGuardar.Enabled = false;
                    //btnEliminar.Enabled = false;
                }

            }
        }

        private void permitirInserir()
        {
            dataInicio.Enabled = true;
            cbxPromotor.Enabled = true;
            cbxEstadoProcesso.Enabled = true;

            cbxEstadoProcesso.SelectedIndex = -1;
            cbxPromotor.SelectedIndex = -1;



        }
    }
}
