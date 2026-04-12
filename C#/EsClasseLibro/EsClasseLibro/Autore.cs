using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsClasseLibro
{
    public class Autore
    {
        private string cognome;
        private string nome;
        private bool sesso;
        private DateOnly nascita;
        private List<Libro> elencoLib;

        public Autore(string cognome, string nome, bool sesso, DateOnly nascita)
        {
            this.cognome = cognome;
            this.nome = nome;
            this.sesso = sesso;
            this.nascita = nascita;
            this.elencoLib = new List<Libro>();

        }

        public string Info()
        {
            string sesso = this.sesso ? "MASCHIO" : "FEMMINA";
            return $"Cognome: {this.cognome}, Nome: {this.nome}, Sesso: {sesso}, Nascita: {this.nascita},\n Elenco: {StampaLib()}";
        }

        public List<Libro> ElencoLib()
        {
            return elencoLib;
        }

        public string StampaLib()
        {
            string str = "";
            foreach(Libro libro in elencoLib)
            {
                str += libro.Info();
            }
            return str;
        }

        public string StampaAutore()
        {
            return this.nome;
        }

        public int Anno()
        {
            return this.nascita.Year;
        }

        public int Aggiungi(Libro libroNuovo)
        {
            this.elencoLib.Add(libroNuovo);
            return this.elencoLib.Count;
        }
    }
}
