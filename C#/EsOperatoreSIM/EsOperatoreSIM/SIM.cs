using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsOperatoreSIM
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public class SIM
    {
        public string NumTel;
        public double Cred;
        private List<Telefonata> listaTelefonate;
        public SIM(string numTel, double cred) // COSTRUTTORE
        {
            NumTel = numTel;
            Cred = cred;
            listaTelefonate = new List<Telefonata>();
        }
        public void AggTel(string numDest, int durMin) // AGGIUNGI TELEFONATA
        {
            Telefonata t = new Telefonata(numDest, durMin);
            listaTelefonate.Add(t);
        }
        public int CalcMinTot() // MINUTI TOTALI
        {
            int somma = 0;
            foreach(Telefonata t in listaTelefonate) somma += t.DurMin;
            return somma;
        }
        public int CalcTelNum(string numero) // N° TELEFONATE VERSO UN NUMERO
        {
            int count = 0;
            foreach(Telefonata t in listaTelefonate) if(t.NumDest == numero) count++;
            return count;
        }
        public List<Telefonata> GetTel() // LISTA TELEFONATE
        {
            return listaTelefonate;
        }
        public string StampaDati() // DATI SIM
        {
            string str = "";
            str += $"Numero: {NumTel}\n";
            str += $"Credito: €{Cred}\n";
            str += $"Telefonate effettuate: {listaTelefonate.Count}\n";
            str += $"Minuti totali: {CalcMinTot()}\n\n";
            str += "── Elenco Telefonate ──";
            if (listaTelefonate.Count == 0) str += "(nessuna telefonata)";
            else 
                for (int i = 0; i < listaTelefonate.Count; i++) 
                    str += $"\n{i + 1}. {listaTelefonate[i].Stampa()}";
            return str;
        }
    }

}
