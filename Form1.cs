using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binding2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<GenereMusica> list = new List<GenereMusica>();
        }

        void GenerateMusicList(ref List<GenereMusica> list)
        {
            Dictionary<string, string[]> genres = new Dictionary<string, string[]>() {
                { "Hip Hop", new string[] {"Eminem", "Ye"} },
                {"Indie", new string[] { "The Killers", "The Shins"}},
                {"Classical", new string[] { "Ludwig van Beethoven", "Amadeus Mozart"}} 
            };
            string[,,] songs = { 
                    { { "Venom", "2018" }, { "Rap God", "2013" } },
                    { { "Mr. Brightside", "2004" }, { "Somebody Told Me", "2004" } },
                    { { "Venom", "2018" }, { "Rap God", "2013" } } 
                };
            foreach (var item in genres)
            {
                //Canzone canzone = new Canzone();
                //GenereMusica genere = new GenereMusica();
            }

        }
    }
}
