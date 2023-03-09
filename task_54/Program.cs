namespace task_54
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
            Console.WriteLine();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int[,] GetRandomMatrix(int row, int colums, int leftBoarder, int rightBoarder)
        {
            int[,] matrix = new int[row, colums];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Random.Shared.Next(leftBoarder, rightBoarder + 1);
                }
            }
            return matrix;
        }

        static void ArrangeMatrixInAscendingOrder(int[,] matrix)
        {
            for(int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = j + 1; k < matrix.GetLength(1); k++)
                        if (matrix[i, j] > matrix[i , k])
                        { 
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temp;

                        }
                }
            }
        }

//        Задача 54: Задайте двумерный массив.
//      Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
//      Например, задан массив:
//      1 4 7 2
//      5 9 2 3
//      8 4 2 4
//      В итоге получается вот такой массив:
//      1 2 4 7
//      2 3 5 9
//      2 4 4 8
        static void Main(string[] args)
        {
            int row = GetConvertUserMassadge("Введите количество строк: ");
            int colums = GetConvertUserMassadge("Введите количество столбцов: ");
            int minValue = GetConvertUserMassadge("Введите минимальное значение интервала случайных чисел: ");
            int maxValue = GetConvertUserMassadge("Введите максимальное значение интервала случайных чисел: ");
            int[,] myMatrix = GetRandomMatrix(row, colums, minValue, maxValue);
            PrintMatrix(myMatrix);
            ArrangeMatrixInAscendingOrder(myMatrix);
            //Console.WriteLine();
            PrintMatrix(myMatrix);

        }
    }
}