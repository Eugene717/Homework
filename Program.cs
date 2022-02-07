using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_O
{
    class Program  
    {    
        public static void N1()
        {
            double a = Int32.Parse(Console.ReadLine());
            double b = Int32.Parse(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine(c);
        }  
        public static void N2()
        {
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The next number for the number " + number + " is " + (number + 1));
            Console.WriteLine("The previsious number for the number " + number + " is " + (number - 1));
        }
        public static void N3()
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());

            int count = k / n;

            Console.WriteLine(count);
        }
        public static void N4()
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());

            int count = k % n;

            Console.WriteLine(count);
        }
        public static void N5()
        {
            int n = Int32.Parse(Console.ReadLine());

            int a = n % 10;

            Console.WriteLine(a);
        }
        public static void N6()
        {
            int n = Int32.Parse(Console.ReadLine());

            int a = n / 10;

            Console.WriteLine(a);
        }
        public static void N7()
        {
            int n = Int32.Parse(Console.ReadLine());

            int a = n % 100;
            int b = a / 10;

            Console.WriteLine(b);
        }
        public static void N8()
        {
            int n = Int32.Parse(Console.ReadLine());

            int a = n / 100;
            int b = n % 100 / 10;
            int c = n % 100 % 10;

            Console.WriteLine((a + b + c));
        }
        public static void N9()
        {
            int n = Int32.Parse(Console.ReadLine());

            int next = n + 2;
            next -= next % 2;

            Console.WriteLine(next);
        }
        public static void N10()
        {
            int n = Int32.Parse(Console.ReadLine());

            n = n % 1440;

            int hour, min;
            hour = n / 60;
            min = n % 60;

            Console.WriteLine(hour + " " + min);
        }
        public static void N11()
        {
            int s = Int32.Parse(Console.ReadLine());

            s = s % 86400;

            int hour, min, sec;
            hour = s / 3600;
            min = s % 3600 / 60;
            sec = s % 60;

            Console.WriteLine(hour + ":" + min.ToString("00") + ":" + sec.ToString("00"));
        }
        public static void N12()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " " + b);
        }
        public static void N13()
        {
            int n = Int32.Parse(Console.ReadLine());
            int time = 9 * 60;

            time += n * 45;

            time += (n - 1) * 5;
            time += (n - 1) / 2 * (15 - 5);

            Console.WriteLine(time / 60 + " " + time % 60);
        }
        public static void N14()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());

            int money = n * (a * 100) + n * b;

            Console.WriteLine(money / 100 + " " + money % 100);
        }
        public static void N15()
        {
            int a1 = Int32.Parse(Console.ReadLine());
            int b1 = Int32.Parse(Console.ReadLine());
            int c1 = Int32.Parse(Console.ReadLine());

            int a2 = Int32.Parse(Console.ReadLine());
            int b2 = Int32.Parse(Console.ReadLine());
            int c2 = Int32.Parse(Console.ReadLine());

            int n1 = a1 * 3600 + b1 * 60 + c1;
            int n2 = a2 * 3600 + b2 * 60 + c2;

            Console.WriteLine(n2 - n1);
        }
        public static void N16()
        {
            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());

            Console.WriteLine((m + n) / n);
        }
        public static void N17()
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());

            int restInt = k / n;
            int applOst = k - n * restInt;
            int a = n - applOst;

            Console.WriteLine(a);
        }
        public static void N18()
        {
            int h = Int32.Parse(Console.ReadLine());
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            int cycle = a - b;
            int days = 1 + (h - a) / cycle + ((h - a) % cycle + cycle - 1) / cycle;

            Console.WriteLine(days);
        }
        public static void N19()
        {
            int number = Int32.Parse(Console.ReadLine());

            int a = number / 1000;
            int b = number % 1000 / 100;
            int c = number % 1000 % 100 / 10;
            int d = number % 1000 % 100 % 10;

            int left = (a * 10) + b;
            int right = (d * 10) + c;

            Console.WriteLine(left - right + 1);
        }
        public static void N20()
        {
            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());

            int a1 = n % m;
            int a2 = m % n;

            Console.WriteLine(a1 * a2 + 1);
        }
        public static void N21()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine((a / b * a + b / a * b) / (a / b + b / a));
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
            //N21();
        }
    }
}
