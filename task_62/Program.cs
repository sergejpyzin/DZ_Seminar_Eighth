namespace task_62
{
    internal class Program
    {
        static int GetConvertUserMassadge(string userMassedge)
        {
            int convertNumber = 0;
            while (true)
            {
                Console.WriteLine(userMassedge);
                bool checkUserMassedge = int.TryParse(Console.ReadLine(), out convertNumber);
                if (checkUserMassedge) return convertNumber;
                else Console.WriteLine("Ошибка! Попробуйте еще раз.");
            }            
        }
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
        static int[,] GetSpiralMatrix(int side)
        {
            int[,] matrix = new int[side, side];
            int row = 0;
            int colums = 0;

            for (int temp = 1; temp <= Math.Pow(side, 2); temp++)
            {
                matrix[row, colums] = temp;
                if (row <= colums + 1 && row + colums < matrix.GetLength(1) - 1)
                    colums++;
                else if (row < colums && row + colums >= matrix.GetLength(0) - 1)
                    row++;
                else if (row >= colums && row + colums > matrix.GetLength(1) - 1)
                    colums--;
                else
                    row--;
            }            
            return matrix;
        }


//        Задача 62. Заполните спирально массив 4 на 4.
//      Например, на выходе получается вот такой массив
//      1 2 3 4
//      12 13 14 5
//      11 16 15 6
//      10 9 8 7
        static void Main(string[] args)
        {
            int sideMatrix = GetConvertUserMassadge("Введите сторону квадратной матрицы: ");
            int[,] myMatrix = GetSpiralMatrix(sideMatrix);

            PrintMatrix(myMatrix);
        }
    }
}