using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonProblem
{
    internal class Multiplication2
    {
        /*static void Main(string[] args)
        {
            *//*// 내 풀이
            string read = Console.ReadLine();
            int a = int.Parse(read);
            string read2 = Console.ReadLine();
            //string[] temp = read2.Split();
            int b = int.Parse(read2);
            char[] temp = read2.ToCharArray();
            
            int b1 = (int)char.GetNumericValue(temp[2]);
            int b2 = (int)char.GetNumericValue(temp[1]);
            int b3 = (int)char.GetNumericValue(temp[0]);
            Console.WriteLine(a * b1);
            Console.WriteLine(a * b2);
            Console.WriteLine(a * b3);
            Console.WriteLine(a * b);*//*

            string Read = Console.ReadLine();
            string Read2 = Console.ReadLine();
            int tem = int.Parse(Read);
            //char[] c = null;
            //int[] num = new int[3]; // null로 생성하면 참조 불가. new로 만들어주기.
            List<int> num = new List<int>();
            for (int i = 0; i < Read2.Length; i++)
            {
                //c[i] = Read2[i];
                //num[i] = int.Parse(c[i].ToString());
                //num[i] = int.Parse(Read2[2 - i].ToString());
                num.Add(int.Parse(Read2[2 - i].ToString()));
                Console.WriteLine(tem * num[i]);
            }
            Console.WriteLine(tem * int.Parse(Read2));

            void Other()
            {
                // 다른사람 풀이
                string a1 = Console.ReadLine();
                string a2 = Console.ReadLine();
                char[] a3 = a2.ToCharArray();

                int num1 = int.Parse(a1);
                int[] num2 = new int[a3.Length];
                for (int i = 0; i < a3.Length; i++)
                {
                    num2[i] = int.Parse(a3[i].ToString());
                }
                Console.WriteLine(num1 * num2[2]);
                Console.WriteLine(num1 * num2[1]);
                Console.WriteLine(num1 * num2[0]);
                Console.WriteLine(num1 * num2[2] + num1 * num2[1]*10 + num1 * num2[0] * 100);

            }

            *//*void More()
            {
                string Read = Console.ReadLine();
                string Read2 = Console.ReadLine();
                int tem = int.Parse(Read);
                //char[] c = null;
                int[] num = null;
                for (int i = 0; i < Read.Length; i++)
                {
                    //c[i] = Read2[i];
                    //num[i] = int.Parse(c[i].ToString());
                    num[i] = int.Parse(Read2[2 - i].ToString());
                    Console.WriteLine(tem * num[i]);
                }
                Console.WriteLine(tem * int.Parse(Read2));

            }*//*
        }*/

    }
}
