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
    public partial class Form2 : Form
    {
        List<Cantante> cantanti;
        public Form2()
        {
            InitializeComponent();
            cantanti = new List<Cantante>();
            GenerateSingers(ref cantanti);
            BindForm(ref cantanti);
        }

        void GenerateSingers(ref List<Cantante> list)
        {
            Cantante cant1 = new Cantante(1, "David Bowie", "Duca Bianco", "Uk");
            cant1.Canzoni.Add(new Canzone(1, "Let's dance", 1983));
            cant1.Canzoni.Add(new Canzone(2, "Modern Love", 1983));
            cant1.Canzoni.Add(new Canzone(3, "Starman", 1972));
            Cantante cant2 = new Cantante(1, "Robin Rihanna", "Rihanna", "Barbados");
            cant2.Canzoni.Add(new Canzone(1, "Diamonds", 2000));
            cant2.Canzoni.Add(new Canzone(2, "Umbrella", 2001));
            cant2.Canzoni.Add(new Canzone(3, "Disturbia", 2010));
            Cantante cant3 = new Cantante(1, "Pink Floyd", "genio puro", "Uk");
            cant3.Canzoni.Add(new Canzone(1, "The wall", 1980));
            cant3.Canzoni.Add(new Canzone(2, "Shine on you crazy diamond", 1974));
            cant3.Canzoni.Add(new Canzone(3, "The divison bells", 1994));
            Cantante cant4 = new Cantante(1, "Eros Ramazzotti", "Eros", "Lazio");
            cant4.Canzoni.Add(new Canzone(1, "Più bella cosa non c'è", 2000));
            cant4.Canzoni.Add(new Canzone(2, "Noi ragazzi di oggi", 1996));
            cant4.Canzoni.Add(new Canzone(3, "L'aurora", 1998));
            Cantante cant5 = new Cantante(1, "Alan Parson", "Projects", "Uk");
            cant5.Canzoni.Add(new Canzone(1, "The turn of friendly card", 1978));
            cant5.Canzoni.Add(new Canzone(2, "Eye in the sky", 1982));
            cant5.Canzoni.Add(new Canzone(3, "Mammagamma", 1982));
            Cantante cant6 = new Cantante(1, "Antonio Ligabue", "Liga", "Emilia");
            cant6.Canzoni.Add(new Canzone(1, "L'amore conta", 2012));
            cant6.Canzoni.Add(new Canzone(2, "Certe notti", 1995));
            cant6.Canzoni.Add(new Canzone(3, "Piccola stella senza cielo", 1990));
            Cantante cant7 = new Cantante(1, "Lorenzo Cherubini", "Jovanotti", "Toscana");
            cant7.Canzoni.Add(new Canzone(1, "sono una ragazzo fortunato", 2012));
            cant7.Canzoni.Add(new Canzone(2, "Mi fido di te", 2005));
            cant7.Canzoni.Add(new Canzone(3, "Penso positivo", 1994));
            list.Add(cant1);
            list.Add(cant2);
            list.Add(cant3);
            list.Add(cant4);
            list.Add(cant5);
            list.Add(cant6);
            list.Add(cant7);
        }

        void BindForm(ref List<Cantante> list)
        {
            BindingSource bindList = new BindingSource();
            bindList.DataSource = list;
            cmbCantanti.DataSource = bindList;
            cmbCantanti.DisplayMember = "NomeCompleto";

            lstCanzoni.DataSource = list;

            BindingSource bindSongs = new BindingSource();
            bindSongs.DataSource = cmbCantanti.DataSource;
            bindSongs.DataMember = "Canzoni";

            lstCanzoni.DataSource = bindSongs;
            lstCanzoni.DisplayMember = "NomeCanzone";

            txtNazionalita.DataBindings.Add("Text", bindList, "Nazionalita");
            txtAnno.DataBindings.Add("Text", bindSongs, "AnnoProduzione");
        }
    }
}
