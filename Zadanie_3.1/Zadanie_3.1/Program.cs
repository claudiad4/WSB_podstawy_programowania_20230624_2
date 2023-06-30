using System;

class Program
{
    static void Main()
    {
        int size;

        // Pobieranie rozmiaru tablicy od użytkownika i sprawdzanie poprawności danych
        do
        {
            Console.Write("Proszę o podanie rozmiaru tablicy: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out size))
            {
                Console.WriteLine("Niepoprawne dane. Wprowadź liczbę całkowitą.");
                continue;
            }

            if (size <= 0)
            {
                Console.WriteLine("Rozmiar tablicy musi być większy od zera.");
                continue;
            }

            break;
        } while (true);

        // Inicjalizacja tablicy
        int[,] tablica = new int[size, size];

        // Wypełnianie tablicy
        int liczba = 1;
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0)
            {
                // Parzyste wiersze (rosnąco)
                for (int j = 0; j < size; j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
            else
            {
                // Nieparzyste wiersze (malejąco)
                for (int j = 0; j < size; j++)
                {
                    tablica[i, j] = liczba;
                    liczba--;
                }
                liczba += size; // Przesunięcie liczby na początek następnego wiersza
            }
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
