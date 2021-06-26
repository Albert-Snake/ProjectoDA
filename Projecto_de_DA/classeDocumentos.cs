using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_de_DA
{
    public partial class Documento
    {
        public Documento(string nome, DateTime data, TipoDocumento tipodocumento, Projeto projeto)
        {
            Titulo = nome;
            DataEntrega = data;
            TipoDocumento = tipodocumento;
            Projeto = projeto;

        }

        public Documento()
        {
 
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Titulo, this.DataEntrega);
        }
    }
}
