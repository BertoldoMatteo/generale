using System;
using System.Collections.Generic;
using System.Text;

namespace EsDictionaryMolo
{
    internal class Porto
    {
        private Dictionary<int, Barca> barche { get; set; }
        private int n, count;
        private Barca barca;
        private List<string> nomiNavi = ["Sole", "Luna", "Saturno", "Giove", "Venere", "Mercurio", "Terra", "Urano", "Nettuno", "SuperNova", "NovaBlast", "Galileo", "Newton", "Einstein", "Fermi"];
        private List<string> nomiCapitani = ["Nerone", "Venere", "Sandokan", "Barbanera", "Lucciola", "Ercole", "Nerone", "Calcione", "Lerino", "Marios", "Narius", "Valter", "Charles", "Piastri", "Hadjar"];
        private Random rand;
        private string str = "";

        public Porto()
        {
            barche = new Dictionary<int, Barca>();
        }

        public Dictionary<int, Barca> Barche
        {
            get { return barche; }
            set { barche = value;}
        }

        public void RegistraBarche()
        {
            Random rand = new Random();
            count = rand.Next(5, 16);

            for (int i = 0; i < count; i++)
            {
                if (nomiNavi.Count == 0) break;
                this.barche[i] = BarcaCasuale();
            }
            
        }

        public Barca BarcaCasuale()
        {
            Barca barca = new Barca();
            Random rand = new Random();
            n = rand.Next(nomiNavi.Count);
            barca.Nome = nomiNavi[n];
            nomiNavi.RemoveAt(n);

            n = rand.Next(nomiCapitani.Count);
            barca.Capitano = nomiCapitani[n];

            n = rand.Next(1, 151);
            barca.Equipaggio = n;

            n = rand.Next(0, 3);
            barca.TipoCarico = (Tipo)n;

            return barca;
        }

        public string GestisciPartenze(Tipo TipoCarico,ref int count)
        {
            count = 0;
            str = "";
            foreach(var i in barche)
            {
                if (i.Value.TipoCarico == TipoCarico)
                {
                    str += $"\nID : {i.Key}\n {i.Value.Print()} \n";
                    barche.Remove(i.Key);
                    count++;
                }
            }
            if (count == 0) str = $"Nessuna nave trovata con il carico di tipo : {TipoCarico.ToString()}";
            else if (count == 1) str += $"E' stata eliminata solo una nave";
            else str += $"Sono state trovate ed eliminate {count} navi\n";
            return str;
        }

        public bool Presente(string nome)
        {
            bool pres = false;
            foreach(var b in barche)
            {
                if(b.Value.Nome == nome) pres = true;
            }
            return pres;
        }

    }
}
