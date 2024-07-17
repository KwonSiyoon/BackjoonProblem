using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {




/*
            ColorPaper();
            void ColorPaper() // 2563 // 2차원 자체를 도화지로 생각.
            {
                int n = int.Parse(Console.ReadLine());
                bool[,] temp = new bool[100, 100];
                for(int i =0; i < n; i++)
                {
                    string[] read = Console.ReadLine().Split();
                    int x = int.Parse(read[0]);
                    int y = int.Parse(read[1]);
                    for(int a = x; a < x+10; a++)
                    {
                        for(int b = y; b < y+10; b++)
                        {
                            temp[a, b] = true;
                        }
                    }
                }
                int sum = 0;
                foreach(bool c in temp)
                {
                    if (c) sum++;
                }
                Console.WriteLine(sum);
            }

*/








/*
            void ReadVerticalLineRef() // 10798 Reference
            {
                List<char[]> list = new List<char[]>(); // 배열의 리스트를 만듬.
                for (int i = 0; i < 5; i++)
                {
                    string input = Console.ReadLine();
                    list.Add(input.ToCharArray()); // string을 char[]로 변환하여 list에 저장.
                }

                for (int i = 0; i < 15; i++) // 문자 순서대로 반복. 15대신 length의 max값을 넣어도 됨.
                {
                    for (int j = 0; j < 5; j++) // 줄 순서.
                    {
                        if (list[j].Length > i) // 글자 수가 넘는건 제외. 오류 방지
                        {
                            Console.Write(list[j][i]);
                        }
                    }
                }
            }


            ReadVerticalLine();
            void ReadVerticalLine() // 10798
            {
                string[] input = new string[5];
                int[] length = new int[5];
                
                for(int i =0; i < 5; i++)
                {
                    input[i] = Console.ReadLine();
                    length[i] = input[i].Length;
                }

                List<char> list = new List<char>();
                for(int i = 0; i < length.Max(); i++) // 문자마다
                {
                    for(int j = 0; j < input.Length; j++) // 줄마다
                    {
                        if (i >= length[j] && j <= input.Length - 2)
                        {
                            continue;
                        }
                        else if (i >= length[j] && j == input.Length - 1) break;
                        list.Add(input[j][i]);
                    }
                }
                foreach(char c in list)
                {
                    Console.Write(c);
                }

            }
*/ // 10798

/*
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
*/


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
*/ // 2738
        }
    }
}
