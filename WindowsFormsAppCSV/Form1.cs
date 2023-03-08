using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String file = @"C:\Users\korisnik\Desktop\NIOP\Novo.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Ime", "Prezime", "Email", "Godina Rođenja" };
            output.AppendLine(string.Join(separator, headings));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Osoba> ListOsoba = new List<Osoba>();
            try
            {
                Osoba osoba = new Osoba(textIme.Text, textPrezime.Text, textEm.Text, Convert.ToUInt16(textGod.Text));
                textIme.Clear();
                textPrezime.Clear();
                textEm.Clear();
                textGod.Clear();

                DialogResult upit = MessageBox.Show("Želite li unijeti još podataka?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (upit)
                {
                    case DialogResult.Yes:
                    {
                            ListOsoba.Add(osoba);
                            break;
                    }
                    case DialogResult.No:
                        {
                            ListOsoba.Add(osoba);
                            
                            break;
                        }
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
