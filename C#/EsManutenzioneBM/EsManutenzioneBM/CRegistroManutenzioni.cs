using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsManutenzioneBM
{
    internal class CRegistroManutenzioni
    {
        private List<CIntervento> interventi;
        private DateTime dataInizioRegistro;
        private DateTime dataFineregistro;
        private string tecnicoResponsabile;
        private string str;
        private double costi;
        private int count;

        public CRegistroManutenzioni()
        {
            interventi = new List<CIntervento>();
            dataInizioRegistro = DateTime.Now;
            dataFineregistro = new DateTime();
            tecnicoResponsabile = "";
        }

        public CRegistroManutenzioni(List<CIntervento> Interventi, DateTime DataInizioRegistro, DateTime DataFineRegistro, string TecnicoResponsabile)
        {
            interventi = Interventi;
            dataInizioRegistro = DataInizioRegistro;
            dataFineregistro= DataFineRegistro;
            tecnicoResponsabile = TecnicoResponsabile;
        }

        public List<CIntervento> Interventi
        {
            get { return interventi; }
            set
            {
                interventi = value;
            }
        }

        public void AggiungiIntervento(CIntervento intervento) //usata
        {
            this.interventi.Add(intervento);
        }

        public void RimuoviIntervento(int codiceIntervento) //usata
        {
            this.interventi.RemoveAt(codiceIntervento);
        }

        public string RicercaIntervento(int codiceIntervento)
        {
            if (codiceIntervento >= interventi.Count) return "Intervento non trovato";
            return interventi[codiceIntervento].ToStringIntervento();
        }

        public string Stamparegistro()
        {
            str = "";
            foreach (var i in interventi) str += $"--INTERVENTO-- \n {i.ToStringIntervento()}\n";
            return str;
        }

        public double CalcoloTotaleCosti() //usata
        {
            costi = 0;
            foreach (var i in interventi) costi += i.CostoIntervento;
            return costi;
        }

        public double CalcoloCostiPerCategoria(Categoria cat) //usata
        {
            costi = 0;
            foreach (var i in interventi) if (i.CategoriaIntervento == cat) costi += i.CostoIntervento;
            return costi;
                
        }

        public int ContaInterventiPerCategoria(Categoria cat) //usata
        {
            count = 0;
            foreach (var i in interventi) if (i.CategoriaIntervento == cat) count++;
            return count;
        }

        public string InterventiCritici()
        {
            foreach (var i in interventi) if (i.CategoriaIntervento == (Categoria)0) str += i.ToStringIntervento();
            return str;
        }

        public double CostoMin() //usata
        {
            costi = interventi[0].CostoIntervento;
            foreach (var i in interventi) if (i.CostoIntervento < costi) costi = i.CostoIntervento;
            return costi;
        }

        public double CostoMax() //usata
        {
            costi = interventi[0].CostoIntervento;
            foreach (var i in interventi) if (i.CostoIntervento > costi) costi = i.CostoIntervento;
            return costi;
        }
    }
}
