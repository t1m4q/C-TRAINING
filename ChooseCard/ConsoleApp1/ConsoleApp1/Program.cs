using System.Diagnostics;
using System.Drawing;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main()
    {
        int n = 0;
        int m = 0;
        char[,] stars = null;
        Console.WriteLine("Выберите сложность:");
        Console.WriteLine("1 - Новичок");
        Console.WriteLine("2 - Рядовой");
        Console.WriteLine("3 - Матёрый НЕДОСТУПНО");
        Console.WriteLine("4 - Герой НЕДОСТУПНО");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose < 1 || choose > 2)
        {
            Process.GetCurrentProcess().Kill();
        }
        else
        {
           
            switch (choose)
            {
                case 1:
                    n = 2;
                    m = 2;
                    stars = new char[n, m];
                    StarsToArray(n,  m,  stars);
                    PrintStarsToArray(n, m, stars);
                    break;
 
                case 2:
                    n = 4;
                    m = 2;
                    stars = new char[n, m];
                    StarsToArray(n, m, stars);
                    PrintStarsToArray(n, m, stars);
                    break;
            }

        }
        Console.WriteLine("Выберите карту");
        int[,] valueToCompare1 = { { 1, 1 }, { 2, 2 } };
        int[,] valueToCompare2 = { { 1, 2 }, { 3, 2 }, { 1, 4 }, { 4, 3 } };
    }



    static void PrintArrayNumbers(int n, int m,  int[,] valueToCompare1, int[,] valueToCompare2)   // ПодуматЬ!!!!
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(valueToCompare2[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void StarsToArray(int n, int m, char[,] stars)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                stars[i, j] = '*';
            }         
        }
    }   // Готово

    static void PrintStarsToArray(int n, int m, char[,] stars)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(stars[i, j] + "\t");
            }
            Console.WriteLine();
        }
    } // Готово

    static void Choose(int n, int m, char[,] stars, int[,] valueToCompare1, int[,] valueToCompare2)
    {
        bool checkWin = true;
        while (checkWin)
        {
            StarsToArray(n, m, stars);
            Console.WriteLine("1");
            PrintArrayNumbers(n, m, valueToCompare1, valueToCompare2);
        }
    }


}

