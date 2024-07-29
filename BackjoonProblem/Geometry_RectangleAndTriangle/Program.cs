using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_RectangleAndTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*ThreeSticks();
            void ThreeSticks()
            {
                string[] input = Console.ReadLine().Split();
                int[] nums = new int[input.Length];
                for(int i = 0; i < input.Length; i++)
                {
                    nums[i] = int.Parse(input[i]);
                }
                int sum = nums[0] + nums[1] + nums[2];
                int mid = sum - nums.Min() - nums.Max();
                
                if(sum - nums.Max() <= nums.Max())
                {
                    Console.WriteLine($"{(mid + nums.Min())*2 -1}");
                }
                else
                {
                    Console.WriteLine(sum);
                }
            }*/

            /*TriangleAndThreeSides();
            void TriangleAndThreeSides()
            {
                while (true)
                {
                    string[] input = Console.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    int c = int.Parse(input[2]);
                    int[] nums = new int[input.Length];
                    for(int i = 0; i < input.Length; i++)
                    {
                        nums[i] = int.Parse(input[i]);
                    }
                    int sum = a+b+c;
                    
                    if (a == 0) break;
                    if(sum - nums.Max() <= nums.Max())
                    {
                        Console.WriteLine("Invalid");
                        continue;
                    }

                    if(a==b && b == c)
                    {
                        Console.WriteLine("Equilateral");
                    }
                    else if(a==b || b==c || c == a)
                    {
                        Console.WriteLine("Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Scalene");
                    }
                }
            }*/


/*
            RememberTriangle();
            void RememberTriangle()
            {
                int[] angles = new int[3];
                for(int i = 0; i < angles.Length; i++)
                {
                    angles[i] = int.Parse(Console.ReadLine());
                }
                int sum = 0;
                foreach(var c in angles)
                {
                    sum += c;
                }
                if(sum != 180)
                {
                    Console.WriteLine("Error");
                    return;
                }
                if (angles[0] == angles[1] && angles[1] == angles[2])
                {
                    Console.WriteLine("Equilateral");
                }
                else if (angles[0] == angles[1] || angles[1] == angles[2] || angles[0] == angles[2])
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }

            }*/


            /*Ground();
            void Ground()
            {
                int n = int.Parse(Console.ReadLine());
                if (n <= 1) 
                {
                    Console.WriteLine(0);
                    return;
                }
                int[] x = new int[n];
                int[] y = new int[n];
                for(int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    x[i] = int.Parse(input[0]);
                    y[i] = int.Parse(input[1]);
                }

                Console.WriteLine((x.Max() - x.Min())*(y.Max()-y.Min()));
            }*/


            /*MathIsAthletic();
            void MathIsAthletic()
            {
                Console.WriteLine(4*long.Parse(Console.ReadLine()));
            }*/

            /*FourthPoint();
            void FourthPoint()
            {
                int[] xs = new int[3];
                int[] ys = new int[3];
                for(int i =0; i < 3; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    xs[i] = int.Parse(input[0]);
                    ys[i] = int.Parse(input[1]);
                }
                int cnt = 0;
                int x = 0;
                int y = 0;
                foreach(var c in xs)
                {
                    if(c == xs.Min())
                    {
                        cnt++;
                    }
                }
                if(cnt == 2)
                {
                    x = xs.Max();
                }
                else if(cnt == 1)
                {
                    x = xs.Min();
                }
                cnt = 0;
                foreach(var c in ys)
                {
                    if(c == ys.Min())
                    {
                        cnt++;
                    }
                }
                if(cnt == 2)
                {
                    y = ys.Max();
                }
                else if(cnt == 1)
                {
                    y = ys.Min();
                }
                Console.WriteLine($"{x} {y}");
            }*/

/*
            EscapeFromRectangle();
            void EscapeFromRectangle()
            {
                string[] input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int w = int.Parse(input[2]);
                int h = int.Parse(input[3]);
                int[] ans = new int[4];
                ans[0] = w - x;
                ans[1] = h - y;
                ans[2] = x;
                ans[3] = y;
                Console.WriteLine(ans.Min());
            }*/

            /*Rectangle();
            void Rectangle()
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }*/
        }
    }
}
