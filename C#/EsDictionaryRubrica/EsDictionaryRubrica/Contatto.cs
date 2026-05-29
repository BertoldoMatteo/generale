using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EsDictionaryRubrica
{
    public class Contatto
    {
        private string telefono;
        private string email;
        private DateTime dataCompleanno;
        private long n;
        
        public Contatto()
        {
            telefono = string.Empty;
            email = string.Empty;
            dataCompleanno = DateTime.Now;
        }

        public Contatto(string Telefono,  string Email,  DateTime DataCompleanno)
        {
            telefono = Telefono;
            email = Email;
            dataCompleanno = DataCompleanno;
        }

        public string Telefono{
            get { return telefono; }
            set
            {
                if (!long.TryParse(value, out n)) throw new Exception("Numero non valido");
                else if (value.Length < 7 || value.Length > 15) throw new Exception("lunghezza del numero non valida");
                else telefono = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                var mail = new MailAddress(value);
                email = value;
            }
        }

        public DateTime DataCompleanno
        {
            get { return dataCompleanno; }
            set
            {
                dataCompleanno = (DateTime)value;
            }
        }

        public string Print()
        {
            return string.Format("TEL : {0,-15} ,EMAIL : {1,-30} ,DATA COMPLEANNO : {2,-2} / {3,-2}",
                     this.telefono,
                     this.Email,
                     dataCompleanno.Day,
                     dataCompleanno.Month);
        }

    }
}
