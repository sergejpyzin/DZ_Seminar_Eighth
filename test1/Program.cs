namespace test1
{
    internal class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int[,] GetRandomMatrix(int row, int colums)
        {
            
            int[,] matrix = new int[row, colums];
            int i = 0;
            int j = 0;

            for (int temp = 1; temp <= row * colums; temp++)
            {
                matrix[i, j] = temp;
                if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= matrix.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > matrix.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int[,] myMatrix = GetRandomMatrix(4, 4);
            PrintMatrix(myMatrix);
            
        }
    }
}