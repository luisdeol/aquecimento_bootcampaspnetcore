using System;
using System.Collections.Generic;
using System.Text;

namespace TopFlix
{
    public class Documentario : Video
    {
        public Documentario(
            string titulo,
            string descricao,
            DateTime publicadoEm) : base(titulo, descricao, publicadoEm)
        {
            Referencias = new List<string>();
        }

        public List<string> Referencias { get; set; }

        public void AdicionarReferencia(string referencia)
        {
            Referencias.Add(referencia);
        }
    }
}
