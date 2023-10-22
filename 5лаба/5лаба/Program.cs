
using System;
using System.ComponentModel;

namespace Laba5
{
    public class Programm
    {
        public static void Main()
        {
            Calcultor calcultor = new();
            calcultor.Add(1, 3);
            calcultor.Subtract(5, 1);

            
        }
    }
    public class Calcultor
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Devide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
    
}



