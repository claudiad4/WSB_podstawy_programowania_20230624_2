using System;

class Program
{
    static void Main()
    {
        int size;

        // Pobieranie rozmiaru tablicy od użytkownika i sprawdzanie poprawności danych
        do
        {
            Console.Write("Proszę podać rozmiar tablicy: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out size))
            {
                Console.WriteLine("Niepoprawne dane. Wprowadź liczbę całkowitą.");
                continue;
            }

            if (size <= 0)
            {
                Console.WriteLine("Podaj liczbę większą od zera.");
                continue;
            }

            break;
        } while (true);

        // Inicjalizacja tablicy
        int[,] tablica = new int[size, size];

        // Zmienne pomocnicze
        int liczba = 1;
        int x = 0;
        int y = 0;
        int kierunek = 0;
        int liczbaKrokow = size;
        int aktualnyKrok = 0;

        // Pętla wypełniająca tablicę
        while (liczba <= size * size)
        {
            tablica[y, x] = liczba;
            liczba += 1;

            // Wybór następnego kierunku
            if (kierunek == 0)
            {
                x += 1;
            }
            else if (kierunek == 1)
            {
                y += 1;
            }
            else if (kierunek == 2)
            {
                x -= 1;
            }
            else if (kierunek == 3)
            {
                y -= 1;
            }

            aktualnyKrok += 1;

            // Sprawdzenie czy należy zmienić kierunek
            if (aktualnyKrok == liczbaKrokow)
            {
                aktualnyKrok = 0;
                if (kierunek == 1 || kierunek == 3)
                {
                    liczbaKrokow -= 1;
                }
                kierunek = (kierunek + 1) % 4;
            }
        }

        // Wypisanie tablicy
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(tablica[i, j]);
            }
            Console.WriteLine();
        }
    }
}
