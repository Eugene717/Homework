using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_switch
{
    class Program  
    {    
        public static void N1()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a >= b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
        public static void N2()
        {
            int year = Int32.Parse(Console.ReadLine());

            if (year % 400 == 0)
                Console.WriteLine("YES");
            else if (year % 100 == 0)
                Console.WriteLine("NO");
            else if (year % 4 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N3()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a == b)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N4()
        {
            int x = Int32.Parse(Console.ReadLine());

            if (x > 0)
                x = 1;
            if (x < 0)
                x = -1;       

            Console.WriteLine(x);
        }
        public static void N5()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a >= b)
                Console.WriteLine(1);
            else
                Console.WriteLine(2);
        }
        public static void N6()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            int max = -100;

            if (a >= max)
                max = a;
            if (b >= max)
                max = b;
            if (c >= max)
                max = c;

            Console.WriteLine(max);
        }
        public static void N7()
        {
            int fx = Int32.Parse(Console.ReadLine());
            int fy = Int32.Parse(Console.ReadLine());
            int sx = Int32.Parse(Console.ReadLine());
            int sy = Int32.Parse(Console.ReadLine());

            if ((fx == sx) || (fy == sy))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N8()
        {
            int fx = Int32.Parse(Console.ReadLine());
            int fy = Int32.Parse(Console.ReadLine());
            int sx = Int32.Parse(Console.ReadLine());
            int sy = Int32.Parse(Console.ReadLine());

            if ((fx - sx) == (fy - sy))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N9()
        {
            int fx = Int32.Parse(Console.ReadLine());
            int fy = Int32.Parse(Console.ReadLine());
            int sx = Int32.Parse(Console.ReadLine());
            int sy = Int32.Parse(Console.ReadLine());

            if ((fx == sx) || (fy == sy))
                Console.WriteLine("YES");
            else if((fx - sx) == (fy - sy))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N10()
        {
            int fx = Int32.Parse(Console.ReadLine());
            int fy = Int32.Parse(Console.ReadLine());
            int sx = Int32.Parse(Console.ReadLine());
            int sy = Int32.Parse(Console.ReadLine());

            if (Math.Abs(fx - sx) == 1 && Math.Abs(fy - sy) == 1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N11()
        {
            int fx = Int32.Parse(Console.ReadLine());
            int fy = Int32.Parse(Console.ReadLine());
            int sx = Int32.Parse(Console.ReadLine());
            int sy = Int32.Parse(Console.ReadLine());

            if (Math.Abs(fx - sx) * Math.Abs(fy - sy) == 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N12()
        {
            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());

            if (k > (n * m))
                Console.WriteLine("No");
            else if ((k % n == 0) || (k % m == 0))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("NO");
        }
        public static void N13()
        {
            int k = Int32.Parse(Console.ReadLine());

            if (k % 2 == 0 || k == 1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N14()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (b == 0)
                Console.WriteLine("INF");
            else if (a == 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine(-b / a);
        }
        public static void N15()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
                Console.WriteLine("INF");
            else if (a == 0 || b * c == a * d)
                Console.WriteLine("NO");
            else if (b % a == 0)
                Console.WriteLine(-b / a);
            else
                Console.WriteLine("NO");
        }
        public static void N16()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int money = c * 100 + d;
            int sum = a * 100 + b;

            money -= sum;

            int e = money / 100, f = money % 100;

            Console.WriteLine(e + " " + f);
        }
        public static void N17()
        {
            int k = int.Parse(Console.ReadLine());

            if (k % 3 == 0 || k % 5 == 0 || k % 8 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N18()
        {
            double k = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());

            if (m % k == 0)
                Console.WriteLine((m / k) * (n * 2));
            else
                Console.WriteLine(((int)(m / k) * (n * 2)) + (n * 2));
        }
        public static void N19()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            int equal = 3;

            if (a != b && a != c)
                equal--;
            if (b != c && b != a)
                equal--;
            if (c != b && c != a)
                equal--;

            Console.WriteLine(equal);
        }
        public static void N20()
        {
            double n = double.Parse(Console.ReadLine());
            string cow = "";

            switch (n % 10)
            {
                case 0: case 5: case 6: case 7: case 8: case 9:
                    cow = "korov";
                    break;
                case 1:
                    cow = "korova";
                    break;
                case 2: case 3: case 4:
                    cow = "korovu";
                    break;
            }

            Console.WriteLine(n + " " + cow);
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
            //N8();
            //N9();
            //N10();
            //N11();
            //N12();
            //N13();
            //N14();
            //N15();
            //N16();
            //N17();
            //N18();
            //N19();
            //N20();
        }
    }
}
