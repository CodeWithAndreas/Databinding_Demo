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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private List<Person> ErstellePersonenListe()
        {
            Person p1 = new Person("Susi", "Sorglos");
            Person p2 = new Person("Max", "Muster");
            Person p3 = new Person("Peter", "Pan");
            Person p4 = new Person("Gustav", "Gans");
            Person p5 = new Person("Heidi", "Alpenglück");

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
    }
}
