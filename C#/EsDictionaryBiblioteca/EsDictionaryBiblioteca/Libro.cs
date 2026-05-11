using System;
using System.Collections.Generic;
using System.Text;

namespace EsDictionaryBiblioteca
{
    internal class Libro
    {
        private string titolo { get; set; }
        private string autore { get; set; }

        private int anno;

        public Libro()
        {
            titolo = "";
            autore = "";
            anno = 0;
        }

        public Libro(string Titolo, string Autore, int Anno)
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.anno = Anno;
        }

        public string Print()
        {
            return $"TITOLO : {this.titolo} ( AUTORE : {this.autore} , ANNO : {this.anno} ) ;\n";
        }

        public int Anno
        {
            get { return anno; }
            set
            {
                if (value <= -3000 || value >= 2026) throw new Exception("Valore non valido");
                value = anno;
            }
        }

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

    }
}
