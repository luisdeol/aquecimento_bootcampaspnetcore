using System;
using System.Collections.Generic;
using System.Text;

namespace TopFlix
{
    public class EpisodioSerie : Video
    {
        public EpisodioSerie(
            string titulo, 
            string descricao, 
            DateTime publicadoEm,
            int numeroEpisodio,
            int temporada,
            string serie): base(titulo, descricao, publicadoEm)
        {
            NumeroEpisodio = numeroEpisodio;
            Temporada = temporada;
            Serie = serie;
        }

        public int NumeroEpisodio { get; private set; }
        public int Temporada { get; private set; }
        public string Serie { get; private set; }

        public override string ObterPreviewResumo()
        {
            return $"{NumeroEpisodio} - {Temporada}-{ base.ObterPreviewResumo() }";
        }
    }
}
