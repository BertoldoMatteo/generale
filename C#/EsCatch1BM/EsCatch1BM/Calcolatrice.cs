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
            try
            {
                a = double.Parse(num);
                b = double.Parse(den); 
                div = a / b;
                if(div < 0)
                {
                    throw new ArgumentException();
                }
                if(b == 0)
                {
                    throw new DivideByZeroException();
                }
                return div;
            }
            catch (DivideByZeroException)
            {
                return -1; 
            }
            catch (FormatException)
            {
                return -2;
            }
            catch(ArgumentException)
            {
                return -3;
            }
            catch
            {
                return -4;
            }
        }
    }
}
