using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class matrix
    {  
        public static void printmatrix(int[,] matrix)
        {
            
            //print result
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j] + "\t");

                }
            }
        }
        //read matrix from user
        public static void readMatrix(ref int[,] matrix)
        {
            Console.WriteLine("Enter Matrix : ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2,2];
            int[,] matrix2 = new int[2,2];
            int[,] result = new int[2,2];

            readMatrix(ref matrix1);
            readMatrix(ref matrix2);
            //sum matrix
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i,j]+matrix2[i,j];

                }
            }
            Console.WriteLine("Result of Sum Matrix : ");
            printmatrix(result);

            //multiplication matrix
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];

                }
            }
            Console.WriteLine("Result of Multiplication Matrix : ");
            printmatrix(result);

        }
    }
}
