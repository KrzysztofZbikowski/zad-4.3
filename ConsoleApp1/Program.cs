class Zad
{
    static void Main(string[] args)
    {
        int rozmiar, zm = 0, pozmax = 0, zm2 = 0, pozmin = 0, srednia = 0, licz = 0;
        Console.WriteLine("Podaj liczbę elementów tablicy: ");
        rozmiar = int.Parse(Console.ReadLine());
        int[] tablica = new int[rozmiar];
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine("Podaj liczbę: ");
            tablica[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < tablica.Length; i++)
        {
            if (tablica[i] > zm)
            {
                zm = tablica[i];
                pozmax = i;
            }
            if (tablica[i] < zm2)
            {
                zm2 = tablica[i];
                pozmin = i;
            }
            srednia = srednia + tablica[i];
            if (tablica[i] > 0)
            {
                licz++;
            }
            if (i == tablica.Length - 1)
            {
                Console.WriteLine("Maksymalny element tablicy {0} znajduje sie na pozycji {1}", zm, pozmax);
                Console.WriteLine("Minimalny element tablicy {0} znajduje sie na pozycji {1}", zm2, pozmin);
                Console.WriteLine("Średnia elementów tablicy {0}", srednia);
                Console.WriteLine("Lidzba dodatnich elementów tablicy {0}", licz);
            }
        }
        Console.ReadKey();
    }
}