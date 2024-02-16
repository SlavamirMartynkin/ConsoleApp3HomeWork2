using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            Console.WriteLine("Исходная матрица: ");
            PrintMatrix(array);
            Console.WriteLine();
            Console.WriteLine("Отсортированная матриа: ");
            PrintMatrix(ConvertToMatrix(ConvertToArrayAndSort(array), array));
        }
        public static int[] ConvertToArrayAndSort(int[,] arr)
        {
            int l = arr.GetLength(0) * arr.GetLength(1);
            int[] newArr = new int[l];
            int index = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArr[index] = arr[i, j];
                    index++;
                }                
            }
            //Console.WriteLine(string.Join(",", newArr));
            Array.Sort(newArr);
            //Console.WriteLine(string.Join(",", newArr));
            return newArr;  
        }

        public static int[,] ConvertToMatrix(int[] sortedArr, int[,] baseArr)
        {
            int[,] sortedMatrix = new int[baseArr.GetLength(0), baseArr.GetLength(1)];
            int index = 0;
            for (int i = 0; i < baseArr.GetLength(0); i++)
            {
                for (int j = 0; j < baseArr.GetLength(1); j++)
                {
                    sortedMatrix[i,j] = sortedArr[index];
                    index++;
                }
            }
            return sortedMatrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
