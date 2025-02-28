using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do cilindro: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Insira o raio do cilindro: ");
            string str2 = Console.ReadLine();
            
            double r = double.Parse(str1);
            double a = double.Parse(str2);
            
            double v = Math.PI*Math.Pow(r,r)*a;
            double sa = 2*Math.PI*r*(r+a);

            Console.WriteLine($"{v:f3}");
            Console.WriteLine($"{sa:f3}"); 

        }
    }
}
