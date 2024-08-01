using System;
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


            DecompositionSum();
            void DecompositionSum() // 분해합 // 2231
            {
                int temp = int.Parse(Console.ReadLine());
                string t = null;
                
                for(int i = 0; i<=temp; i++)
                {
                    int sum = i;
                    t = i.ToString();
                    foreach(var c in t)
                    {
                        sum += (int)c - 48;
                    }
                    if(sum == temp)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                Console.WriteLine(0);
            }



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
    }
}
