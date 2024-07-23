﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMath_1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            FindFraction();
            void FindFraction()
            {
                int n = int.Parse(Console.ReadLine());
                int m = 0;
                while (n > 0)
                {
                    m++; // m 증가
                    n -= m; // n에서 m을 뻄
                }
                // 탈출하면 해당 분수는 m번째 줄에 있음.
                // n이 1일때 
                // 탈출하면 n==0, m==1
                // n이 2일때 탈출하면 n==-1, m==2
                // n이 4일때 n==-2 m==3
                // n이 5일때 n==-1 m==3
                // n이 9면 n==-1 m==4
                // n이 11이면 탈출 시 n == -4, m==5
                // 1/1
                // 1/2 2/1
                // 3/1 2/2 1/3
                // 1/4 2/3 3/2 4/1
                // 5/1 4/2 3/3 2/4 1/5
                if(m%2 == 0)
                {
                    Console.WriteLine($"{m+n}/{-n+1}");
                }
                else if(m%2 == 1)
                {
                    Console.WriteLine($"{-n+1}/{m+n}");
                }
            }








/*
            beehive();
            void beehive()
            {
                int n = int.Parse(Console.ReadLine());
                int ans = 1;
                n -= 1;
                int i = 0;
                while (n > 0)
                {
                    i++;
                    ans++;
                    n -= 6*i; 
                }
                Console.WriteLine(ans);
            }
*/

/*
            MoveToCenterAlgorithm();
            void MoveToCenterAlgorithm() // 2903
            {
                int n = int.Parse(Console.ReadLine());
                int a = (int)Math.Pow(2, n) + 1;
                Console.WriteLine(Math.Pow(a, 2));
            }
*/



/*
            LaundryPresident();
            void LaundryPresident()
            {
                int n = int.Parse(Console.ReadLine());
                int quarterCnt = 0; // 쿼터 Quarter 25센트
                int dimeCnt = 0; // 다임 Dime    10센트
                int nickelCnt = 0; // 니켈 Nickel  5센트
                int pennyCnt = 0; // 페니 Penny   1센트
                for (int i = 0; i < n; i++)
                {
                    int change = int.Parse(Console.ReadLine());
                    quarterCnt = change / 25;
                    change %= 25;
                    dimeCnt = change / 10;
                    change %= 10;
                    nickelCnt = change / 5;
                    change %= 5;
                    pennyCnt = change / 1;
                    Console.WriteLine($"{quarterCnt} {dimeCnt} {nickelCnt} {pennyCnt}");
                }
            }
*/

/*
            BaseConversion_2();
            void BaseConversion_2() // 11005
            {
                string[] input = Console.ReadLine().Split();
                int num = int.Parse(input[0]);
                int baseI = int.Parse(input[1]);
                List<char> list = new List<char>();
                int remain = 0;
                // 주어진 num을 baseI로 나눈 나머지를 구한다.
                // 나머지 값을 문자로 변환해서 list에 추가한다.
                // 주어진 num을 baseI로 나눈다
                while (num > 0)
                {
                    remain = num % baseI;
                    if(remain < 10)
                    {
                        remain += 48;
                        list.Add((char)remain);
                    }
                    else if(remain>=10)
                    {
                        remain += 55;
                        list.Add((char)remain);
                    }
                    num = num / baseI;
                }
                for(int i = list.Count-1; i >=0; i--)
                {
                    Console.Write(list[i]);
                }
            }
*/



/*
            BaseConversion();
            void BaseConversion() // 2745
            {
                // A~Z는 65 ~ 90
                // -55를 하면 10 ~ 35
                // 0~9는 문자열로 48~57
                // -48을 하면 0~9
                string[] input = Console.ReadLine().Split();
                string temp = input[0];
                int baseI = int.Parse(input[1]);
                int sum = 0;
                
                for(int i = 0; i < temp.Length; i++)
                {
                    int t = (int)temp[i];
                    if (t > 60) t -= 55;
                    else if (t < 60) t -= 48;
                    sum += t * (int)Math.Pow(baseI, temp.Length - 1 - i);
                }

                Console.WriteLine(sum);
            }
*/

        }
    }
}
