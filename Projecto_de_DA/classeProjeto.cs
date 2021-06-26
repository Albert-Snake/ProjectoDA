using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Projeto
    {
        public Projeto(string estado, DateTime dInicio, DateTime dAprovacao, TipoProjeto tipoprojeto, Processo processo)
        {
            EstadoProjeto = estado;
            DataEntrada = dInicio;
            DataAprovacao = dAprovacao;
            TipoProjeto = tipoprojeto;
            Processo = processo;

            
        }

        public override string ToString()
        {
            return string.Format("{0} - ({1})", this.EstadoProjeto, this.DataEntrada);
        }
    }
}
