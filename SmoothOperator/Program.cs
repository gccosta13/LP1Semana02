using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ")
            string str = Console.ReadLine();
            sbyte n=sbyte.Parse(str);
            n--;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);
        }
    }
}
