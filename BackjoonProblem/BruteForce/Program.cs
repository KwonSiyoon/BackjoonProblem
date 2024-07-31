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


            BlackJack();
            void BlackJack()
            {
                string[] input1 = Console.ReadLine().Split();
                int n = int.Parse(input1[0]);
                int m = int.Parse(input1[1]);

                string[] input2 = Console.ReadLine().Split();
                int[] nums = new int[input2.Length];
                int a = 0;
                foreach (var c in input2)
                {
                    nums[a++] = int.Parse(c);
                }
                List<int> sumList = new List<int>();
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        for (int k = j + 1; k < nums.Length; k++)
                        {
                            sumList.Add(nums[i] + nums[j] + nums[k]);
                        }
                    }
                }
                List<int> minusList = new List<int>();
                foreach (var c in sumList)
                {
                    minusList.Add(Math.Abs(m - c));
                }
                for (int i = 0; i < minusList.Count; i++)
                {
                    if (minusList.Min() == minusList[i])
                    {
                        Console.WriteLine(sumList[i]);
                        return;
                    }

                }
            }
            
        }
    }
}
