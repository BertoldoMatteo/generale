using System;
using System.Collections.Generic;
using System.Text;

namespace DivisionePerZero
{
    internal class CCalcolatrice
    {
        int a;
        int b;

       /* VERSIONE 1 
        public double Dividi1(int a, int b)
        {
            double x;

            try
            {
                if (a < 0 || b < 0)
                    throw new ArgumentException("I numeri devono essere positivi");

                x = a / b;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
            catch (ArgumentException)
            {
                return -2;
            }

            return x;
        }*/

        /* VERSIONE 2 */
        public double Dividi2(int a, int b)
        {
            int x;
            if(b==0)
                throw new DivideByZeroException("Non è possibile dividere per zero");
            else if(a<0 || b<0)
                throw new ArgumentException("I numeri devono essere positivi");

            return (double)a/b;
        }
    }
}








