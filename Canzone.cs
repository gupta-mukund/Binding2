using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding2
{
    class Canzone
    {
        public Canzone(string id, string nomeCanzone, string annoProduzione)
        {
            Id = id;
            NomeCanzone = nomeCanzone;
            AnnoProduzione = annoProduzione;
        }

        public string Id { get; set; }
        public string NomeCanzone { get; set; }
        public string AnnoProduzione { get; set; }
    }
}
