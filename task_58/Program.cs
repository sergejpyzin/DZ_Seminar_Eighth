namespace task_58
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

        static int [,] GetResultMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] arrayResult = new int [firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
            for (int i = 0; i < arrayResult.GetLength(0); i++)
            {
                for (int j = 0; j < arrayResult.GetLength(1); j++)
                {
                    arrayResult[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
                }
            }
            return arrayResult;
        }
        //        Задача 58: Задайте две матрицы.
        //        Напишите программу, которая будет находить произведение двух матриц.
        //      Например, заданы 2 массива:
        //      1 4 7 2
        //      5 9 2 3
        //      8 4 2 4
        //      5 2 6 7
        //          и
        //      1 5 8 5
        //      4 9 4 2
        //      7 2 2 6
        //      2 3 4 7
        //      Их произведение будет равно следующему массиву:
        //      1 20 56 10
        //      20 81 8 6
        //      56 8 4 24
        //      10 6 24 49
        static void Main(string[] args)
        {
            int row = GetConvertUserMassadge("Введите количество строк: ");
            int colums = GetConvertUserMassadge("Введите количество столбцов: ");
            int minValue = GetConvertUserMassadge("Введите минимальное значение интервала случайных чисел: ");
            int maxValue = GetConvertUserMassadge("Введите максимальное значение интервала случайных чисел: ");
            int[,] myMatrix = GetRandomMatrix(row, colums, minValue, maxValue);
            PrintMatrix(myMatrix);
            int[,] myMultyArray = GetRandomMatrix(row, colums, minValue, maxValue);
            PrintMatrix(myMultyArray);
            int[,] result = GetResultMatrixMultiplication(myMatrix, myMultyArray);
            PrintMatrix(result);           
        }
    }
}