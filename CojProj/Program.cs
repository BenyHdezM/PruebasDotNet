using System;
namespace cojproj
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<= Math.Pow(10,4); i++)
            {
                string[] aux = Console.ReadLine().Split();

                double a = Math.Pow(int.Parse(aux[0]), 2);
                double b = Math.Pow(int.Parse(aux[1]), 2);
                double c = Math.Pow(int.Parse(aux[2]), 2);

                if (a <= 0 || b <= 0 || c <= 0) Console.WriteLine("wrong");

                if (a + b == c)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }
    }
}