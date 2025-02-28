using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteto-não negativo");
            string str=Console.ReadLine();
            byte n = byte.Parse(str);
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^6);
            Console.WriteLine(n>10);


        }
    }
}
