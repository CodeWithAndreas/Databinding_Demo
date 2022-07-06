using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databinding_Demo
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            persons = ErstellePersonenListe();

            cb_Person.DataSource = persons;
            cb_Person.DisplayMember = "AnzeigeName1";

            AktualisiereTextboxen();
        }

        private void AktualisiereTextboxen()
        {
            tb_vorname.DataBindings.Clear();
            tb_nachname.DataBindings.Clear();
            tb_email.DataBindings.Clear();

            tb_vorname.DataBindings.Add("Text", (cb_Person.SelectedItem as Person), "Vorname");
            tb_nachname.DataBindings.Add("Text", (cb_Person.SelectedItem as Person), "Nachname");
            tb_email.DataBindings.Add("Text", (cb_Person.SelectedItem as Person), "Email");
        }




        private List<Person> ErstellePersonenListe()
        {
            Person p1 = new Person("Susi", "Sorglos");
            p1.Email = "susi@sorglos.bsp";
            Person p2 = new Person("Max", "Muster");
            p2.Email = "max@muster.bsp";
            Person p3 = new Person("Peter", "Pan");
            p3.Email = "peter@pan.bsp";
            Person p4 = new Person("Gustav", "Gans");
            p4.Email = "gustav@gans.bsp";
            Person p5 = new Person("Heidi", "Alpenglück");
            p5.Email = "heidi@alpenglueck.bsp";

            List<Person> t_liste = new List<Person>();
            t_liste.Add(p1);
            t_liste.Add(p2);
            t_liste.Add(p3);
            t_liste.Add(p4);
            t_liste.Add(p5);
            return t_liste;
        }

        private void rb_anzeige1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_anzeige1.Checked)
            {
                cb_Person.DataSource = persons;
                cb_Person.DisplayMember = "AnzeigeName1";
            }
        }

        private void rb_anzeige2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_anzeige2.Checked)
            {
                cb_Person.DataSource = persons;
                cb_Person.DisplayMember = "AnzeigeName2";
            }
        }

        private void cb_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualisiereTextboxen();
        }
    }
}
