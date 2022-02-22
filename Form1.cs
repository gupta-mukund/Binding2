using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace binding2
{
    public partial class Form1 : Form
    {
        List<GenereMusica> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<GenereMusica>();
            GenerateMusicList(ref list);
            BindForm(ref list);
            GenerateJson(ref list);
        }

        void GenerateMusicList(ref List<GenereMusica> list)
        {
            GenereMusica gen1 = new GenereMusica("RK", "Rock");
            gen1.Cantanti.Add(new Cantante(1, "David Bowie", "Duca Bianco", "Uk"));
            gen1.Cantanti.Add(new Cantante(2, "Bruce Springesteen", "The Boss", "Usa"));
            gen1.Cantanti.Add(new Cantante(3, "Anna Bullock", "Tina Turner", "Usa"));
            GenereMusica gen2 = new GenereMusica("PP", "Pop");
            gen2.Cantanti.Add(new Cantante(1, "Robin Rihanna", "Rihanna", "Barbados"));
            gen2.Cantanti.Add(new Cantante(2, "Veronica Ciccone", "Madonna", "Usa"));
            gen2.Cantanti.Add(new Cantante(1, "Justine Timberlake", "Timbarlake", "Usa"));
            GenereMusica gen3 = new GenereMusica("RkC", "Rock Complessi");
            gen3.Cantanti.Add(new Cantante(1, "Pink Floyd", "genio puro", "Uk"));
            gen3.Cantanti.Add(new Cantante(2, "Alan Parson", "Project", "Uk"));
            gen3.Cantanti.Add(new Cantante(3, "Mark Knopfler", "Dire Straits", "Uk"));
            GenereMusica gen4 = new GenereMusica("ITA", "Melodia Italiana");
            gen4.Cantanti.Add(new Cantante(1, "Eros Ramazzotti", "Eros", "Lazio"));
            gen4.Cantanti.Add(new Cantante(2, "Antonio Ligabue", "Liga", "Emilia"));
            gen4.Cantanti.Add(new Cantante(3, "Lorenzo Cherubini", "Jovanotti", "Toscana"));

            list.Add(gen1);
            list.Add(gen2);
            list.Add(gen3);
            list.Add(gen4);
        }

        void BindForm(ref List<GenereMusica> list)
        {
            Binding textBoxBind = new Binding("Text", txtNomeStudente, "Text");
            txtNomeStudenteBind.DataBindings.Add(textBoxBind);

            BindingSource listBind = new BindingSource();
            listBind.DataSource = list;

            cmbGenere.DataSource = listBind;
            cmbGenere.DisplayMember = "Sigla";

            txtNome.DataBindings.Add("Text", listBind, "NomeGenere");

            BindingSource singersBind = new BindingSource();

            singersBind.DataSource = cmbGenere.DataSource;
            singersBind.DataMember = "Cantanti";
            cmbCantante.DataSource = singersBind;
            cmbCantante.DisplayMember = "NomeCompleto";

            cmbNickName.DataBindings.Add("Text", singersBind, "NomeArte");
            cmbNazionalita.DataBindings.Add("Text", singersBind, "Nazionalita");
        }

        void GenerateJson(ref List<GenereMusica> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            txtJson.Text = json;
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\data.json", json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }
    }
}
