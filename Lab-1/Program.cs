using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, m];

            // Ввод матрицы
            Console.WriteLine("Введите элементы матрицы построчно:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Вывод матрицы по столбцам
            Console.WriteLine("Матрица по столбцам:");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
