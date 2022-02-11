using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_for
{
    class Program  
    {    
        public static void N1()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }

            Console.WriteLine(sum);
        }
        public static void N2()
        {
            int N = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
        public static void N3()
        {
            int N = int.Parse(Console.ReadLine());

            int answer = 2;

            for (int i = 0; i < N - 1; i++)
            {
                answer *= 2;
            }

            Console.WriteLine(answer);
        }
        public static void N4()
        {
            double N = double.Parse(Console.ReadLine());

            double sum = 1.0;

            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i; 
            }

            Console.WriteLine(sum);
        }
        public static void N5()
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int answer = a;

            for (int i = 0; i < n - 1; i++)
            {
                answer *= a;
            }

            Console.WriteLine(answer);
        }
        public static void N6()
        {
            int n = int.Parse(Console.ReadLine());

            int answer = 2;

            for (int i = 0; i < n - 1; i++)
            {
                answer *= 2;
            }

            Console.WriteLine(answer);
        }
        public static void N7()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a % 2 == 1)
                a++;

            for (; a <= b; a += 2) 
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        public static void N8()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());

            for (; a < b; a++)
            {
                if ((a % (d / c)) != 0)
                    Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        public static void N9()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            for (; a <= b; a++)
            {
                if (Math.Sqrt(a) % 1 == 0.0)
                    Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        public static void N10()
        {
            int x = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int answer = 0;

            for (int i = 0; i <= x; i++)
            {
                if (i % d == 0)
                    answer++;
            }

            Console.WriteLine(answer);
        }
        public static void N11()
        {
            int x = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 1; i < x;)
            {
                result += x % 10;
                x /= 10;
            }

            Console.WriteLine(result);
        }
        public static void N12()
        {
            int x = int.Parse(Console.ReadLine());

            int rev = 0;
            for (int i = 0; i < x;)
            {
                int r = x % 10;
                rev = rev * 10 + r;
                x = x / 10;
            }

            Console.WriteLine(rev);
        }
        public static void N13()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i < x + 1; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        public static void N14()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i < x + 1; i++)
            {
                if (x % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void N15()
        {
            int x = int.Parse(Console.ReadLine());

            int dilSum = 0;

            for (int i = 2; i < x + 1; i++)
            {
                if (x % i == 0)
                    dilSum++;
            }
            Console.WriteLine(dilSum);
        }
        public static void N16()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += int.Parse(Console.ReadLine());                
            }

            Console.WriteLine(sum);
        }
        public static void N17()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
        public static void N18()
        {
            var binNum = Console.ReadLine();

            int num = 0;
            var result = 0u;

            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                if (binNum[i] == '1')
                {
                    result += Convert.ToUInt32(Math.Pow(2, num));
                }
                num++;
            }

            Console.WriteLine(result);
        }
        public static void N19()
        {
            int n = int.Parse(Console.ReadLine());

            int zero = 0;

            for (int i = 0; i < n; i++)
            {
                if (int.Parse(Console.ReadLine()) == 0)
                    zero++;
            }
            Console.WriteLine(zero);
        }
        public static void N20()
        {
            int n = int.Parse(Console.ReadLine());

            int zero = 0;
            int positive = 0;
            int negative = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                    zero++;
                if (num > 0)
                    positive++;
                if (num < 0)
                    negative++;
            }

            Console.WriteLine(zero + " " + positive + " " + negative);
        }
        public static void N21()
        {
            int n = int.Parse(Console.ReadLine());

            int zero = 0;

            for (int i = 0; i < n; i++)
            {
                if (int.Parse(Console.ReadLine()) == 0)
                    zero++;
            }

            if (zero > 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N22()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 1000; i++)
            {
                if (a * i * i * i + b * i * i + c * i + d == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void N23()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = 1000; i >= 0; i--)
            {
                if (a * i * i * i + b * i * i + c * i + d == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void N24()
        {
            int sec = int.Parse(Console.ReadLine());

            int num = 1, time = 0;

            for (int i = 0; i < sec; i++)
            {
                Console.Write(num + " ");
                time++;
                if (time == num)
                {
                    time=0;
                    if (num < 5)
                        num++;
                    else
                        num = 1;
                }    
            }
            Console.WriteLine();
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
            //N22();
            //N23();
            //N24();
        }
    }
}
