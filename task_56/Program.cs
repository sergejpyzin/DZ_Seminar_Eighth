namespace task_56
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
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void PrintArray(int[] array)
        {
            Console.WriteLine($"[ {string.Join(", ", array)} ]");
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
        static int GetNumberRow(int[,] matrix)
        {
            int numberRow = 0;
            int sum = 0;
            int[] arraySum = new int[matrix.GetLength(0)];
            for (int i = 0; i < arraySum.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for(int k = 0;k < matrix.GetLength(1); k++)
                    {
                        sum += matrix[j, k];
                    }
                    arraySum[j] = sum;
                    sum = 0;
                }
            }
            Console.WriteLine($"[ {string.Join(", ", arraySum)} ]");
            int minSum = arraySum[0];
            for (int i = 0; i < arraySum.Length; i++)
            {
                if (arraySum[i] <= minSum)
                {
                    minSum = arraySum[i];
                    numberRow = i + 1;
                }
            }
            return numberRow;
        }
//        Задача 56: Задайте прямоугольный двумерный массив.
//      Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//      Например, задан массив:
//      1 4 7 2
//      5 9 2 3
//      8 4 2 4
//      5 2 6 7
//      Программа считает сумму элементов в каждой строке и выдаёт
//      номер строки с наименьшей суммой элементов: 1 строка
        static void Main(string[] args)
        {
            int row = GetConvertUserMassadge("Введите количество строк: ");
            int colums = GetConvertUserMassadge("Введите количество столбцов: ");
            int minValue = GetConvertUserMassadge("Введите минимальное значение интервала случайных чисел: ");
            int maxValue = GetConvertUserMassadge("Введите максимальное значение интервала случайных чисел: ");
            int[,] myMatrix = GetRandomMatrix(4, 4, 1, 3);
            PrintMatrix(myMatrix);
            int numberRow = GetNumberRow(myMatrix);
            Console.WriteLine(numberRow);

        }
    }
}