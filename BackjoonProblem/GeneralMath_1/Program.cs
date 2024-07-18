using System;
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
