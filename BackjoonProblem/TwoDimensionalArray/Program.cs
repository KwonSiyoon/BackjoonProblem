using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {



            MaxValue();
            void MaxValue()
            {
                int[,] nums = new int[9, 9];
                string[] input = new string[9];
                int max = 0;
                for (int i = 0; i<9; i++)
                {
                    input = Console.ReadLine().Split();
                    for (int j = 0; j<9; j++)
                    {
                        nums[i, j] = int.Parse(input[j]);
                    }
                }
                foreach(var n in nums)
                {
                    if(n > max)
                    {
                        max = n;
                    }
                }
                int row = 0;
                int colum = 0;

                for(int i =0; i < 9; i++)
                {
                    for(int j = 0; j < 9; j++)
                    {
                        if (nums[i,j] == max)
                        {
                            row = i;
                            colum = j;
                            break;
                        }
                    }
                }
                Console.WriteLine(max);
                Console.WriteLine(row+1 + " " + colum+1);

            }



/*
            PlusMatrix();
            void PlusMatrix() // 2738
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int[,] a = new int[n, m];
                int[,] b = new int[n, m];
                for(int i = 0; i < n; i++)
                {
                    string[] temp = Console.ReadLine().Split();
                    for(int j=0; j < m; j++)
                    {
                        a[i, j] = int.Parse(temp[j]);
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    string[] temp = Console.ReadLine().Split();
                    for (int j = 0; j < m; j++)
                    {
                        b[i, j] = int.Parse(temp[j]);
                    }
                }
                int[] sum = new int[m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sum[j] = a[i, j] + b[i, j];
                        Console.Write(sum[j] + " ");
                    }
                    Console.WriteLine();
                }
            }
*/
        }
    }
}
