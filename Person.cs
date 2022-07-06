using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding_Demo
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public Person(int id, string vorname, string nachname, string strasse,
            string hausNr, string plz, string ort, string land, string telefonNr, string email)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Strasse = strasse;
            HausNr = hausNr;
            Plz = plz;
            Ort = ort;
            Land = land;
            TelefonNr = telefonNr;
            Email = email;
        }


        public int? Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string HausNr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }
        public string TelefonNr { get; set; }
        public string Email { get; set; }

        // Neue Eigenschaft

        public string AnzeigeName1
        {
            get { return this.Nachname + ", " + this.Vorname; }
        }
        public string AnzeigeName2
        {
            get { return this.Vorname + " " + this.Nachname; }
        }


    }
}

