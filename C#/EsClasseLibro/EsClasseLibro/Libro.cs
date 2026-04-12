using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsClasseLibro
{
    public class Libro
    {
        private string titolo;
        private Autore autore;
        private int anno;
        private int pagine;
        private Biblioteca biblio;

        public Libro(string titolo, Autore autor, int anno, int pagine)
        {
            this.titolo = titolo;
            this.autore = autor;
            this.anno = anno;
            this.pagine = pagine;
            autore.Aggiungi(this);
        }

        public string Info()
        {
            return $"Titolo: {this.titolo}, Autore: {this.autore.StampaAutore()}, Anno: {this.anno}, Pagine: {this.pagine}";
        }

        public Autore Autore()
        {
            return this.autore;
        }


    }
}
