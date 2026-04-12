using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsClasseLibro
{
    internal class Biblioteca
    {
        private string nome;
        private List<Autore> elencoAut;
        private List<Libro> elencoLib;

        public Biblioteca(string nome, List<Autore> elencoAut, List<Libro> elencoLib)
        {
            this.nome = nome;
            this.elencoAut = elencoAut;
            this.elencoLib = elencoLib;
        }

        public string Info()
        {
            return $"Nome: {this.nome}, Autori: {StampaAutori()}, Libri: {StampaLibri()}";
        }

        public List<Autore> ElencoAutori()
        {
            return this.elencoAut;
        }

        public List<Libro> ElencoLibri()
        {
            return this.elencoLib;
        }

        public string StampaNome()
        {
            return nome;
        }

        public void AggiungiAutore(Autore autor)
        {
            if (!DuplicatoA(autor)) elencoAut.Add(autor);
        }

        public void AggiungiLibro(Libro lib)
        {
            if (!DuplicatoL(lib))
            {
                elencoLib.Add(lib);
                elencoAut.Add(lib.Autore());
            }
        }

        public bool DuplicatoA(Autore aut1)
        {
            foreach(Autore aut2 in this.elencoAut)
            {
                if(Autore.Equals(aut1, aut2)) return true;
            }
            return false;
        }

        public bool DuplicatoL(Libro lib1)
        {
            foreach (Libro lib2 in this.elencoLib)
            {
                if (Libro.Equals(lib1, lib2)) return true;
            }
            return false;
        }

        public List<Autore> ElencoAutoriAnno(int year)
        {
            List<Autore> autori = new List<Autore>();
            foreach(Autore aut in this.elencoAut)
            {
                if (aut.Anno() == year) autori.Add(aut);
            }
            return autori;
        }

        public string StampaLibri()
        {
            string str="";
            foreach(Libro lib in this.elencoLib)
            {
                str += lib.Info() + '\n';
            }
            return str;
        }

        public string StampaAutori()
        {
            string str = "";
            foreach (Autore aut in this.elencoAut)
            {
                str += aut.Info() + '\n';
            }
            return str;
        }

    }
}
