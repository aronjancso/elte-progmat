/*
 * Hallgató: Jancsó Áron
 * Neptun:   I8MV9H
 */

using System;

namespace C1
{
    internal class Program
    {
        struct Ember
        {
            public int ev;
            public int ho;
            public int nap;
        }

        static void Main(string[] args)
        {
            // Deklaracio
            int n;
            Ember[] emberek;
            Ember keresettEmber;
            int keresettIndex;

            // Beolvasas
            Console.Error.Write("n = ");
            int.TryParse(Console.ReadLine(), out n);

            emberek = new Ember[n];
            for (int i = 0; i < n; i++)
            {
                Console.Error.Write("{0}. ember = ", i + 1);
                string[] szuletesiDatum = Console.ReadLine().Split(" ");

                int.TryParse(szuletesiDatum[0], out emberek[i].ev);
                int.TryParse(szuletesiDatum[1], out emberek[i].ho);
                int.TryParse(szuletesiDatum[2], out emberek[i].nap);
            }

            // Feldolgozas
            keresettIndex = 1;
            keresettEmber = emberek[keresettIndex - 1];
            for (int i = 0; i < n; i++)
            {
                if (((emberek[i].ev * 10000) + (emberek[i].ho * 100) + emberek[i].nap) <
                    ((keresettEmber.ev * 10000) + (keresettEmber.ho * 100) + keresettEmber.nap))
                {
                    keresettEmber = emberek[i];
                    keresettIndex = i + 1;
                }
            }

            // Kiiras
            Console.WriteLine(keresettIndex);
        }
    }
}
