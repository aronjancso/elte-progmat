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
            int n;
            Ember[] emberek;
            Ember keresett;
            int index;

            Console.Error.Write("n = ");
            int.TryParse(Console.ReadLine(), out n);

            index = 0;
            emberek = new Ember[n];
            keresett = emberek[index];

            for (int i = 0; i < n; i++)
            {
                Console.Error.Write("{0}. ember = ", i + 1);
                string sor = Console.ReadLine();

                string[] sorReszlet = sor.Split(" ");
                if (sorReszlet.Length == 3)
                {
                    int.TryParse(sorReszlet[0], out emberek[i].ev);
                    int.TryParse(sorReszlet[1], out emberek[i].ho);
                    int.TryParse(sorReszlet[2], out emberek[i].nap);

                    if (((emberek[i].ev * 10000) + (emberek[i].ho * 100) + (emberek[i].nap)) <
                        ((keresett.ev * 10000) + (keresett.ho * 100) + (keresett.nap)) || i == 0)
                    {
                        keresett = emberek[i];
                        index = i + 1;
                    }
                }
            }

            Console.WriteLine(index);
        }
    }
}
