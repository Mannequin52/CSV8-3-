using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCSV
{
    class Osoba
    {
        string ime, prezime, emial;
        int godRod;

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime + "Prezime: " + this.prezime + "Godina rođenja: " + this.godRod;
            return base.ToString();
        }

        public Osoba(string ime, string prezime, string emial, int godRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.emial = emial;
            this.godRod = godRod;
        }
    }
}
