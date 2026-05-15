using System;
using System.Collections.Generic;
using System.Text;

namespace EsDictionaryMolo
{
    public enum Tipo
    {
        cibo,
        auto,
        bevande,
        animali
    }

    internal class Barca
    {
        private string nome;
        private string capitano;
        private int equipaggio;
        private Tipo tipoCarico;
        private Porto porto = new Porto();
        


        public Barca()
        {
            nome = "";
            capitano = "";
            equipaggio = 0;
            tipoCarico = (Tipo)0;
        }

        public Barca(string nome, string capitano, int equipaggio, Tipo TipoCarico)
        {
            this.nome = nome;
            this.capitano = capitano;
            this.equipaggio = equipaggio;
            TipoCarico = tipoCarico;
        }

        public string Print()
        {
            return $"NOME : {this.nome}\nCAPITANO: {this.capitano}\nEQUIP : {this.equipaggio}\nTIPO CARICO : {this.tipoCarico}\n";
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value == "") throw new Exception("Il nome della nave non può essere null");
                if (porto.Presente(value)) throw new Exception("Nome della nave già presente");
                nome = value;
            } 
        }

        public string Capitano
        {
            get { return capitano; }
            set
            {
                if (value == "") throw new Exception("Il nome del capitano non può essere null");
                capitano = value;
            }
        }

        public int Equipaggio
        {
            get { return equipaggio; }
            set
            {
                if (value <= 0) throw new Exception("Il numero dell'equipaggio non è valido");
                equipaggio = value;
            }
        }

        public Tipo TipoCarico
        {
            get { return tipoCarico; }
            set
            {
                if(value != (Tipo)0 && value != (Tipo)1 && value != (Tipo)2) throw new Exception("Tipo di Carico non valido");
                tipoCarico = value;
            }
        }

        


    }
}
