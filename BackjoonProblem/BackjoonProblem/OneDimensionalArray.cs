using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonProblem
{
    internal class OneDimensionalArray
    {
        static void Main(string[] args)
        {







/*
            PutInBall();
            void PutInBall() // 10810
            {
                // 바구니 n개 공 넣는 행동을 m번 반복
                // 숫자 3개 a1 a2 b 받으면  a1부터 a2까지에 값이 b인 공을 넣음
                string[] read = Console.ReadLine().Split();
                int n = int.Parse(read[0]);
                int m = int.Parse(read[1]);
                
                int[] basket = new int[n]; // n개만큼의 바구니 배열 생성.

                int[] a1 = new int[m]; // m개의 줄만큼 받음
                int[] a2 = new int[m];
                int[] b = new int[m];
                for(int i = 0; i < m; i++)
                {
                    read = Console.ReadLine().Split(); // 숫자 3개 입력 받음
                    // 숫자3개를 a1, a2, b에 저장
                    a1[i] = int.Parse(read[0]);
                    a2[i] = int.Parse(read[1]);
                    b[i] = int.Parse(read[2]);

                    for(int j = a1[i]-1; j <= a2[i]-1; j++) // basket[a1-1] ~ basket[a2-1]까지 b값인 공넣기
                    {
                        basket[j] = b[i];
                    }
                }
                foreach(var c in basket)
                {
                    Console.Write(c + " ");
                }
            }
            PutInBall2();
            void PutInBall2() // 10810
            {
                // 바구니 n개 공 넣는 행동을 m번 반복
                // 숫자 3개 a1 a2 b 받으면  a1부터 a2까지에 값이 b인 공을 넣음
                string[] read = Console.ReadLine().Split();
                int n = int.Parse(read[0]);
                int m = int.Parse(read[1]);

                int[] basket = new int[n]; // n개만큼의 바구니 배열 생성.
                for (int i = 0; i < m; i++)
                {
                    read = Console.ReadLine().Split(); // 숫자 3개 입력 받음
                    // 숫자3개를 a1, a2, b에 저장
                    int a1 = int.Parse(read[0]);
                    int a2 = int.Parse(read[1]);
                    int b = int.Parse(read[2]);

                    for (int j = a1-1; j <= a2-1; j++) // basket[a1-1] ~ basket[a2-1]까지 b값인 공넣기
                    {
                        basket[j] = b;
                    }
                }
                foreach (var c in basket)
                {
                    Console.Write(c + " ");
                }
            }
*/


            /*
                        Max();
                        void Max()
                        {
                            int[] list = new int[9];
                            for(int i = 0; i < 9; i++)
                            {
                                list[i] = int.Parse(Console.ReadLine()); // 숫자를 배열에 저장
                            }
                            int num = list[0];
                            int order = 1; // 첫번째 숫자가 큰 경우를 위해 1로 초기화.
                            for(int i = 0; i < 8; i++) // 최대값의 값과 몇번째인지 검사 및 저장 
                            {
                                if (num < list[i + 1]) // num과 계속 비교하면서 크면 큰값을 대입하여 비교.
                                {
                                    num = list[i + 1];
                                    order = (i + 1) + 1; // 몇번째인지는 배열에 +1을 해야함
                                }
                            }
                            Console.WriteLine(num);
                            Console.WriteLine(order);
                        }
            */

            /*
                        MaxMin();
                        void MaxMin() // 10818
                        {
                            int n = int.Parse(Console.ReadLine());
                            string[] read = Console.ReadLine().Split();
                            int[] arr = new int[n];
                            for(int i = 0; i < n; i++)
                            {
                                arr[i] = int.Parse(read[i]);
                            }
                            int max = arr[0];
                            int min = arr[0];
                            for(int i = 0; i < n; i++)
                            {
                                if (max < arr[i])
                                {
                                    max = arr[i];
                                }
                                if (min > arr[i])
                                {
                                    min = arr[i];
                                }
                            }
                            Console.WriteLine(min + " " + max);
                        }
            */



            /*
                        SmallerNumber();
                        void SmallerNumber() // 10871
                        {
                            string[] read = Console.ReadLine().Split();
                            int N = int.Parse(read[0]);
                            int X = int.Parse(read[1]);
                            read = Console.ReadLine().Split();
                            List<int> list = new List<int>();
                            for(int i = 0; i < N; i++) 
                            {
                                if (int.Parse(read[i]) < X) // 숫자들을 X와 비교
                                {
                                    list.Add(int.Parse(read[i])); // list에 작은 숫자 저장
                                }
                            }
                            // 순서대로 출력
                            // 사이에 공백을 넣어서 출력
                            for(int i = 0; i < list.Count() - 1; i++) // 마지막 숫자 전까지만 출력
                            {
                                Console.Write(list[i] + " "); // 숫자 출력 + 공백 출력
                                //Console.Write(" "); //공백 출력
                            }
                            Console.Write(list[list.Count()-1]); // 마지막 숫자만 출력
                        }
            */
            /*Count();
            void Count() // 10807
            {
                // 첫째 줄에 입력으로 주어진 N개의 정수 중에 v가 몇개인지 출력
                int N = int.Parse(Console.ReadLine()); // 3. N의 값을 저장.

                // 2. N개의 정수를 저장.
                // 받은 숫자들을 string에서 int로 형변환
                // 형변환한 값들을 배열로 저장
                string[] read = Console.ReadLine().Split();
                int[] temp = new int[N];
                for(int i = 0; i < N; i++)
                {
                    temp[i] = int.Parse(read[i]);
                }
                // 1. v가 몇인지 저장.
                int v = int.Parse(Console.ReadLine());

                int count = 0;
                
                for(int i = 0; i < N; i++) 
                {
                    if (temp[i] == v) // 4. 주어진 정수들 중 v와 같은 값인지를 검사
                    {
                        count++; // 5. 같은 값인 경우를 count(몇개인지 저장)
                    }
                }
                // 6. 몇개인지 출력
                Console.WriteLine(count);
            }*/
        }
    }
}
