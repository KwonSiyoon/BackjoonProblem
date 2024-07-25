using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorMultipleDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {











            /*FindDivisor();
            void FindDivisor()
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                List<int> divisorList = new List<int>();

                for(int i = 1; i <=a; i++)
                {
                    if(a % i != 0)
                    {
                        continue;
                    }
                    else
                    {
                        divisorList.Add(i);
                    }
                }
                if(divisorList.Count < b)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(divisorList[b-1]);
                }
            }*/

            /*MultipleDivisor();
            void MultipleDivisor() // 5086
            {
                while (true)
                {
                    string[] input = Console.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    if(a==0 && b == 0)
                    {
                        break;
                    }
                    if(b%a == 0)
                    {
                        Console.WriteLine("factor");
                    }
                    else if(a%b == 0)
                    {
                        Console.WriteLine("multiple");
                    }
                    else
                    {
                        Console.WriteLine("neither");
                    }
                }
            }*/
        }
    }
}
