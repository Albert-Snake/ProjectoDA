using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class EstadoProcesso
    {
        public EstadoProcesso(string descricao)
        {
            DescricaoEstado = descricao;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.DescricaoEstado);
        }
    }
}
