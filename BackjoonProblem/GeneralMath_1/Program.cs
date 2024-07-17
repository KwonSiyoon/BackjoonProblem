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

            BaseConversion();
            void BaseConversion()
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


        }
    }
}
