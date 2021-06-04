using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Promotor
    {
        public Promotor(int nif, string nome, string morada, string telemovel, string email, string codigoAcesso, string senha)
        {
            NIF = nif;
            Nome = nome;
            Morada = morada;
            Telemovel = telemovel;
            Email = email;
            CodigoAcesso = codigoAcesso;
            Senha = senha;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Nome, this.NIF);
        }
    }
}
