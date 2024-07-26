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


            /*Factorization();
            void Factorization() // 소인수분해 // 11653
            {
                int a = int.Parse(Console.ReadLine());
                while(a > 1)
                {
                    for(int i = 2; i<=a; i++)
                    {
                        if(a%i == 0)
                        {
                            Console.WriteLine(i);
                            a /= i;
                            break;
                        }
                    }
                }
            }*/



            /*Decimal();
            void Decimal() // 2581
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                List<int> decimalList = new List<int>();
                for(int i = a; i <= b; i++)
                {
                    int cnt = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0) cnt++;
                        if (cnt >= 3) break;
                        if(i==j && cnt == 2)
                        {
                            decimalList.Add(i);
                        }
                    }
                }
                if(decimalList.Count == 0) Console.WriteLine(-1);
                else
                {
                    int sum = 0;
                    foreach(var c in decimalList)
                    {
                        sum += c;
                    }
                    Console.WriteLine(sum);
                    Console.WriteLine(decimalList[0]);
                }
            }*/


            /*FindDecimal();
            void FindDecimal()
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                int ans = 0;
                for(int i = 0; i < n; i++)
                {
                    int temp = int.Parse(input[i]);
                    int cnt = 0;
                    for(int j = 1; j <= temp; j++)
                    {
                        if(temp%j == 0)
                        {
                            cnt++;
                        }
                        if (cnt >= 3) break;
                        if (j == temp && cnt == 2) ans++;
                    }
                }
                Console.WriteLine(ans);
            }*/

/*
            SumOfDivisors();
            void SumOfDivisors() // 9506
            {
                while (true)
                {
                    int a = int.Parse(Console.ReadLine());
                    if (a == -1) break;
                    List<int> divisorList = new List<int>();
                    for(int i = 1; i < a; i++)
                    {
                        if (a % i == 0) divisorList.Add(i);
                    }
                    bool isPerfect = false;
                    int sum = 0;
                    foreach(var c in divisorList)
                    {
                        sum += c;
                    }
                    if (a == sum) isPerfect = true;
                    if(!isPerfect) Console.WriteLine(a + " is NOT perfect.");
                    else if (isPerfect)
                    {
                        Console.Write($"{a} = {divisorList[0]}");
                        for(int i = 1; i < divisorList.Count; i++)
                        {
                            Console.Write(" + " + divisorList[i]);
                        }
                        Console.WriteLine();
                    }
                }
            }
*/

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
