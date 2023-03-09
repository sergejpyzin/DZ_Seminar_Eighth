namespace task_60
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

        static void PrintMatrix(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
                    }
                    Console.WriteLine();
                }                
            }
            Console.WriteLine();
        }
        static int[,,] GetRandomMatrix(int row, int colums, int height, int leftBoarder, int rightBoarder)
        {
            int[,,] matrix = new int[row, colums, height];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k< matrix.GetLength(2); k++)
                    {
                        matrix[i, j, k] = Random.Shared.Next(leftBoarder, rightBoarder + 1);
                    }
                }
            }
            return matrix;
        }
                
        //        Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
        //        Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        //        массив размером 2 x 2 x 2
        //        12(0,0,0) 22(0,0,1)
        //        45(1,0,0) 53(1,0,1)
        static void Main(string[] args)
        {
            int[,,] matrix = GetRandomMatrix(2, 2, 2, 10, 98);
            PrintMatrix(matrix);
        }
    }
}