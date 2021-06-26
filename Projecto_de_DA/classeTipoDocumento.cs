using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class TipoDocumento
    {
        public TipoDocumento (string descricao)
        {
            Designacao = descricao;
        }
        public override string ToString()
        {
            return string.Format("{0}", this.Designacao);
        }
    }
   
}
