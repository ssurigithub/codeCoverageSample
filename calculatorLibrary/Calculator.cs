using System;

namespace calculatorLibrary
{
    public class Calculator
    {
        public int Add(int x, int y)
       {
           return x + y;
       }

       public int Subtract(int x, int y)
       {
           if(x < y) throw new ArgumentException($"{x} can't be less than {y}");
           return x -y;
       }
    }
}
