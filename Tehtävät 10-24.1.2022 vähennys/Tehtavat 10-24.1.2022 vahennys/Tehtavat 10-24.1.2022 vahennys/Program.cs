using System;

namespace Tehtavat_10_24._1._2022_vahennys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yhteen- vai vähennyslasku?");

            string vastaus = Console.ReadLine();

            if (vastaus == "+")
            {
                Console.WriteLine("Anna luku.");
                int luku1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna toinen luku.");
                int luku2 = Int32.Parse(Console.ReadLine());

                int yhteen = (luku1 + luku2);

                Console.WriteLine(luku1 + " plus " + luku2 + " on " + yhteen);
            }

            else if (vastaus == "-")
            {
                Console.WriteLine("Anna luku.");
                int luku1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna toinen luku.");
                int luku2 = Int32.Parse(Console.ReadLine());

                int vahennys = (luku1 - luku2);

                Console.WriteLine(luku1 + " miinus " + luku2 + " on " + vahennys);
            }

        }
    }
}
