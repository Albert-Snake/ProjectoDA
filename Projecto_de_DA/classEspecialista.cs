using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{

    public partial class Especialista
    {
        public Especialista(TipoProjeto tipoprojeto, Funcionario funcionario)
        {
            TipoProjeto = tipoprojeto;
            Funcionario = funcionario;
        }

        public Especialista()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} - ({1})", this.Funcionario.Nome, this.TipoProjeto.Designacao);
        }
    }
}
