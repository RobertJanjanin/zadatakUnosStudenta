using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakk
{
    class Student
    {
        string Ime;
        string Prezime;
        string Smjer;
        int brojIndeksa;
        DateTime datum;

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Smjer1 { get => Smjer; set => Smjer = value; }
        public int BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public Student(string ime, string prezime, string smjer, int brojIndeksa, DateTime datum)
        {
            Ime = ime;
            Prezime = prezime;
            Smjer = smjer;
            this.brojIndeksa = brojIndeksa;
            this.datum = datum;
        }
    }
    }

