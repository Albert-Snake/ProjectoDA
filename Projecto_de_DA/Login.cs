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
    public partial class Login : Form
    {
        private GestaoCamaraMunicipalContainer camara;
        string password;
        string tipo;
        string utilizador;
        public Login()
        {
            InitializeComponent();
            camara = new GestaoCamaraMunicipalContainer();
            lerDados();
        }

        private void lerDados()
        {

            bsLogin.DataSource = camara.FuncionarioSet.ToList<Funcionario>();
            bsLogin.ResetBindings(false);
            cbxFuncionario.SelectedIndex = -1;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxFuncionario.SelectedIndex != -1)
            {
                Funcionario funcionario = (Funcionario)cbxFuncionario.SelectedItem;

                //preencher as textboxes com os valores da base de dados
                password = funcionario.Password;
                tipo = funcionario.TipoPerfil;
                utilizador = funcionario.Utilizador;
                if (tbxPasswordLogin.Text == password)
                {
                    Form1 myForm = new Form1(tipo, utilizador);
                    myForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Incorreta. Tente Novamente", "LOGIN INCORRETO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxPasswordLogin.Text = "";
                }
        }
    }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
