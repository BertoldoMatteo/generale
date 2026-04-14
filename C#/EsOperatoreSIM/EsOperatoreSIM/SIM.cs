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
        public string numTel;
        public double cred;
        private List<Telefonata> listaTelefonate;
        //public SIM() // COSTRUTTORE DI DEFAULT
        //{
            //NumTel = 0;
            //Cred = 0;
            //listaTelefonate = new List<Telefonata>();
        //}
        public SIM(string NumTel, double Cred) // COSTRUTTORE PARAMETRIZZATO
        {
            numTel = NumTel;
            cred = Cred;
            listaTelefonate = new List<Telefonata>();
        }

        public string NumTel
        {
            get
            {
                return numTel;
            }
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
        public string StampaDati() // DATI SIM
        {
            string str = "";
            str += $"Numero: {numTel}\n";
            str += $"Credito: €{cred}\n";
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
