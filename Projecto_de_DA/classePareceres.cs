using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Parecer
    {
        public Parecer(string textoparecer, DateTime dataparecer, Projeto projeto, Funcionario funcionario)
        {
            TextoParecer = textoparecer;
            DataParecer = dataparecer;
            Projeto = projeto;
            Funcionario = funcionario;
        }

        public Parecer()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}", this.TextoParecer);
        }
    }
}
