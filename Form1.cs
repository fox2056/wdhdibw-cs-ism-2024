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

namespace lab1
{
    public partial class Form1 : Form

    {
        private int licznikLinij;
    
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBoxCalosc.Items.Clear();
            listBoxTyp.Items.Clear();
            listBoxData.Items.Clear();
            listBoxCzas.Items.Clear();
            listBoxAdresWe.Items.Clear();
            listBoxAdresWy.Items.Clear();
            listBoxProtokol.Items.Clear();

            licznikLinij = 0;

            if (textBox1.Text == null || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Wybierz plik albo folder!");
            }
            else if (File.Exists(textBox1.Text))
                OdczytajPlik(textBox1.Text);
            else if (Directory.Exists(textBox1.Text))
            {
                string[] files = Directory.GetFiles(textBox1.Text, "*.txt");
                foreach(String file in files)
                    OdczytajPlik(file);
            }
        }

        private void OdczytajPlik(string nazwa)
        {
            try
            {
                using (StreamReader sr = new StreamReader(nazwa))
                {

                    while (!sr.EndOfStream)
                    {
                        string linia = sr.ReadLine();
                        listBoxCalosc.Items.Add(linia);
                        PrzetwarzanieLinii(linia);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            toolStripStatusLabel2.Text = "Liczba załadowanych wierszy = " + licznikLinij;
        }

        private void PrzetwarzanieLinii(string linia)
        {
            string[] czesci = linia.Split(',');
            if (czesci.Length != 6) return;

            string typ = czesci[0].Trim();

            if (typ.StartsWith("type")) return;

            listBoxTyp.Items.Add(typ);

            string data = czesci[1].Trim();
            listBoxData.Items.Add(data);

            string czas = czesci[2].Trim();
            listBoxCzas.Items.Add(czas);

            string adresWe = czesci[3].Trim();
            listBoxAdresWe.Items.Add(adresWe);

            string adresWy = czesci[4].Trim();
            listBoxAdresWy.Items.Add(adresWy);

            string protokol = czesci[5].Trim();
            listBoxProtokol.Items.Add(protokol);

            licznikLinij++;
        }


        private void WybieraniePliku()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz plik";
                openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                }
            }
        }

        private void WybieranieKatalogu()
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFolderDialog.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WybieraniePliku();
        }

        private void wybraćPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WybieraniePliku();
        }

        private void oProgramieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorzy to Olek i Krystian", caption: "Autorzy");
        }

        private void wybraćKatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WybieranieKatalogu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WybieranieKatalogu();
        }
    }
}
