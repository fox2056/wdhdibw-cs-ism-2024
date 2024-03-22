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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdczytajPlik(textBox1.Text);
        }

        private void OdczytajPlik(string nazwa)
        {
            listBoxCalosc.Items.Clear();
            listBoxTyp.Items.Clear();
            listBoxData.Items.Clear();
            listBoxCzas.Items.Clear();
            listBoxAdresWe.Items.Clear();
            listBoxAdresWy.Items.Clear();
            listBoxProtokol.Items.Clear();

            int licznikLinij = 0;

            try
            {
                using (StreamReader sr = new StreamReader(nazwa))
                {

                    while (!sr.EndOfStream)
                    {
                        string linia = sr.ReadLine();
                        listBoxCalosc.Items.Add(linia);
                        PrzetwarzanieLinii(linia);
                        licznikLinij++;

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
        }

        private void OdczytajElement(string linia)
        {

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
            
        }
    }
}
