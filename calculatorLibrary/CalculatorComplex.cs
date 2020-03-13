using System;

namespace calculatorLibrary
{
    public class CalculatorComplex
    {
        public int Multiply(int x, int y)
       {
           return x * y;
       }

       public int Divide(int x, int y)
       {
           if(y==0) throw new ArgumentException($"Divide by 0 error");
           return x/y;
       }
    }
}
