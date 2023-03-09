namespace Additional_task_59
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

        static int[,] GetNewMatrix(int[,] matrix)
        {
            int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            int min = matrix[0, 0];
            int minRow = 0;
            int minColums = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minRow = i;
                        minColums = j;
                    }
                }
            }
            for (int i = 0; i < newMatrix.GetLength(0); i++) 
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    if (i != minRow && j != minColums) newMatrix[i, j] = matrix[i, j];
                    
                }
            }
            Console.WriteLine(min);
            return newMatrix;
        }
        //        Задача 59: Задайте двумерный массив из целых чисел.
        //        Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
        //  Например, задан массив:
        //  1 4 7 2
        //  5 9 2 3
        //  8 4 2 4
        //  5 2 6 7
        //  Наименьший элемент - 1, на выходе получим
        //  следующий массив:
        //  9 2 3
        //  4 2 4
        //  2 6 7
        static void Main(string[] args)
        {
            //int row = GetConvertUserMassadge("Введите количество строк: ");
            //int colums = GetConvertUserMassadge("Введите количество столбцов: ");
            //int minValue = GetConvertUserMassadge("Введите минимальное значение интервала случайных чисел: ");
            //int maxValue = GetConvertUserMassadge("Введите максимальное значение интервала случайных чисел: ");
            int[,] myMatrix = GetRandomMatrix(4, 4, 50, 99);
            PrintMatrix(myMatrix);
            int [,] newMatrix = GetNewMatrix(myMatrix);
            PrintMatrix(newMatrix);
        }
    }
}