using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsOperatoreSIM
{
    public class Telefonata
    {
        public string NumDest;
        public int DurMin;

        public Telefonata(string numDest, int durMin) //COSTRUTTORE
        {
            NumDest = numDest;
            DurMin = durMin;
        }

        public string Stampa() //STAMPA DATI
        {
            return $"→ {this.NumDest} | {this.DurMin} min";
        }
    }

}
