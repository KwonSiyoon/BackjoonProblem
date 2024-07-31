using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //AsymptoticNotation();
            //void AsymptoticNotation() // 점근적 표기법 // 상수계수와 중요하지 않은 항목을 제거한 것 // 24313
            //{
            //    string[] input = Console.ReadLine().Split();
            //    int a1 = int.Parse(input[0]);
            //    int a0 = int.Parse(input[1]);
            //    int c = int.Parse(Console.ReadLine());
            //    int n0 = int.Parse(Console.ReadLine());
            //    bool ans = true;
            //    for(int n = n0; n < 101; n++)
            //    {
            //        if(a1*n + a0 > c * n)
            //        {
            //            Console.WriteLine(0);
            //            ans = false;
            //            break;
            //        }
            //    }
            //    if (ans)
            //    {
            //        Console.WriteLine(1);
            //    }
            //}



            //ExecutionTime6_ans();
            //void ExecutionTime6_ans()
            //{
            //    string input = Console.ReadLine();
            //    long n = long.Parse(input);
            //    long cnt = 0;
            //    for (int i = 0; i < n - 2; i++)
            //    {
            //        cnt += (n - 2 - i) * (n - 1 - i) / 2;
            //    }
            //    Console.WriteLine(cnt);
            //    Console.WriteLine(3);
            //}

            
            /*
            ExecutionTime6();
            void ExecutionTime6()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (String.IsNullOrEmpty(input)) break;
                    long n = long.Parse(input);
                    long cnt = 0;

                    *//*for (int i = 0; i < n - 2; i++)
                    {
                        for (int j = i + 1; j < n - 1; j++)
                        {
                            for (int k = j + 1; k < n; k++)
                            {
                                cnt++;
                            }
                        }
                    }
                    Console.WriteLine("첫 for문 횟수 : " + (n-2));
                    Console.WriteLine("두번째 for문 횟수 : " + (n-2)*(n-1)/2);
                    //Console.WriteLine("세번째 for문 횟수 : " + cnt);
                    Console.WriteLine(cnt);
                    cnt = 0;*//*
                    for(int i = 0; i<n-2; i++)
                    {
                        cnt += (n - 2 -i) * (n - 1 -i) / 2;
                    }
                    Console.WriteLine(cnt);
                    Console.WriteLine();
                }

            }*/

            /*ExecutionTime5();
            void ExecutionTime5()
            {
                long n = long.Parse(Console.ReadLine());
                Console.WriteLine(n*n*n);
                Console.WriteLine(3);
            }*/


            /*
            ExecutionTime4();
            void ExecutionTime4()
            {
                long n = long.Parse(Console.ReadLine());
                long cnt = 0;
                cnt = n * (n - 1) / 2;
                Console.WriteLine(cnt);
                Console.WriteLine(2);
            }
            */
        }
    }
}
