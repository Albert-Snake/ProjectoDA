using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Funcionario
    {
        public Funcionario(int numero, string nome, string extencao, string utilizador, string password, string tipoperfil)
        {
            Numero = numero;
            Nome = nome;
            Extencao = extencao;
            Utilizador = utilizador;
            Password = password;
            TipoPerfil = tipoperfil;
        }

        public override string ToString()
        {
            return string.Format("{0} - Perfil: {1}", this.Nome, this.TipoPerfil);
        }
    }
}
