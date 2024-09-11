using System;
using System.CodeDom.Compiler;
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

            using(var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                int t = int.Parse(Console.ReadLine());

                for(int i = 0; i < t; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    List<int> list = new List<int>();
                    int ans = 1;
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    if (a == b) 
                    {
                        print.WriteLine(a);
                        continue;
                    }
                    if(a>b && a % b == 0)
                    {
                        print.WriteLine(a);
                        continue;
                    }
                    else if(a<b && b %a==0)
                    {
                        print.WriteLine(b);
                        continue;
                    }
                    
                    int max = b;
                    if (a > b) max = a;
                    for(int k = 2; k <max; k++)
                    {
                        while(a%k == 0 && b%k == 0)
                        {
                            a /= k;
                            b /= k;
                            list.Add(k);
                        }
                        if (k > a || k > b) break;
                    }
                    foreach(var c in list)
                    {
                        ans *= c;
                    }
                    print.WriteLine(ans * a * b);
                }
            }











            #region 푼 문제







            //DifferentStringCnt();
            //void DifferentStringCnt() // 11478
            //{
            //    using(var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        string input = Console.ReadLine();
            //        Dictionary<string, string> dic = new Dictionary<string, string>();
            //        int n = input.Length;
            //        int cnt = 0;
            //        for(n= input.Length; n > 0; n--)
            //        {
            //            for (int i = 0; i <= input.Length - n; i++)
            //            {
            //                if (n == 0) break;
            //                string temp = input.Substring(i, n);
            //                if (dic.ContainsKey(temp))
            //                {
            //                    continue;
            //                }
            //                else
            //                {
            //                    dic.Add(temp, temp);
            //                    cnt++;
            //                }
            //            }
            //        }

            //        print.WriteLine(cnt);
            //    }
            //}


            //SymmetryDifference();
            //void SymmetryDifference() // 1269
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        string[] input = Console.ReadLine().Split();
            //        int n = int.Parse(input[0]);
            //        int m = int.Parse(input[1]);
            //        input = Console.ReadLine().Split();
            //        int cnt = n;
            //        Dictionary<string, int> dic = new Dictionary<string, int>();
            //        for (int i = 0; i < n; i++)
            //        {
            //            dic.Add(input[i], 0);
            //        }
            //        input = Console.ReadLine().Split();
            //        for (int i = 0; i < m; i++)
            //        {
            //            if (dic.ContainsKey(input[i]))
            //            {
            //                cnt--;
            //            }
            //            else
            //            {
            //                cnt++;
            //            }
            //        }
            //        print.WriteLine(cnt);
            //    }
            //}


            //DeutBoJob();
            //void DeutBoJob() // 1764
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        string[] input = Console.ReadLine().Split();
            //        int n = int.Parse(input[0]);
            //        int m = int.Parse(input[1]);

            //        Dictionary<string, int> dic = new Dictionary<string, int>();
            //        for (int i = 0; i < n; i++)
            //        {
            //            dic.Add(Console.ReadLine(), 0);
            //        }
            //        List<string> list = new List<string>();
            //        for (int i = 0; i < m; i++)
            //        {
            //            string temp = Console.ReadLine();
            //            if (dic.ContainsKey(temp))
            //            {
            //                list.Add(temp);
            //            }
            //        }
            //        print.WriteLine(list.Count);
            //        list.Sort();
            //        for (int i = 0; i < list.Count; i++)
            //        {
            //            print.WriteLine(list[i]);
            //        }
            //    }
            //}




            //NumberCard2();
            //void NumberCard2() // 10816
            //{
            //    using(var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());
            //        Dictionary<string, int> dic = new Dictionary<string, int>();
            //        StringBuilder sb = new StringBuilder();
            //        string[] input = Console.ReadLine().Split();
            //        for (int i = 0; i<n; i++)
            //        {
            //            string temp = input[i];
            //            if (dic.TryGetValue(temp, out int cnt))
            //            {
            //                dic.Remove(temp);
            //                dic.Add(temp, ++cnt);
            //            }
            //            else
            //            {
            //                dic.Add(temp, 1);
            //            }
            //        }
            //        n = int.Parse(Console.ReadLine());
            //        input = Console.ReadLine().Split();
            //        for (int i = 0; i < n; i++)
            //        {
            //            if (dic.TryGetValue(input[i], out int cnt))
            //            {
            //                sb.Append(cnt + " ");
            //            }
            //            else
            //            {
            //                sb.Append(0 + " ");
            //            }
            //        }
            //        print.WriteLine(sb.ToString().TrimEnd());
            //    }
            //}





            //PocketMonDasom();
            //void PocketMonDasom() // 1620
            //{
            //    using(var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        string[] input = Console.ReadLine().Split();
            //        int n = int.Parse(input[0]);
            //        int m = int.Parse(input[1]);

            //        Dictionary<string, int> dic = new Dictionary<string, int>();
            //        List<string> list = new List<string>();
            //        int cnt = 1;
            //        for(int i = 0; i < n; i++)
            //        {
            //            string temp = Console.ReadLine();
            //            dic.Add(temp, cnt++);
            //            list.Add(temp);
            //        }
            //        for(int i = 0; i < m; i++)
            //        {
            //            string temp = Console.ReadLine();
            //            if(int.TryParse(temp, out int num))
            //            {
            //                print.WriteLine(list[num - 1]);
            //            }
            //            else
            //            {
            //                dic.TryGetValue(temp, out int value);
            //                print.WriteLine(value);
            //            }
            //        }
            //    }
            //}





            //PeopleInCompany();
            //void PeopleInCompany() // dictionary의 키를 list로 바꿔 정렬. 7785
            //{
            //    using(var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        Dictionary<string, string> dic = new Dictionary<string, string>();
            //        for(int i = 0; i <n; i++)
            //        {
            //            string[] input = Console.ReadLine().Split();
            //            if (dic.ContainsKey(input[0]))
            //            {
            //                dic.Remove(input[0]);
            //            }
            //            else
            //            {
            //                dic.Add(input[0], input[0]);
            //            }
            //        }
            //        List<string> list = dic.Keys.ToList();
            //        list.Sort();
            //        for(int i = list.Count-1; i>=0; i--)
            //        {
            //            print.WriteLine(list[i]);
            //        }
            //    }
            //}


            //StringSet();
            //void StringSet() // 14425
            //{
            //    using(var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        string[] input = Console.ReadLine().Split();
            //        int n = int.Parse(input[0]);
            //        int m = int.Parse(input[1]);
            //        Dictionary<string, int> pairs = new Dictionary<string, int>();
            //        int sum = 0;
            //        for (int i = 0; i < n; i++)
            //        {
            //            pairs.Add(Console.ReadLine(), 1);
            //        }
            //        for (int i = 0; i < m; i++)
            //        {
            //            if (pairs.ContainsKey(Console.ReadLine()))
            //            {
            //                sum++;
            //            }
            //        }

            //        print.WriteLine(sum);
            //    }
            //}

            //CompressCoordinate();
            //void CompressCoordinate() // 18870
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        StringBuilder sb = new StringBuilder();

            //        int n = int.Parse(Console.ReadLine());

            //        string[] input = Console.ReadLine().Split();
            //        int[] nums = new int[n];
            //        for (int i = 0; i < n; i++)
            //        {
            //            nums[i] = int.Parse(input[i]);
            //        }
            //        int[] list = nums.Distinct().ToArray();
            //        Array.Sort(list);
            //        Dictionary<int, int> dic = new Dictionary<int, int>();
            //        int index = 0;
            //        foreach(var c in list)
            //        {
            //            dic[c] = index;
            //            index++;
            //        }
            //        for(int i = 0; i<n; i++)
            //        {
            //            sb.Append(dic[nums[i]] + " ");
            //        }
            //        //for (int i = 0; i < n; i++)
            //        //{
            //        //    for (int j = 0; j < list.Length; j++)
            //        //    {
            //        //        if (list[j] == nums[i])
            //        //        {
            //        //            sb.Append(j + " ");
            //        //        }
            //        //    }
            //        //}
            //        print.WriteLine(sb.ToString().TrimEnd());
            //    }
            //}


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

            #region 힙정렬과 이진탐색 트리 구현
            //NumberCard();
            //void NumberCard()
            //{
            //    using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            //    {
            //        StringBuilder sb = new StringBuilder();

            //        int n = int.Parse(Console.ReadLine());
            //        string[] input = Console.ReadLine().Split();
            //        int[] temp = new int[n];
            //        int a = 0;
            //        foreach(var c in input)
            //        {
            //            temp[a] = int.Parse(c);
            //            a++;
            //        }

            //        HeapSort(temp);
            //        n = int.Parse(Console.ReadLine());
            //        input = Console.ReadLine().Split();
            //        int[] cards = new int[n];
            //        //a = 0;
            //        foreach(var c in input)
            //        {
            //            sb.Append(BinarySearch(temp, int.Parse(c)) + " ");
            //            //cards[a] = int.Parse(c);
            //            //a++;
            //        }

            //        print.WriteLine(sb.ToString().TrimEnd());

            //    }
            //}
            //void Swap(int[] array, int i, int j)
            //{
            //    int temp = array[i];
            //    array[i] = array[j];
            //    array[j] = temp;
            //}
            //void HeapSort(int[] array)
            //{
            //    int n = array.Length;
            //    for(int i = n/2 -1; i >= 0; i--)
            //    {
            //        Heapify(array, n, i);
            //    }
            //    for(int i = n -1; i>0; i--)
            //    {
            //        Swap(array, 0, i);
            //        Heapify(array, i, 0);
            //    }
            //}
            //void Heapify(int[] array, int n, int i)
            //{
            //    int largest = i; // 루트
            //    int left = 2 * i + 1; // 왼쪽 자식 노드
            //    int right = 2 * i + 2; // 오른쪽 자식 노드
            //    // 자식이 있다면 left가 length내에 있음.
            //    // 왼쪽 자식이 부모보다 크면 교체
            //    if(left<n && array[left] > array[largest])
            //    {
            //        largest = left;
            //    }
            //    if(right <n && array[right] > array[largest])
            //    {
            //        largest = right;
            //    }
            //    // 가장 큰 값이 루트가 아니면
            //    if(largest != i)
            //    {
            //        Swap(array, i, largest);
            //        Heapify(array, n, largest);
            //    }
            //}
            //int BinarySearch(int[] arr, int value)
            //{
            //    int left = 0;
            //    int right = arr.Length - 1;
            //    while(left <= right)
            //    {
            //        int mid = left + (right - left) / 2;

            //        if (arr[mid] == value)
            //        {
            //            return 1;
            //        }
            //        else if (arr[mid] < value)
            //        {
            //            left = mid + 1;
            //        }
            //        else // arr[mid] > value
            //        {
            //            right = mid - 1;
            //        }
            //    }
            //    return 0;
            //}
            #endregion
        }
    }
}
