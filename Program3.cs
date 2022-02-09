using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_conditions
{
    class Program  
    {    
        public static void N1()
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            string s = Console.ReadLine();
            string[] s_arr = s.Split();

            int dif = 0;
            int[] used = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s_arr[i]);

                bool found = false;

                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == used[j])
                        found = true;
                }

                if (!found)
                {
                    dif++;
                    used[i] = arr[i];
                }
            }

            Console.WriteLine(dif);
        }
        public static void N2()
        {
            int n = Int32.Parse(Console.ReadLine());

            SortedSet<int> set = new SortedSet<int>();

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                if (s_arr[0] == "ADD")
                    set.Add(int.Parse(s_arr[1]));
                else if (s_arr[0] == "PRESENT")
                {
                    if (set.Contains(int.Parse(s_arr[1])))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
                else if (s_arr[0] == "COUNT")
                {
                    Console.WriteLine(set.Count);
                }
            }
        }
        public static void N3()
        {
            List<int> list1 = new List<int>(), list2 = new List<int>();

            string s = Console.ReadLine();
            string[] s_arr1 = s.Split();

            for (int i = 0; i < s_arr1.Length; i++)
            {
                list1.Add(int.Parse(s_arr1[i]));
            }

            s = Console.ReadLine();
            string[] s_arr2 = s.Split();

            for (int i = 0; i < s_arr2.Length; i++)
            {
                list2.Add(int.Parse(s_arr2[i]));
            }

            int equal = 0;
            int[] equals = new int[s_arr1.Length];

            for (int i = 0; i < s_arr1.Length; i++)
            {
                for (int j = 0; j < s_arr2.Length; j++)
                {
                    if (equals.Contains(list1[i]))
                        continue;
                    if (list1[i] == list2[j])
                    {
                        equal++;
                        equals[i] = list1[i];
                    }
                }
            }

            Console.WriteLine(equal);
        }
        public static void N4()
        {
            List<int> list1 = new List<int>(), list2 = new List<int>();

            string s = Console.ReadLine();
            string[] s_arr1 = s.Split();

            for (int i = 0; i < s_arr1.Length; i++)
            {
                list1.Add(int.Parse(s_arr1[i]));
            }

            s = Console.ReadLine();
            string[] s_arr2 = s.Split();

            for (int i = 0; i < s_arr2.Length; i++)
            {
                list2.Add(int.Parse(s_arr2[i]));
            }

            int[] equals = new int[s_arr1.Length];

            for (int i = 0; i < s_arr1.Length; i++)
            {
                for (int j = 0; j < s_arr2.Length; j++)
                {
                    if (equals.Contains(list1[i]))
                        continue;
                    if (list1[i] == list2[j])
                    {
                        equals[i] = list1[i];
                    }
                }
            }

            Array.Sort(equals);

            for (int i = 0; i < equals.Length; i++)
                Console.Write(equals[i] + " ");
        }
        public static void N5()
        {
            SortedSet<string> set = new SortedSet<string>();

            string s = Console.ReadLine();
            string[] s_arr = s.Split();

            for (int i = 0; i < s_arr.Length; i++)
            {
                if (set.Contains(s_arr[i]))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
                set.Add(s_arr[i]);
            }
        }
        public static void N6()
        {
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            if ((a + b) == c)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N7()
        {
            double x, y, z;

            string s = Console.ReadLine();
            string[] s_arr = s.Split();

            x = double.Parse(s_arr[0]);
            y = double.Parse(s_arr[1]);
            z = double.Parse(s_arr[2]);

            int n = int.Parse(Console.ReadLine());

            double Ai = 0, Bi = 0, Ci = 0;

            double[,] eat = new double[n, 4];

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                s_arr = s.Split();

                for (int j = 0; j < 4; j++)
                {
                    eat[i, j] = double.Parse(s_arr[j]);
                }
                Ai += eat[i, 0] * eat[i, 3];
                Bi += eat[i, 1] * eat[i, 3];
                Ci += eat[i, 2] * eat[i, 3];
            }

            if (Ai >= x && Bi >= y && Ci >= z)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        static void Main()
        {
            //N1();
            //N2();
            //N3();
            //N4();
            //N5();
            //N6();
            //N7();
        }
    }
}
