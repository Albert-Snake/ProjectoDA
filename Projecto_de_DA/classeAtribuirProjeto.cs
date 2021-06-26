using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class ProjetoAtribuido
    {
        public ProjetoAtribuido(DateTime data, Projeto projeto, Funcionario funcionario)
        {
            Data = data;
            Projeto = projeto;
            Funcionario = funcionario;
        }

        public ProjetoAtribuido()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} - ({1})", this.Funcionario.Nome, this.Projeto.EstadoProjeto);
        }
    }
}
