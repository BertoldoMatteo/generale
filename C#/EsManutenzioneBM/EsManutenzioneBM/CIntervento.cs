using System;
using System.Collections.Generic;
using System.Text;

namespace EsManutenzioneBM
{
    public enum Categoria
    {
        Controllo,
        Riparazione,
        Sostituzione
    }
    internal class CIntervento
    {
        

        private int codiceIntervento;
        private Categoria categoriaIntervento;
        private double costoIntervento;
        private DateTime dataIntervento;

        public CIntervento(int codice, Categoria categoria, double costo, DateTime data)
        {
            codiceIntervento = codice;
            categoriaIntervento = categoria;
            costoIntervento = costo;
            dataIntervento = data;
        }

        public CIntervento()
        {
            codiceIntervento = 0;
            categoriaIntervento = Categoria.Controllo;
            costoIntervento = 0.0;
            dataIntervento = DateTime.Now;
        }

        public string ToStringIntervento()
        {
            return $"Codice: {codiceIntervento}\nCategoria: {categoriaIntervento}\nCosto: {costoIntervento}\nData: {dataIntervento.ToShortDateString()}\n";
        }

        public double CostoIntervento
        {
            get {  return costoIntervento; }
            set
            {
                if (value < 0) throw new Exception("costo non può essere negativo");
                else costoIntervento = value;
            }
        }

        public Categoria CategoriaIntervento
        {
            get { return categoriaIntervento; }
            set
            {
                if(value != (Categoria)0 && value != (Categoria)1 && value != (Categoria)2) throw new Exception("Categoria non accettabile");
                else categoriaIntervento = value;
            }
        }

        public DateTime DatInetrvento
        {
            get { return dataIntervento; }
            set
            {
                dataIntervento = value;
            }
        }

        public int CodiceIntervento
        {
            get { return codiceIntervento; }
            set
            {
                codiceIntervento = value;
            }
        }
    }
}
