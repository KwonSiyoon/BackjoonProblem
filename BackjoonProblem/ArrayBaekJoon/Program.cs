using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBaekJoon
{
    internal class Program
    {
        static void Main(string[] args)
        {



            CompressCoordinate();
            void CompressCoordinate()
            {
                using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
                {
                    StringBuilder sb = new StringBuilder();

                    int n = int.Parse(Console.ReadLine());

                    string[] input = Console.ReadLine().Split();
                    int[] nums = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        nums[i] = int.Parse(input[i]);
                    }
                    int[] list = nums.Distinct().ToArray();
                    Array.Sort(list);
                    Dictionary<int, int> dic = new Dictionary<int, int>();
                    int index = 0;
                    foreach(var c in list)
                    {
                        dic[c] = index;
                        index++;
                    }
                    for(int i = 0; i<n; i++)
                    {
                        sb.Append(dic[nums[i]] + " ");
                    }
                    //for (int i = 0; i < n; i++)
                    //{
                    //    for (int j = 0; j < list.Length; j++)
                    //    {
                    //        if (list[j] == nums[i])
                    //        {
                    //            sb.Append(j + " ");
                    //        }
                    //    }
                    //}
                    print.WriteLine(sb.ToString().TrimEnd());
                }
            }





            #region 푼 문제






            //AgeArray();
            //void AgeArray() // 10814
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            //        int[] ages = new int[201];
            //        for(int i = 0; i < n; i++)
            //        {
            //            string[] temp = Console.ReadLine().Split();
            //            int age = int.Parse(temp[0]);
            //            if (ages[age] == 0) ages[age]++;
            //            list.Add(Tuple.Create(age, temp[1]));
            //        }
            //        for(int i = 0; i < ages.Length; i++)
            //        {
            //            if (ages[i] > 0)
            //            {
            //                for(int j = 0; j < list.Count; j++)
            //                {
            //                    if (i == list[j].Item1)
            //                    {
            //                        print.WriteLine($"{list[j].Item1} {list[j].Item2}");
            //                    }
            //                }
            //                for(int j = list.Count-1; j >= 0; j--)
            //                {
            //                    if(i == list[j].Item1)
            //                    {
            //                        list.RemoveAt(j);
            //                    }
            //                }
            //                if (list.Count == 0)
            //                {
            //                    break;
            //                }
            //            }
            //        }
            //    }

            //}

            //ArrayWord_Ans();
            //void ArrayWord_Ans() // Linq 사용 풀이 예제
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());
            //        List<string> list = new List<string>();
            //        for (int i = 0; i < n; i++)
            //        {
            //            list.Add(Console.ReadLine());
            //        }
            //        list = list.Distinct().ToList(); // 중복값 없애서 반환하는 Distinct()함수

            //        // Linq 예제
            //        var output = from word in list
            //                     orderby word.Length, word
            //                     select word;

            //        foreach (var c in output)
            //        {
            //            print.WriteLine(c);
            //        }
            //    }
            //}


            //ArrayWord();
            //void ArrayWord() // 시간초과 나옴
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());
            //        List<string> list = new List<string>();
            //        for(int i = 0; i < n; i++)
            //        {
            //            bool reduple = false;
            //            string temp = Console.ReadLine();
            //            for(int j = 0; j < list.Count; j++)
            //            {
            //                if (list[j] == temp)
            //                {
            //                    reduple = true;
            //                    break;
            //                }
            //            }
            //            if (reduple) continue;
            //            list.Add(temp);
            //        }
            //        for(int i = 0; i < list.Count-1; i++)
            //        {
            //            for(int j = i; j < list.Count; j++)
            //            {
            //                if (list[i].Length == list[j].Length)
            //                {
            //                    for(int k = 0; k < list[i].Length; k++)
            //                    {
            //                        if (list[i][k] < list[j][k]) break;
            //                        if (list[i][k] > list[j][k])
            //                        {
            //                            string a = list[i];
            //                            list[i] = list[j];
            //                            list[j] = a;
            //                            break;
            //                        }
            //                    }
            //                }
            //                if (list[i].Length > list[j].Length)
            //                {
            //                    string a = list[i];
            //                    list[i] = list[j];
            //                    list[j] = a;
            //                }
            //            }
            //        }
            //        foreach(var c in list)
            //        {
            //            print.WriteLine(c);
            //        }
            //    }
            //}

            //ArrayCoordinate_2();
            //void ArrayCoordinate_2() // 11651
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        var points = new Tuple<int, int>[n];
            //        for (int i = 0; i < n; i++)
            //        {
            //            var input = Console.ReadLine().Split();
            //            points[i] = Tuple.Create(int.Parse(input[1]), int.Parse(input[0]));
            //        }

            //        Array.Sort(points);

            //        //var sb = new StringBuilder();

            //        foreach (var point in points)
            //        {
            //            print.WriteLine($"{point.Item2} {point.Item1}");
            //        }
            //    }
            //}

            //ArrayCoordinate();
            //void ArrayCoordinate() // 11650 // 시간초과 오지게 남. // Tuple 사용 예제
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        var points = new Tuple<int, int>[n];
            //        for(int i = 0; i < n; i++)
            //        {
            //            var input = Console.ReadLine().Split();
            //            points[i] = Tuple.Create(int.Parse(input[0]), int.Parse(input[1]));
            //        }

            //        Array.Sort(points);

            //        //var sb = new StringBuilder();

            //        foreach(var point in points)
            //        {
            //            print.WriteLine($"{point.Item1} {point.Item2}");
            //        }
            //    }
            //}

            //SortInside();
            //void SortInside()
            //{
            //    string input = Console.ReadLine();
            //    int[] nums = new int[10];
            //    for(int i = 0; i < input.Length; i++)
            //    {
            //        nums[int.Parse(input[i].ToString())]++;
            //    }
            //    for(int i = 9; i>=0; i--)
            //    {
            //        if (nums[i] == 0) continue;
            //        while (nums[i] > 0)
            //        {
            //            Console.Write(i);
            //            nums[i]--;
            //        }
            //    }
            //}

            //NumArray_3();
            //void NumArray_3()
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());
            //        int[] arr = new int[10001];
            //        int max = 0;
            //        for(int i = 0; i < n; i++)
            //        {
            //            int a = int.Parse(Console.ReadLine());
            //            if (max < a) max = a;
            //            arr[a]++;
            //        }
            //        for(int i = 0; i <= max; i++)
            //        {
            //            if (arr[i] == 0) continue;
            //            while (arr[i] >0)
            //            {
            //                arr[i]--;
            //                print.WriteLine(i);
            //            }
            //        }
            //    } 
            //}

            //NumArray_2();
            //void NumArray_2() // 2751
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] nums = new int[n];
            //    for(int i = 0; i < n; i++)
            //    {
            //        nums[i] = int.Parse(Console.ReadLine());
            //    }
            //    Array.Sort(nums);
            //    //for(int i = 0; i < n-1; i++)
            //    //{
            //    //    for(int j = i; j < n;)
            //    //    {
            //    //        if (nums[i] > nums[j])
            //    //        {
            //    //            int a = nums[i];
            //    //            nums[i] = nums[j];
            //    //            nums[j] = a;
            //    //        }
            //    //    }
            //    //}

            //    string res = string.Join("\n", nums); // 일일이 cw로 하면 시간초과 됨.
            //    Console.WriteLine(res);

            //}



            //CutLine();
            //void CutLine() // 25305
            //{
            //    string[] input = Console.ReadLine().Split();
            //    int n = int.Parse(input[0]);
            //    int k = int.Parse(input[1]);
            //    input = Console.ReadLine().Split();
            //    int[] nums = new int[n];
            //    for(int i = 0; i < n; i++)
            //    {
            //        nums[i] = int.Parse(input[i]);
            //    }
            //    Array.Sort(nums);

            //    Console.WriteLine(nums[n-k]);

            //}

            //RepresentativeValue();
            //void RepresentativeValue() 2587
            //{
            //    int[] list = new int[5];
            //    for(int i =0; i<5; i++)
            //    {
            //        list[i] = int.Parse(Console.ReadLine());
            //    }
            //    for(int i = 0; i<4; i++)
            //    {
            //        for(int j = i; j<5; j++)
            //        {
            //            if (list[i] < list[j])
            //            {
            //                int a = list[i];
            //                list[i] = list[j];
            //                list[j] = a;
            //            }
            //        }
            //    }
            //    int sum = 0;
            //    foreach(var c in list)
            //    {
            //        sum += c;
            //    }
            //    Console.WriteLine(sum / 5);
            //    Console.WriteLine(list[2]);
            //}

            #endregion
        }
    }
}
