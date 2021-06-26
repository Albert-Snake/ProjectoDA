using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class TipoProjeto
    {
        public TipoProjeto(int ndias, string designacao, TipoProjeto tipoprojetopendente)
        {
            NrDiasAprovacao = ndias;
            Designacao = designacao;
            TipoProjeto2 = tipoprojetopendente;

        }

        public TipoProjeto(int ndias, string designacao)
        {
            NrDiasAprovacao = ndias;
            Designacao = designacao;

        }

        public override string ToString()
        {
            return string.Format("{0} ({1})Dias", this.Designacao, this.NrDiasAprovacao);
        }
    }
}
