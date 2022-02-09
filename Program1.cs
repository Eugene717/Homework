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

            int[,] a = new int[n, 2];

            int bigger = 0;
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                a[i, 0] = int.Parse(s_arr[0]);
                a[i, 1] = int.Parse(s_arr[1]);

                int m = a[i, 0] + a[i, 1];

                if (m > bigger)
                { 
                    bigger = m;
                    number = i;
                }
            }

            Console.WriteLine(a[number, 0] + " " + a[number, 1]);
        }
        public struct Point
        {            
            public double x, y;
        }
        public static void N2()
        {
            int n = Int32.Parse(Console.ReadLine());

            Point[] arr = new Point[n];

            Point middle;
            middle.x = 0;
            middle.y = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                arr[i].x = int.Parse(s_arr[0]);
                arr[i].y = int.Parse(s_arr[1]);

                middle.x += arr[i].x;
                middle.y += arr[i].y;
            }

            middle.x = middle.x / n;
            middle.y = middle.y / n;

            Console.WriteLine(middle.x + " " + middle.y);
        }
        public static void N3()
        {
            int n = Int32.Parse(Console.ReadLine());

            Point[] arr = new Point[n];

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                arr[i].x = int.Parse(s_arr[0]);
                arr[i].y = int.Parse(s_arr[1]);
            }

            Point a;
            a = arr[0];

            for (int i = 1; i < n; i++)
            {
                a.x -= arr[i].x;
                a.y -= arr[i].y;
            }

            a.x = a.x * a.x;
            a.y = a.y * a.y;

            double diametr = Math.Sqrt(a.x + a.y);

            Console.WriteLine(diametr);
        }
        public static void N4()
        {
            int n = Int32.Parse(Console.ReadLine());

            Point[] arr = new Point[n];

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                arr[i].x = int.Parse(s_arr[0]);
                arr[i].y = int.Parse(s_arr[1]);
            }

            Array.Sort(arr, (i, j) => (i.x + i.y).CompareTo(j.x + j.y));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i].x + " " + arr[i].y);
            }
        }
        public static void N5()
        {
        }
        public static void N6()
        {
            
        }
        public static void N7()
        {
            int n = Int32.Parse(Console.ReadLine());

            double[,] arr = new double[n, 3];

            double[] middle = new double[3];
            middle[0] = 0;
            middle[1] = 0;
            middle[2] = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                arr[i,0] = int.Parse(s_arr[2]);
                arr[i,1] = int.Parse(s_arr[3]);
                arr[i,2] = int.Parse(s_arr[4]);

                middle[0] += arr[i, 0];
                middle[1] += arr[i, 1];
                middle[2] += arr[i, 2];
            }

            middle[0] = middle[0] / n;
            middle[1] = middle[1] / n;
            middle[2] = middle[2] / n;

            Console.WriteLine(middle[0] + " " + middle[1] + " " + middle[2]);
        }
        public static void N8()
        {
            int n = Int32.Parse(Console.ReadLine());

            string[,] people = new string[n, 2];
            double[] rating = new double[n];

            double bestRating = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                people[i, 0] = s_arr[0];
                people[i, 1] = s_arr[1];

                double mid = 0;
                mid += int.Parse(s_arr[2]);
                mid += int.Parse(s_arr[3]);
                mid += int.Parse(s_arr[4]);

                mid = mid / 3;
                rating[i] = mid;

                if (mid > bestRating)
                    bestRating = mid;
            }

            for (int i = 0; i < n; i++)
            {
                if (rating[i] == bestRating)
                    Console.WriteLine(people[i, 0] + " " + people[i, 1]);
            }
        }
        public static void N9()
        {
            int n = Int32.Parse(Console.ReadLine());

            string[,] people = new string[n, 2];
            double[,] rating = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                people[i, 0] = s_arr[0];
                people[i, 1] = s_arr[1];

                double mid = 0;
                mid += int.Parse(s_arr[2]);
                mid += int.Parse(s_arr[3]);
                mid += int.Parse(s_arr[4]);

                mid = mid / 3;
                rating[i, 0] = mid;
                rating[i, 1] = i;
            }

            double[] bestRating = new double[n];
            for (int i = 0; i < n; i++)
            {
                bestRating[i] = rating[i, 0];
            }

            Array.Sort(bestRating);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (bestRating[i] == rating[j, 0])
                        Console.WriteLine(people[(int)rating[j, 1], 0] + " " + people[(int)rating[j, 1], 1]);
                }                
            }
        }

        static void Main()
        {
            //N1();
            //N2();
            //N3();
            //N4();
            N5();
            N6();
            //N7();
            //N8();
            //N9();
        }
    }
}
