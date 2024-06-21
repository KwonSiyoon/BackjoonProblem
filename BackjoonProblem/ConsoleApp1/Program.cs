using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*AverageScore();
            void AverageScore()
            {
                List<float> list = new List<float>();
                int n = int.Parse(Console.ReadLine());
                string[] read = Console.ReadLine().Split();

                for(int i = 0; i < n; i++)
                {
                    list.Add(int.Parse(read[i]));
                }

                float maxScore = list.Max();
                float sum = 0;

                for(int i =0; i <n; i++)
                {
                    sum += list[i] / maxScore * 100; // 변경된 값을 sum에 다 더함
                }

                float makedAverageScore = sum / n; // 평균

                Console.WriteLine(makedAverageScore);
            }*/

            /*
                        void TurnOverBasket2() // 10811 인터넷에서 찾아본 모범답안
                        {
                            string[] nm = Console.ReadLine().Split();

                            int n = int.Parse(nm[0]);
                            int m = int.Parse(nm[1]);

                            int[] N = new int[n];

                            int i;
                            int temp;
                            for (i = 0; i < N.Length; i++)
                            {
                                N[i] = i + 1;
                            }
                            for (i = 0; i < m; i++)
                            {
                                string[] ab = Console.ReadLine().Split();
                                int a = int.Parse(ab[0]) - 1;
                                int b = int.Parse(ab[1]) - 1;

                                while (a < b)
                                {
                                    temp = N[a];
                                    N[a++] = N[b];
                                    N[b--] = temp;
                                }
                            }
                            for (i = 0; i < N.Length; i++)
                            {
                                Console.Write(N[i] + " ");
                            }
                        }
            */
            /*
                        TurnOverBasket();
                        void TurnOverBasket() // 10811
                        {
                            // 1~n번의 바구니가 존재
                            string[] read = Console.ReadLine().Split();
                            int n = int.Parse(read[0]);
                            int m = int.Parse(read[1]);

                            int[] basket = new int[n];
                            for(int i = 0; i < n; i++)
                            {
                                basket[i] = i + 1;
                            }

                            List<int> list = new List<int>();
                            // m번 실행
                            for(int i = 0; i < m; i++)
                            {
                                read = Console.ReadLine().Split();
                                int a = int.Parse(read[0]); // a번째 이므로 basket[a - 1]
                                int b = int.Parse(read[1]);


                                if(a == b)
                                {
                                    continue;
                                }
                                // a~b의 바구니를 역순으로 만듬
                                for (int j = a; j <= b; j++) // a 부터 b까지의 바구니를 뺌.
                                {
                                    list.Add(basket[j - 1]);
                                }
                                for(int j = 0; j <= b-a; j++ ) // b부터 a까지 다시 넣어줌
                                {
                                    basket[a-1 + j] = list[b-a-j];
                                }
                                list.Clear();
                            }

                            // 최종 바구니 순서 출력
                            foreach(var c in basket)
                            {
                                Console.Write(c + " ");
                            }
                        }
            */

            /*Test();
            void Test()
            {
                int n = 21;
                int[] group = new int[n];
                for(int i = 0; i < n; i++)
                {
                    group[i] = i + 1;
                }

                // 0번부터 끝까지.
                *//*for(int i = 0; i<group.Length/2; i++)
                {
                    int temp = group[i];
                    group[i] = group[group.Length - 1 - i];
                    group[group.Length - 1 - i] = temp;
                }*//*


                // 값을 다 빼서 다시 넣기 List 사용
                List<int> list = new List<int>();
                for(int i = 1; i< group.Length; i++)
                {
                    list.Add(group[group.Length - 1 -i]);
                }
                for(int i = 1; i<group.Length; i++)
                {
                    group[i] = list[i-1];
                }

                foreach (var c in group)
                {
                    Console.Write(c + " ");
                }
            }*/

            /*
                        Remainder();
                        void Remainder() // 3052 // 수학에서 몫 quotient , 나머지 remainder
                        {
                            // 수 10개를 입력받는다.
                            List<int> list = new List<int>();
                            for(int i = 0; i < 10; i++)
                            {
                                list.Add(int.Parse(Console.ReadLine()));
                            }

                            List<int> ans = new List<int>();
                            // 이를 42로 나눈 나머지를 구한다.
                            for(int i = 0; i < 10; i++)
                            {
                                int remainder = list[i] % 42;
                                bool redundant = false;
                                for(int j = 0; j < ans.Count; j++) // 같은 값이 있는지 검사
                                {
                                    if (ans[j] == remainder)
                                    {
                                        redundant = true;
                                        break;
                                    }
                                }
                                if (redundant == false) 
                                { 
                                    ans.Add(remainder); 
                                }
                            }
                            // 서로 다른 값이 몇 개 있는지 출력한다.
                            Console.WriteLine(ans.Count);

                        }
            */



            /*
                        DoNotReport();
                        void DoNotReport() // 5597
                        {
                            // 교실에 30명이 있고 학생별로 1~30번 출석번호 존재
                            // 특별과제 28명이 제출함
                            // 제출 안한 학생 2명의 출석번호 구함.

                            List<int> list = new List<int>();
                            for(int i = 1; i <= 30; i++)
                            {
                                list.Add(i);
                            }

                            for (int i = 0; i < 28; i++)
                            {
                                list.Remove(int.Parse(Console.ReadLine()));
                            }

                            foreach(int c in list)
                            {
                                Console.WriteLine(c);
                            }
                        }
            */

            /*
                        ChangeBalls();
                        void ChangeBalls() // 10813
                        {
                            string[] read = Console.ReadLine().Split();
                            int n = int.Parse(read[0]); // 바구니 개수
                            int m = int.Parse(read[1]); // 바꾸는 횟수

                            int[] basket = new int[n];
                            // 처음에는 바구니에 적혀있는 번호와 같은 번호의 공이 들어있음.
                            for(int i = 0; i < n; i++)
                            {
                                basket[i] = i + 1;
                            }

                            for(int i = 0; i < m; i++) // M번에 거쳐 공을 교환한다.
                            {
                                // 두 정수 값을 입력받아
                                read = Console.ReadLine().Split();

                                // 각 번호의 바구니에 있는 공을 교환한다.
                                int a = int.Parse(read[0]) -1; // 첫번호를 받아 배열번호로 변환
                                int b = int.Parse(read[1]) -1; // 두번째 번호를 받아 배열 번호로 변환

                                int temp = basket[a]; // 첫번째 바구니 공 뻄
                                basket[a] = basket[b]; // 첫번째 바구니에 두번째의 공을 넣음
                                basket[b] = temp; // 두번째 바구니에 첫번째 바구니 공을 넣음.
                            }

                            foreach(var c in basket)
                            {
                                Console.Write(c + " ");
                            }
                        }
            */
        }
    }
}
