using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_while
{
    class Program  
    {    
        public static void N1()
        {
            int n = int.Parse(Console.ReadLine());

            int square = 1;

            while (true)
            {
                if (square * square <= n)
                    Console.WriteLine(square * square++);
                else
                    break;
            }
        }
        public static void N2()
        {
            int x = int.Parse(Console.ReadLine());

            int i = 2;
            while (i <= x)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                i++;
            }
        }
        public static void N3()
        {
            int n = int.Parse(Console.ReadLine());

            int square = 2;

            while (square <= n)
            {
                Console.Write(square + " ");
                square *= 2;
            }
            Console.WriteLine();
        }
        public static void N4()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;

            while (x * 2 <= 1000)
            {
                if (n == x * 2)
                {
                    Console.WriteLine("YES");
                    break;
                }
                x++;
            }

            if (!(n == x* 2))
            {
                Console.WriteLine("NO");
            }
        }
        public static void N5()
        {
            int n = int.Parse(Console.ReadLine());

            int k = 0;
            int p = 1;
            while (p < n)
            { 
                p = p * 2;
                k += 1;
            }

            Console.WriteLine(k);
        }
        public static void N6()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            int days = 1;

            while (x <= y)
            {
                x += (x / 100 * 10);
                days++;
            }

            Console.WriteLine(days);
        }
        public static void N7()
        {
            float x = float.Parse(Console.ReadLine());
            float p = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            int years = 0;

            while (x <= y)
            {
                x += (x / 100 * p);
                years++;
            }

            Console.WriteLine(years);
        }
        public static void N8()
        {
            int n = int.Parse(Console.ReadLine());

            int y = 1, z = 1, b = 1, i = 2;

            while (i < n)
            {
                z = y;
                y = b;
                b = z + y;
                i++;
            }

            Console.WriteLine(b);
        }
        public static void N9()
        {
            int n = int.Parse(Console.ReadLine());

            int y = 1, z = 1, b = 1, i = 3;
            int q = -1;

            while (i < n)
            {
                z = y;
                y = b;
                b = z + y;
                if (b == n)
                    q = i;
                i++;
            }
            Console.WriteLine(q);
        }
        public static void N10()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a % 2 == 0)
                {
                    if (a / 2 > b)
                    {
                        a /= 2;
                        Console.WriteLine(":2");
                    }
                    else
                    {
                        a -= 1;
                        Console.WriteLine("-1");
                    }
                }
                else
                {
                    a -= 1;
                    Console.WriteLine("-1");
                }
            }
        }
        public static void N11()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char min, max;
            bool reall;
            long bV, Av, k;
            min = 'B';
            max = 'A';
            reall = false;
            Av = 0;
            bV = 0;
            k = 0;
            while (k <= 104)
            {
                k += 2;
                if (b - bV >= a)
                    bV += a;
                else
                {
                    bV = a - (b - bV);
                    k += 2;
                }
                if (n == bV) { reall = true; break; }
            }
            if (reall)
            {
                bV = 0;
                while (true)
                {
                    Console.WriteLine(">", min);
                    Console.WriteLine(min + ">" + max);
                    if (b - bV >= a)
                        bV += a;
                    else
                    {
                        bV = a - (b - bV);
                        Console.WriteLine(max + ">");
                        Console.WriteLine(min + ">" + max);
                    }
                    if (n == bV) break;
                }
            }
            else Console.WriteLine("Impossible");

        }
        public static void N12()
        {
            int zero = 0;
            while (true)
            {
                if (int.Parse(Console.ReadLine()) == 0)
                    break;
                else 
                    zero++;
            }
            Console.WriteLine(zero);
        }
        public static void N13()
        {
            int sum = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else
                    sum += num;
            }
            Console.WriteLine(sum);
        }
        public static void N14()
        {
            float sr = 0;
            int numbers = 0;

            while (true)
            {
                float num = float.Parse(Console.ReadLine());

                if (num == 0.0)
                    break;
                else 
                {
                    sr += num;
                    numbers++;
                }
            }
            sr /= numbers;

            Console.WriteLine(sr);
        }
        public static void N15()
        {
            int par = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else if (num % 2 == 0)
                    par++;
            }

            Console.WriteLine(par);
        }
        public static void N16()
        {
            int max = -999;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else if (max < num)
                    max = num;
            }
            Console.WriteLine(max);
        }
        public static void N17()
        {
            int res = 0; ;

            int prev = -999;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else if (num > prev)
                    res++;
                prev = num;
            }
            Console.WriteLine(res);
        }
        public static void N18()
        {
            int max2 = 0;

            int max = -999;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else if (max2 < num)
                {
                    if (max < num)
                    {
                        max2 = max;
                        max = num;
                    }
                    else
                        max2 = num;
                }
            }
            Console.WriteLine(max2);
        }
        public static void N19()
        {
            int max2 = 0;

            int max = -999;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else if (max2 < num)
                {
                    if (max < num)
                    {
                        max2 = max;
                        max = num;
                    }
                    else
                        max2 = num;
                }
            }
            Console.WriteLine(max2);
        }
        public static void N20()
        {
            int max = -999;

            int count = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                else if (max == num)
                    count++;
                else if (max < num)
                {
                    max = num;
                    count = 1;
                }
            }
            Console.WriteLine(count);
        }
        public static void N21()
        {
            //? одно и тоже задание c 20
        }
        public static void N22()
        {
            int sum = 0;

            bool zero = false;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0 && zero == true)
                    break;
                else if (num == 0)
                    zero = true;
                else
                    sum += num;
            }
            Console.WriteLine(sum);
        }
        public static void N23()
        {
            int count = 0;
            int count2 = 0;

            int prevNum = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                if (num == prevNum)
                    count2++;
                else
                {
                    if (count2 > count)
                        count = count2;
                    count2 = 1;
                    prevNum = num;
                }    
            }
            Console.WriteLine(count);
        }
        public static void N24()
        {
            int count = 0;
            int count2 = 0;

            int prevNum = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                if (num != prevNum)
                    count2++;
                else
                {
                    if (count2 > count)
                        count = count2;
                    count2 = 1;
                }
                prevNum = num;
            }
            Console.WriteLine(count);
        }
        public static void N25()
        {
            int locMax = 0;

            int prevPrevNum = 0;
            int prevNum = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;
                if (prevPrevNum < prevNum && prevNum > num)
                    locMax = prevNum;

                prevPrevNum = prevNum;
                prevNum = num;
            }
            Console.WriteLine(locMax);
        }
        public static void N26()
        {
            int locMaxPos1 = -999;
            int locMaxPos2 = -999;
            int range = 0;
            int answer = 0;

            int prevPrevNum = 0;
            int prevNum = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                range++;

                if (num == 0)
                    break;
                if (prevPrevNum < prevNum && prevNum > num)
                {
                    locMaxPos1 = locMaxPos2;
                    locMaxPos2 = range - 1;
                    if (locMaxPos1 != -999 && locMaxPos2 != -999)
                    {
                        if (locMaxPos2 - locMaxPos1 < range)
                            answer = locMaxPos2 - locMaxPos1;
                    }
                }

                prevPrevNum = prevNum;
                prevNum = num;
            }
            Console.WriteLine(answer);
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
            //N25();
            //N26();
        }
    }
}
