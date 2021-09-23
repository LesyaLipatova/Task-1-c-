using System;

namespace Task_1
{
    class Program
    {
       static int[,] Build_rand_squere_matrix(int matrix_size)
        {  
                int n = matrix_size;

                int[,] matrix = new int[n, n];

                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = rnd.Next(-10, 0);

                return matrix;

        }
        static void Print_arr(int[,] arr)
        { 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static bool Check_rows_to_minus_elements(int amount_minus_elements, int[,] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        counter++;
                    }
                }
                if (counter <= amount_minus_elements)
                {
                    return true;
                }
                counter = 0;
            }
            return false;
        }

        static void Main(string[] args){
            int[,] matrix = Build_rand_squere_matrix(3);
            Print_arr(matrix);
            Console.WriteLine(Check_rows_to_minus_elements(2, matrix));

        }
    }
}
