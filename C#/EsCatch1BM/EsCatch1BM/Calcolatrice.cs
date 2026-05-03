using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsCatch1BM
{
    internal class Calcolatrice
    {
        private double a;
        private double b;
        private double div;

        public Calcolatrice()
        {
            a = 0;
            b = 0;
        }

        public Calcolatrice(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Divisione(string num, string den)
        {
            try // puo verificarsi l'eccezione di divisione per zero, di formato errato, di argomento non valido o di input non valido
            {
                a = double.Parse(num);
                b = double.Parse(den);
                div = a / b;
                if (b == 0)
                {
                    throw new DivideByZeroException(); // funziona da solo se uso interi // se uso double, restituisce infinity, quindi devo sollevare l'eccezione manualmente
                        //oggetto quindi uso (new)
                }
                if (div < 0)
                {
                    throw new ArgumentException(); // se il risultato è negativo, viene sollevata un'eccezione di argomento
                }
                return div;
            }
            catch (DivideByZeroException) // se si verifica una divisione per zero, restituisce -1
            {
                return -1;
            }
            catch (FormatException) // se si verifica un errore di formato, restituisce -2
            {
                return -2;
            }
            catch (ArgumentException) // se si verifica un errore di argomento, restituisce -3
            {
                return -3;
            }
            catch
            {
                return -4;
            } //Exception è la classe base per tutte le eccezioni, quindi cattura qualsiasi eccezione non gestita specificamente
        }
    }
}