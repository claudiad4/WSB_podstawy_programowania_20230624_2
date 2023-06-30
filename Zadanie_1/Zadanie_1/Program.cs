using System;

class Program
{
    static void Main()
    {
        // Inicjalizacja tablicy 10x10
        int[,] tablica = new int[10, 10];

        // Wypełnianie tablicy
        int liczba = 1;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                // Parzyste wiersze (rosnąco)
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
            else
            {
                // Nieparzyste wiersze (malejąco)
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = liczba;
                    liczba--;
                }
                liczba += 10; // Przesunięcie liczby na początek następnego wiersza
            }
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
