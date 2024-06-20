using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonProblem
{
    internal class For
    {
        /*
        static void Main(string[] args)
        {


*//*
            // 틱 하나는 100나노초 또는 1/1000만 초를 나타낸다.
            // 밀리초 안에 10000개의 틱과 초당 1000만개의 틱이 있다.
            // 시간을 이용한 반복문(while) 탈출 예시
            long start = DateTime.Now.Ticks;
            long count = 0;
            while(start + 10000000 > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복했습니다.");
*/



            /*
                        PlusAB4();
                        void PlusAB4() // 10951
                        {
                            while (true)
                            {
                                string input = Console.ReadLine();
                                if (input == null)
                                {
                                    break;
                                }
                                string[] temp = input.Split();
                                int a = int.Parse(temp[0]);
                                int b = int.Parse(temp[1]);
                                Console.WriteLine(a + b);
                            }
                        }
            */


            /*
                        PlusAB5();
                        void PlusAB5() // 10952
                        {
                            while (true)
                            {
                                string[] read = Console.ReadLine().Split();
                                int a = int.Parse(read[0]);
                                int b = int.Parse(read[1]);
                                if(a==0 || b == 0)
                                {
                                    break;
                                }
                                Console.WriteLine(a+b);
                            }
                        }
            */
            /*
                        MakeStar2();
                        void MakeStar2() // 2439번
                        {
                            int n = int.Parse(Console.ReadLine());

                            // int i = 0 으로 시작할 때
                            for (int i = 0; i < n; i++)
                            {
                                for(int j = 1; j < n-i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }

                            // int i = 1 로 시작할 때
                            for(int i = 1; i <= n; i++)
                            {
                                for(int j = 1; j <= n - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for(int j = 1; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                        }
            */

            /*
                        MakeStar();
                        void MakeStar()
                        {
                            int n = int.Parse(Console.ReadLine());
                            for(int i = 0; i < n; i++)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                        }
            */

            /*
                        PlusAB2();
                        void PlusAB2() // 11022
                        {
                            int n = int.Parse(Console.ReadLine());
                            for(int i = 0; i < n; i++)
                            {
                                string[] read = Console.ReadLine().Split();
                                int a = int.Parse(read[0]);
                                int b = int.Parse(read[1]);
                                Console.WriteLine($"Case #{i+1}: {a} + {b} = {a+b}");
                            }
                        }
                        PlusAB();
                        void PlusAB() // 11021
                        {
                            int n = int.Parse(Console.ReadLine());
                            for(int i = 0; i < n; i++)
                            {
                                string[] read = Console.ReadLine().Split();
                                Console.WriteLine($"Case #{i+1}: {int.Parse(read[0]) + int.Parse(read[1])}");
                            }
                        }
            */
            /*
                        QuickPlus();
                        void QuickPlus()
                        {
                            int n = int.Parse(Console.ReadLine());
                            for(int i = 0; i < n; i++)
                            {
                                string[] read = Console.ReadLine().Split();
                                Console.WriteLine(int.Parse(read[0]) + int.Parse(read[1]));
                            }
                        }
            */
            /*
                        Longlong();
                        void Longlong()
                        {
                            int n = int.Parse(Console.ReadLine());
                            for(int i = 0; i < n/4; i++)
                            {
                                Console.Write("long ");
                            }
                            Console.Write("int");
                        }
            */
            /*
                        Receipt();
                        void Receipt()
                        {
                            int X = int.Parse(Console.ReadLine());
                            int N = int.Parse(Console.ReadLine());
                            int[] price = new int[N];
                            int[] count = new int[N];
                            int total = 0;
                            for(int i = 0; i < N; i++)
                            {
                                string[] read = Console.ReadLine().Split();
                                price[i] = int.Parse(read[0]);
                                count[i] = int.Parse(read[1]);
                                total += (count[i] * price[i]);
                            }
                            if(total == X)
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No");
                            }
                        }
                        Receipt2();
                        void Receipt2()
                        {
                            int X = int.Parse(Console.ReadLine());
                            int N = int.Parse(Console.ReadLine());

                            int total = 0;
                            for (int i = 0; i < N; i++)
                            {
                                string[] read = Console.ReadLine().Split();
                                total += (int.Parse(read[1]) * int.Parse(read[0]));
                            }
                            if (total == X)
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No");
                            }
                        }
            */

            /*
                        Plus();
                        void Plus()
                        {
                            int n = int.Parse(Console.ReadLine());
                            int ans = 0;
                            for(int i = 1; i <= n; i++)
                            {
                                ans += i;
                            }
                            Console.WriteLine(ans);
                        }
            */


            /*
                        AB3();
                        void AB3()
                        {
                            int n = int.Parse(Console.ReadLine());
                            int[] ans = new int[n];
                            for(int i = 0; i < n; i++)
                            {
                                string[] read = Console.ReadLine().Split();
                                int num1 = int.Parse(read[0]);
                                int num2 = int.Parse(read[1]);
                                ans[i] = num1 + num2;
                                // Console.WriteLine(num1 + num2);
                            }
                            for(int i = 0; i < n; i++)
                            {
                                Console.WriteLine(ans[i]);
                            }
                        }
            *//*
        }
*/
    }
}
