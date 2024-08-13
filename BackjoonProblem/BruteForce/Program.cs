﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BruteForce는 수학적 노가다를 뜻함



            RecolorTheChessBoard_2();
            void RecolorTheChessBoard_2()
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int totalCnt = n * m;
                string[] temp = new string[n];
                for(int i = 0; i<n; i++)
                {
                    temp[i] = Console.ReadLine();
                }
                
                for(int a = 0; a<n-8; a++)
                {
                    for(int b = 0; b<m-8; b++)
                    {

                    }
                }

            }

            void ColorBoardW(string[] temp, int a, int b, ref int total)
            {
                for(int i = a; i<8 + a; i++)
                {
                    for(int j = b; j<8 + b; j++)
                    {
                        if(i %2 == 0 && j%2 == 0)
                        {
                            ColorToBlack(temp[i][j], ref total);
                        }
                        if(i%2 == 1 && j%2 == 1)
                        {
                            ColorToWhite(temp[i][j], ref total);
                        }
                    }
                }
            }
            void ColorBoardB(string[] temp, int a, int b, ref int total)
            {
                for (int i = a; i < 8 + a; i++)
                {
                    for (int j = b; j < 8 + b; j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            ColorToWhite(temp[i][j], ref total);
                        }
                        if (i % 2 == 1 && j % 2 == 1)
                        {
                            ColorToBlack(temp[i][j], ref total);
                        }
                    }
                }
            }
            void ColorToWhite(char c, ref int total)
            {
                if(c == 'B')
                {
                    c = 'W';
                    total++;
                }
            }
            void ColorToBlack(char c, ref int total)
            {
                if(c == 'W')
                {
                    c = 'B';
                    total++;
                }
            }

            //RecolorTheChessBoard();


            //MathIsNonFaceToFace();

            //DecompositionSum();
            //void DecompositionSum() // 분해합 // 2231
            //{
            //    int temp = int.Parse(Console.ReadLine());
            //    string t = null;
                
            //    for(int i = 0; i<=temp; i++)
            //    {
            //        int sum = i;
            //        t = i.ToString();
            //        foreach(var c in t)
            //        {
            //            sum += (int)c - 48;
            //        }
            //        if(sum == temp)
            //        {
            //            Console.WriteLine(i);
            //            return;
            //        }
            //    }
            //    Console.WriteLine(0);
            //}



            //BlackJack2();
            //void BlackJack2() // 2798
            //{
            //    string[] input1 = Console.ReadLine().Split();
            //    int n = int.Parse(input1[0]);
            //    int m = int.Parse(input1[1]);

            //    string[] input2 = Console.ReadLine().Split();
            //    int[] nums = new int[input2.Length];
            //    int a = 0;
            //    foreach (var c in input2)
            //    {
            //        nums[a++] = int.Parse(c);
            //    }
            //    int sum = 0;
            //    int difference = 3000000;
            //    for (int i = 0; i < nums.Length - 2; i++)
            //    {
            //        for (int j = i + 1; j < nums.Length - 1; j++)
            //        {
            //            for (int k = j + 1; k < nums.Length; k++)
            //            {
            //                if (m - (nums[i] + nums[j] + nums[k]) < 0) continue;
            //                if(m-(nums[i] + nums[j] + nums[k]) <= difference)
            //                {
            //                    difference = Math.Abs(m - (nums[i] + nums[j] + nums[k]));
            //                    sum = nums[i] + nums[j] + nums[k];
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine(sum);
            //}

            //BlackJack();
            //void BlackJack() // 2798 // 시간초과함
            //{
            //    string[] input1 = Console.ReadLine().Split();
            //    int n = int.Parse(input1[0]);
            //    int m = int.Parse(input1[1]);

            //    string[] input2 = Console.ReadLine().Split();
            //    int[] nums = new int[input2.Length];
            //    int a = 0;
            //    foreach (var c in input2)
            //    {
            //        nums[a++] = int.Parse(c);
            //    }
            //    List<int> sumList = new List<int>();
            //    for (int i = 0; i < nums.Length - 2; i++)
            //    {
            //        for (int j = i + 1; j < nums.Length - 1; j++)
            //        {
            //            for (int k = j + 1; k < nums.Length; k++)
            //            {
            //                sumList.Add(nums[i] + nums[j] + nums[k]);
            //            }
            //        }
            //    }
            //    List<int> minusList = new List<int>();
            //    foreach (var c in sumList)
            //    {
            //        minusList.Add(Math.Abs(m - c));
            //    }
            //    for (int i = 0; i < minusList.Count; i++)
            //    {
            //        if (minusList.Min() == minusList[i])
            //        {
            //            Console.WriteLine(sumList[i]);
            //            return;
            //        }

            //    }
            //}
        }

        private static void RecolorTheChessBoard()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            char[,] board = new char[n, m];
            int totalCnt = n*m;
            for(int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                for(int j = 0; j < m; j++)
                {
                    board[i, j] = temp[j];
                }
            }
            // 처음 W로 시작해버리기!
            for(int i = 0; i<n-8; i++)
            {
                for(int j = i; j < i+8; j++)
                {
                    for(int k = 0; k < 8; k++)
                    {
                        
                    }
                }
            }
            int a = 0;
            int b = 0;
            
            // 처음 B로 시작해버리기!
            // 하나씩 이동하면서 

        }

        private static void MathIsNonFaceToFace() // 19532
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            int e = int.Parse(input[4]);
            int f = int.Parse(input[5]);
            for(int x = -999; x <= 999; x++)
            {
                for(int y = -999; y<=999; y++)
                {
                    if(a*x + b*y == c && d*x + e*y == f)
                    {
                        Console.WriteLine(x + " " + y);
                        return;
                    }
                }
            }
        }
    }
}
