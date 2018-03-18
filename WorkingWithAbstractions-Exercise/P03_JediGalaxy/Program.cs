using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix = new int[x, y];

            FillMatrix(x, y, matrix);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                EvilMove(matrix);

               sum = CalculateSum( matrix,sum,command);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        static void FillMatrix(int x,int y, int[,] matrix)
        {
            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }

        static void EvilMove(int[,] matrix)
        {
            int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int xEvil = evil[0];
            int yEvil = evil[1];

            while (xEvil >= 0 && yEvil >= 0)
            {
                if (xEvil >= 0 && xEvil < matrix.GetLength(0) && yEvil >= 0 && yEvil < matrix.GetLength(1))
                {
                    matrix[xEvil, yEvil] = 0;
                }
                xEvil--;
                yEvil--;
            }
        }

        static long CalculateSum( int[,] matrix,long sum,string command)
        {
            int[] ivoS = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int xIvo = ivoS[0];
            int yIvo = ivoS[1];

            while (xIvo >= 0 && yIvo < matrix.GetLength(1))
            {
                if (xIvo >= 0 && xIvo < matrix.GetLength(0) && yIvo >= 0 && yIvo < matrix.GetLength(1))
                {
                    sum += matrix[xIvo, yIvo];
                }

                yIvo++;
                xIvo--;
            }
            return sum;
        }
    }
}
