using System.Diagnostics.CodeAnalysis;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 4 }, { 1, 2, 5 }, { 1, 2, 6 } };
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    sum += matrix[j, k];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}