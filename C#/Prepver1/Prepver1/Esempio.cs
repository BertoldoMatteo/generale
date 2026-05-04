using System;
using System.Collections.Generic;
using System.Text;

namespace Prepver1
{
    internal class Esempio
    {
        private int id;
        private string name;
        private int age;
        private bool sesso;
        private DateTime birthday;
        public Esempio()
        {
            id = 0;
            name = "";
            age = 0;
            sesso = true;
            birthday = DateTime.Now;
        }

        public Esempio(int Id, string Name, int Age, bool Sesso, DateTime Birthday)
        {
            id = Id;
            name = Name;
            age = Age;
            sesso = Sesso;
            birthday = Birthday;
        }

        public string Print()
        {
            string Sesso = sesso ? "MASCHIO" : "FEMMINA";
            return $"ID = {this.id}\nNAME = {this.name}\nAGE = {this.age}\nSESSO = {Sesso}\nDATA DI NASCITA = {birthday.ToShortDateString()   }";
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("L'ID deve essere positivo");
                }
                else id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") throw new Exception("Il nome non può essere vuoto");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 121)
                {
                    throw new Exception("L'età non è reale");
                }
                else age = value;
            }
        }

        public bool Sesso
        {
            get { return sesso; }
            set
            {
                sesso = value;
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value > DateTime.Now) throw new Exception("La data non è passata quindi surreale");
                else birthday = value;
            }
        }

    }
}
