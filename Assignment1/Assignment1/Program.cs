using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Program
    {
        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,5}", matrix[i, j]);

                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int row = r.Next(1, 5);
            int col = r.Next(1, 5);
            int[,] matrix1 = new int[row, col];
            int[,] matrix2 = new int[row, col];

            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    matrix1[i, j] = r.Next(100);

            for (int i = 0; i < matrix2.GetLength(0); i++)
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    matrix2[i, j] = r.Next(100);

            Console.WriteLine("Matrix 1:");
            Print(matrix1);
            Console.WriteLine("Matrix 2:");
            Print(matrix2);

            Console.WriteLine("Matrix Sum: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                    Console.Write("{0,5}", matrix1[i, j] + matrix2[i, j]);

                Console.WriteLine();
            }

            Console.WriteLine("Matrix Subtraction: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                    Console.Write("{0,5}", matrix1[i, j] - matrix2[i, j]);

                Console.WriteLine();
            }

            int colMulti = col;
            while (colMulti == col)
            {
                colMulti = r.Next(1, 5);
            }
            int[,] matrix3 = new int[col, colMulti];
            for (int i = 0; i < matrix3.GetLength(0); i++)
                for (int j = 0; j < matrix3.GetLength(1); j++)
                    matrix3[i, j] = r.Next(100);

            Console.WriteLine("Matrix use for Multiplication: ");
            Print(matrix3);

            Console.WriteLine("Matrix Multiplication: ");
            int[,] multi = new int[matrix1.GetLength(0), matrix3.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        sum += matrix1[i, k] * matrix3[k, j];

                    Console.Write("{0,5}", sum);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
