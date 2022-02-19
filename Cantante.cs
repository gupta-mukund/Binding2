using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding2
{
    class Cantante
    {
        public string Id { get; set; }
        public string NomeCanzone { get; set; }
        public string AnnoProduzione { get; set; }
        public string NomeArte { get; set; }
        public string Nazionalita { get; set; }
        public List<Canzone> Canzoni { get; set; }
    }
}
