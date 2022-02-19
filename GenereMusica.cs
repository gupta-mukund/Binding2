using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding2
{
    class GenereMusica
    {
        public string Sigla { get; set; }
        public string NomeGenere { get; set; }
        public List<Cantante> Canzoni { get; set; }

        public GenereMusica(string sigla, string nomeGenere, List<Cantante> list)
        {
            Sigla = sigla;
            NomeGenere = nomeGenere;
        }
    }
}
