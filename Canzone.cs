using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding2
{
    class Canzone
    {
        public Canzone(int id, string nomeCanzone, int annoProduzione)
        {
            Id = id;
            NomeCanzone = nomeCanzone;
            AnnoProduzione = annoProduzione;
        }

        public int Id { get; set; }
        public string NomeCanzone { get; set; }
        public int AnnoProduzione { get; set; }
    }
}
