using System;
using System.Collections.Generic;
using System.Text;

namespace TopFlix
{
    public class Video
    {
        private int score;
        public Video(string titulo, string descricao, DateTime publicadoEm)
        {
            Titulo = titulo;
            Descricao = descricao;
            PublicadoEm = publicadoEm;
            TotalVisualizacoes = 0;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime PublicadoEm { get; private set; }
        public int TotalVisualizacoes { get; private set; }

        public void AdicionarVisualizacao()
        {
            TotalVisualizacoes++;
        }

        public virtual string ObterPreviewResumo()
        {
            if (Descricao.Length > 50)
            {
                return Descricao.Substring(0, 50);
            }

            return Descricao;
        }
    }
}
