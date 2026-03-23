using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLibriBM
{
    public enum Genere
    {
        Giallo,
        Fantasy,
        Fantascienza,
        Romanzo,
        Saggio
    }

    public struct Libro
    {
        public int anno, pagine;
        public bool disponibile;
        public string titolo, autore, ISBN;
        public Genere genere;
        public Libro(int anno, bool disponibile, string titolo, string autore, string ISBN, Genere genere, int pagine)
        {
            this.anno = anno;
            this.ISBN = ISBN;
            this.disponibile = disponibile;
            this.titolo = titolo;
            this.autore = autore;
            this.genere = genere;
            this.pagine = pagine;
        }

        public string stampa()
        {
            string disp = this.disponibile ? "SI" : "NO";
            return $"TIT: {this.titolo}, AUT: {this.autore}, GEN: {this.genere}, ANNO: {this.anno}, PAG: {this.pagine}, DISP: {disp}, ISBN: {this.ISBN}";
        }

        public string print()
        {
            string disp = this.disponibile ? "SI" : "NO";
            return $"{this.titolo},{this.autore},{this.genere},{this.anno},{this.pagine},{disp},{this.ISBN}";
        }
    }
}
