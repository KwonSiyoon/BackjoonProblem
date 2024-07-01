using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBaekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {




            AsIsPrint();
            void AsIsPrint() // 11718
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    Console.WriteLine(input);
                    if(String.IsNullOrEmpty(input))
                    //if(input == null)
                    {
                        break;
                    }
                }
                
            }





/*
            Dial();
            void Dial()
            {
                int ans = 0;
                //대문자 아스키코드 65~90
                foreach(char c in Console.ReadLine())
                {
                    if (c < 68) //ABC
                    {
                        ans += 2;
                    }
                    else if (c < 71) //DEF
                    {
                        ans += 3;
                    }
                    else if (c < 74) //GHI
                    {
                        ans += 4;
                    }
                    else if (c < 77) //JKL
                    {
                        ans += 5;
                    }
                    else if (c < 80) //MNO
                    {
                        ans += 6;
                    }
                    else if (c < 84) //PQRS
                    {
                        ans += 7;
                    }
                    else if (c < 87) //TUV
                    {
                        ans += 8;
                    }
                    else //WXYZ
                    {
                        ans += 9;
                    }
                    ans += 1;
                }
                Console.WriteLine(ans);
            }
*/

           /*
            Sangsu();
            void Sangsu() // 2908
            {
                string[] input = Console.ReadLine().Split();
                string num1 = input[0];
                string num2 = input[1];

                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                for(int i = 0; i<3; i++)
                {
                    sb1.Append(num1[2 - i]);
                    sb2.Append(num2[2 - i]);
                }
                int reNum1 = int.Parse(sb1.ToString());
                int reNum2 = int.Parse(sb2.ToString());
                if(reNum1 > reNum2)
                {
                    Console.WriteLine(reNum1);
                }
                else
                {
                    Console.WriteLine(reNum2);
                }

            }
*/


            /*CountWord();
            void CountWord() // 1152
            {
                string read = Console.ReadLine().Trim();
                string[] input = read.Split(); // 공백이 여러개 이어지면 공백을 저장함. 주의.
                int ans = input.Length;
                foreach(var c in input)
                {
                    if(c == "")
                    {
                        ans--;
                    }
                }
                Console.WriteLine(ans); 
            }
*/

/*
            Iterate();
            void Iterate() // 2675
            {
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split(); // 숫자 + 공백 + 문자열 을 받음
                    int m = int.Parse(input[0]); // 숫자를 m에 저장
                    string temp = input[1]; // 문자열을 temp에 저장
                    for(int j = 0; j < temp.Length; j++) // 첫번째 문자부터
                    {
                        for(int k = 0; k < m; k++) // m번 반복
                        {
                            Console.Write(temp[j]); // 문자 출력
                        }
                    }
                    Console.WriteLine(); // 다음줄로
                }
            }
*/

/*
            FindAlphabet();
            void FindAlphabet() // 10809
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 26; j++)
                {
                    bool contain = true; // 포함되어있나 확인. 포함이면 true
                    char c = (char)(97 + j); // a 부터 순서대로
                    for (int i = 0; i < input.Length; i++) // 첫 문자부터 검사
                    {
                        if(c == input[i]) // 문자가 같다면
                        {
                            // 몇번째에 있는지 출력. 처음은 0번째
                            Console.Write(i + " ");
                            contain = true;
                            break; // 바로 나가기
                        }
                        else
                        {
                            contain = false;
                        }
                    }
                    // 어떤 알파벳이 포함되어 있지 않다면
                    if (!contain)
                    {
                        Console.Write(-1 + " ");
                    }
                }
            }
*/
/*
            SumOfNumbers();
            void SumOfNumbers() // 11720
            {
                int a = int.Parse(Console.ReadLine());
                string nums = Console.ReadLine();
                int sum = 0;
                for (int i = 0; i < a; i++)
                {
                    int num = Convert.ToInt32(nums[i]) - Convert.ToInt32('0');
                    sum += num;
                }
                Console.WriteLine(sum);
            }
*/

/*
            ASCII();
            void ASCII() // 11654
            {
                Console.WriteLine((int)Console.ReadLine()[0]);
            }
*/

/*
            String();
            void String() // 9086
            {
                int a = int.Parse(Console.ReadLine());
                for(int i = 0; i < a; i++)
                {
                    string input = Console.ReadLine();
                    Console.WriteLine(input[0] +""+ input[input.Length-1]);
                }
            }
*/

/*
            StringLength();
            void StringLength() // 2743
            {
                string input = Console.ReadLine();
                Console.WriteLine(input.Length);
            }
*/


/*
            CharAndString();
            void CharAndString() // 27866
            {
                string read = Console.ReadLine();
                List<char> list = new List<char>();
                foreach(char a in read)
                {
                    list.Add(a);
                }
                Console.WriteLine(list[int.Parse(Console.ReadLine())-1]);
            }
            CharAndString2();
            void CharAndString2()
            {
                string input = Console.ReadLine();
                Console.WriteLine(input[int.Parse(Console.ReadLine())-1]);
            }
*/
        }
    }
}
