using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// BruteForce는 수학적 노가다를 뜻함
namespace BruteForce
{
    internal class Program
    {
        static void Main(string[] args)
        {






            ArrayNumber();
            void ArrayNumber()
            {
                int n = int.Parse(Console.ReadLine());
                int[] nums = new int[n];
                for(int i = 0; i < n; i++)
                {
                    nums[i] = int.Parse(Console.ReadLine());
                }
                for(int i = 0; i < n-1; i++)
                {
                    for(int j = i+1; j < n; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            int a = nums[i];
                            nums[i] = nums[j];
                            nums[j] = a;
                        }
                    } 
                }
                foreach(var c in nums)
                {
                    Console.WriteLine(c);
                }
            }


            #region 2839
            //DeliverySugar(); 
            //void DeliverySugar() // 2839
            //{
            //    // 3킬로 봉지와 5킬로 봉지 있음
            //    // 정확히 배달 못하면 -1
            //    int n = int.Parse(Console.ReadLine());
            //    // 5킬로 개수.
            //    int a = n / 5;
            //    int b = 0;
            //    while (a >= 0)
            //    {
            //        if((n-5*a)%3 == 0)
            //        {
            //            b = (n - 5 * a) / 3;
            //            break;
            //        }
            //        else
            //        {
            //            a--;
            //            if (a == -1)
            //            {
            //                Console.WriteLine(-1);
            //                return;
            //            }
            //        }

            //    }
            //    Console.WriteLine(a+b);
            //}
            #endregion

            #region 1436
            //MovieDirector();
            //void MovieDirector()
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    List<int> list = new List<int>();
            //    int a = 665;
            //    while(list.Count < n)
            //    {
            //        a++;
            //        if (a.ToString().Contains("666"))
            //        {
            //            list.Add(a);
            //        }
            //    }
            //    Console.WriteLine(list[n-1]);
            //}
            #endregion

            #region 체스판 채우기 백준 1018문제
            //RecolorTheChessBoard_2();
            //void RecolorTheChessBoard_2()
            //{
            //    string[] input = Console.ReadLine().Split();
            //    int n = int.Parse(input[0]);
            //    int m = int.Parse(input[1]);
            //    int totalCnt = n * m;
            //    string[] temp = new string[n];
            //    for(int i = 0; i<n; i++)
            //    {
            //        temp[i] = Console.ReadLine();
            //    }

            //    for(int a = 0; a<n-7; a++)
            //    {
            //        for(int b = 0; b<m-7; b++)
            //        {
            //            int k = ColorBoardB(temp, a, b);
            //            int l = ColorBoardW(temp, a, b);
            //            if (k < totalCnt) totalCnt = k;
            //            if (l < totalCnt) totalCnt = l;
            //        }
            //    }
            //    Console.WriteLine(totalCnt);

            //}

            //int ColorBoardW(string[] temp, int a, int b)
            //{
            //    int total = 0;
            //    for(int i = a; i<8 + a; i++)
            //    {
            //        for(int j = b; j<8 + b; j++)
            //        {
            //            if(i %2 == 0 && j%2 == 0)
            //            {
            //                ColorToWhite(temp[i][j], ref total);
            //            }
            //            else if(i%2 == 1 && j%2 == 1)
            //            {
            //                ColorToWhite(temp[i][j], ref total);
            //            }
            //            else
            //            {
            //                ColorToBlack(temp[i][j], ref total);
            //            }
            //        }
            //    }
            //    return total;
            //}
            //int ColorBoardB(string[] temp, int a, int b)
            //{
            //    int total = 0;
            //    for (int i = a; i < 8 + a; i++)
            //    {
            //        for (int j = b; j < 8 + b; j++)
            //        {
            //            if (i % 2 == 0 && j % 2 == 0)
            //            {
            //                ColorToBlack(temp[i][j], ref total);
            //            }
            //            else if (i % 2 == 1 && j % 2 == 1)
            //            {
            //                ColorToBlack(temp[i][j], ref total);
            //            }
            //            else
            //            {
            //                ColorToWhite(temp[i][j], ref total);
            //            }
            //        }
            //    }
            //    return total;
            //}
            //void ColorToWhite(char c, ref int total)
            //{
            //    if(c == 'B')
            //    {
            //        c = 'W';
            //        total++;
            //    }
            //}
            //void ColorToBlack(char c, ref int total)
            //{
            //    if(c == 'W')
            //    {
            //        c = 'B';
            //        total++;
            //    }
            //}
            #endregion

            #region 이전 문제
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
            #endregion
        }


        #region 19532문제
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
        #endregion

    }
}
