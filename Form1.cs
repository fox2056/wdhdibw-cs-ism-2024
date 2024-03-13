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
            try
            {
                using (StreamReader sr = new StreamReader(nazwa))
                {

                    while (!sr.EndOfStream)
                    {
                        string linia = sr.ReadLine();
                        DodajDoListBoxa(linia);
                        PrzetwarzanieLinii(linia);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrzetwarzanieLinii(string linia)
        {
            string[] czesci = linia.Split(',');
            if (czesci.Length < 6 || czesci.Length > 6) return;

            listBox2.Items.Add(czesci[0].Trim());
            listBox3.Items.Add(czesci[1].Trim());
            listBox4.Items.Add(czesci[2].Trim());
            listBox5.Items.Add(czesci[3].Trim());
            listBox6.Items.Add(czesci[4].Trim());
            listBox7.Items.Add(czesci[5].Trim());


        }

        private void DodajDoListBoxa(string linia)
        {
            listBox1.Items.Add(linia);
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
