using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Funcionario
    {
        public Funcionario(int numero, string nome, string extencao)
        {
            Numero = numero;
            Nome = nome;
            Extencao = extencao;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Nome);
        }
    }
}
