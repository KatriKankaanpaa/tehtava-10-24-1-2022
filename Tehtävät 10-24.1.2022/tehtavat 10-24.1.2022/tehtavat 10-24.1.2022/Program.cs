using System;

namespace tehtavat_10_24._1._2022_summa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako lukua?");
            int vastaus = Int32.Parse(Console.ReadLine());

            int summa = 0;

            for (int i = 0; i < vastaus; i++)
            {
                Console.WriteLine("Anna luku.");
                summa += Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lukujen keskiarvo on " + summa / vastaus);
        }
    }
}
