using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Processo
    {
        public Processo(DateTime data, Promotor promotor, EstadoProcesso estadoprocesso)
        {
            DataInicio = data;
            Promotor = promotor;
            EstadoProcesso = estadoprocesso;
        }
        public override string ToString()
        {
            return string.Format("{0}", this.Id);
        }
    }
}
