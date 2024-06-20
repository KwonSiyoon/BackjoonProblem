using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonProblem
{
    internal class DiceWorld // 2480번
    {
        /*static void Main(string[] args)
        {
            string[] read = Console.ReadLine().Split(' ');
            int[] num = new int[read.Length];
            int gold = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(read[i]);
            }
            
            if (num[0] == num[1] || num[0] == num[2] || num[1] == num[2])
            {
                if (num[0] == num[1] && num[1] == num[2] && num[0] == num[2])
                {
                    gold = 10000 + num[0] * 1000;
                }
                else
                {
                    if(num[0] == num[1] || num[0] == num[2])
                    {
                        gold = 1000 + num[0] * 100;
                    }
                    else
                    {
                        gold = 1000 + num[1] * 100;
                    }
                }
            }
            else
            {
                if (num[0] > num[1] && num[0] > num[2])
                {
                    gold = num[0] * 100;
                }
                else if (num[1] > num[0] && num[1] > num[2])
                {
                    gold = num[1] * 100;
                }
                else
                {
                    gold = num[2] * 100;
                }
            }
            Console.WriteLine(gold);
        }*/
    }
}
