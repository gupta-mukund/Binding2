using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding2
{
    class Cantante
    {
        public Cantante(int id, string nomeCompleto, string nomeArte, string nazionalita )
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            NomeArte = nomeArte;
            Nazionalita = nazionalita;
            Canzoni = new List<Canzone>();
        }

        public int Id { get; set; }
       
        
        public string NomeCompleto { get; set; }
        public string NomeArte { get; set; }
        public string Nazionalita { get; set; }
        public List<Canzone> Canzoni { get; set; }
    }
}
