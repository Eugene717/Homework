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

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
                if (i % 2 == 0)
                    Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        public static void N2()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
                if (A[i] % 2 == 0)
                    Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        public static void N3()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
                if (A[i] >= 0)
                    Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        public static void N4()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int count = 0;

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
                if (i > 0)
                    if (A[i - 1] < A[i])
                        count++;
            }
            Console.WriteLine(count);
        }
        public static void N5()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            bool count = false;

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
                if (i > 0)
                {
                    if (A[i - 1] >= 0 && A[i] >= 0)
                        count = true;
                    else if (A[i - 1] < 0 && A[i] < 0)
                        count = true;
                }
            }
            if (count)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N6()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int locMax = 0;

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(strs[i]);

            for (int i = 1; i < n - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    locMax++;
            }

            Console.WriteLine(locMax);
        }
        public static void N7()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(strs[i]);

            Array.Reverse(A);

            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        public static void N8()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(strs[i]);

            for (int i = 0; i < n - 1; i+=2)
            {
                int temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp;
            }

            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }
        public static void N9()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    A[i + 1] = int.Parse(strs[i]);
                else
                    A[0] = int.Parse(strs[i]);
            }

            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }
        public static void N10()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            int max = -999;

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
                if (A[i] > max)
                    max = A[i];
            }

            Console.WriteLine(max);
        }
        public static void N11()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(strs[i]);

            int numbers = n * n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] == A[j])
                        numbers--;
                }
            }

            Console.WriteLine(numbers);
        }
        public static void N12()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(strs[i]);

            int petya = int.Parse(Console.ReadLine());
            int petyaPos = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (petya > A[i])
                {
                    petyaPos = i + 1;
                    break;
                }
            }

            Console.WriteLine(petyaPos);
        }
        public static void N13()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int a = int.Parse(strs[1]);
            int b = int.Parse(strs[2]);
            int c = int.Parse(strs[3]);
            int d = int.Parse(strs[4]);

            int[] A = new int[n];

            for (int i = 0; i < n; i++)
                A[i] = i + 1;

            for (int i = a - 1, j = b - 1; i < b && j > a; i++, j--) 
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
            for (int i = c - 1, j = d - 1; i < d && j > c; i++, j--) 
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }

            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }
        public static void N14()
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            string str = Console.ReadLine();
            string[] strs = str.Split();

            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(strs[i]);
            }

            int tmp;
            int nextInd = 0;
            for (int i = 0; i < A.Length - 1; ++i)
            {
                nextInd += k;
                nextInd %= A.Length;
                if (nextInd < 0)
                    nextInd += n;

                tmp = A[nextInd];
                A[nextInd] = A[0];
                A[0] = tmp;
            }

            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }
        public static void N15()
        {

            string str = Console.ReadLine();
            string[] strs = str.Split();

            int[] A = new int[strs.Length];
            for (int i = 0; i < A.Length; i++)
                A[i] = int.Parse(strs[i]);

            int deleted = 0;
            int prev = -1, count = 1;

            for (int i = 0; i <= A.Length - deleted; i++)
            {
                if (prev == A[i])
                    count++;
                else
                {
                    if (count >= 3)
                    {
                        deleted += count;
                        for (int k = 0; k < count; k++)
                        {
                            for (int j = i - count; j < A.Length; j++)
                            {
                                if (j < A.Length - 1)
                                    A[j] = A[j + 1];
                            }
                        }
                        i = 0;
                    }
                    count = 1;
                    prev = A[i];
                }
            }
            if (count > 3)
                deleted += count - 1;
            Console.WriteLine(deleted);
        }
        public static void N16()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[n, n];

            int k = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (j == k)
                        A[i, j] = 1;
                    else if (j < k)
                        A[i, j] = 0;
                    else
                        A[i, j] = 2;
                }
                k--;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
        }
        public static void N17()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split();
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }
            bool symm = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] != A[j, i])
                    {
                        symm = false;
                        break;
                    }
                }
            }

            if (symm)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void N18()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                strs = str.Split();
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }

            int max = 0;
            int bestInd = -1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += A[i, j];   
                }
                if (sum > max)
                {
                    max = sum;
                    bestInd = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(bestInd);
        }
        public static void N19()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                strs = str.Split();
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }

            int max = 0;
            int bestInd = -1, bestInd2 = -1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        bestInd = i;
                        bestInd2 = j;
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(bestInd + " " + bestInd2);
        }
        public static void N20()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                strs = str.Split();
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }

            int max = 0;
            int bestInd = -1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        bestInd = i;
                    }
                }
            }

            Console.WriteLine(bestInd);
        }
        public static void N21()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                strs = str.Split();
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }

            int max = 0;
            int winner = 1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += A[i, j];
                }
                if (sum > max)
                {
                    max = sum;
                    winner = 1;
                }
                else if (sum == max)
                    winner++;
            }

            Console.WriteLine(winner);
        }
        public static void N22()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                strs = str.Split();
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }

            int max = 0;
            int winner = 1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += A[i, j];
                }
                if (sum > max)
                {
                    max = sum;
                    winner = 1;
                }
                else if (sum == max)
                    winner++;
            }

            Console.WriteLine(winner);
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += A[i, j];
                }
                if (sum == max)
                    Console.WriteLine(i);
            }
        }
        public static void N23()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            int i = 0, j = 0;
            while (i < n)
            {
                A[i, j] = i * j;
                j++;
                if (j == m)
                {
                    i++;
                    j = 0;
                }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void N24()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || j ==0)
                    {
                        A[i, j] = 1;
                    }
                    else
                    {
                        A[i, j] = A[i - 1, j] + A[i, j - 1];
                    }
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void N25()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[2 * n + 1, 2 * n + 1];

            int k = 1, i, j;
            i = n;
            j = n;

            int num = 0;

            while (num < (n * 2 + 1) * (n * 2 + 1))
            {
                for (int d = 0; d < k; d++)
                {
                    A[i, j] = num++;
                    i--;
                }
                if (num >= (n * 2 + 1) * (n * 2 + 1))
                    break;
                for (int d = 0; d < k; d++)
                {
                    A[i, j] = num++;
                    j--;
                }
                k++;
                if (num >= (n * 2 + 1) * (n * 2 + 1))
                    break;
                for (int d = 0; d < k; d++)
                {
                    A[i, j] = num++;
                    i++;
                }
                if (num >= (n * 2 + 1) * (n * 2 + 1))
                    break;
                for (int d = 0; d < k; d++)
                {
                    A[i, j] = num++;
                    j++;
                }
                k++;
            }

            for (i = 0; i < n * 2 + 1; i++)
            {
                for (j = 0; j < n * 2 + 1; j++) 
                {
                    Console.Write("{0,3}", A[i, j], " ");
                }
                Console.WriteLine();
            }
        }
        public static void N26()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            int num = 0;
            for (int i = 0; i < n; i++)
            {
                int j;
                if (i % 2 == 0)
                    j = 0;
                else
                    j = m - 1;
                for (; j < m && j >= 0;)
                {
                    A[i, j] = num++;
                    if (i % 2 == 0)
                        j++;
                    else
                        j--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", A[i, j], " ");
                }
                Console.WriteLine();
            }
        }
        public static void N27()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            int num = 0;
            int k = 1, i = 0, j;
            int d = 0;

            A[0, 0] = num++;
            for (;i < n;)
            {
                for (j = 0 + k; j >= 0 && j < m && i < n;)
                {
                    A[i, j] = num++;
                    i++; j--;
                    if (j < 0)
                        i = 0;
                }
                if (k < m - 1)
                {
                    k++;
                    i = 0;
                }
                else
                {
                    d++;
                    i = d;
                }

                if (num > n * m)
                    break;
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", A[i, j], " ");
                }
                Console.WriteLine();
            }
        }
        public static void N28()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);
            int w = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];

            for (int k = 0; k < w; k++)
            {
                str = Console.ReadLine();
                strs = str.Split();

                int i = int.Parse(strs[0]) - 1, j = int.Parse(strs[1]) - 1;
                A[i, j] = -10;

                if (i > 0)
                {
                    A[i - 1, j]++;
                    if (j > 0)
                        A[i - 1, j - 1]++;
                    if (j < m - 1)
                        A[i - 1, j + 1]++;
                }
                if (i < n - 1)
                {
                    A[i + 1, j]++;
                    if (j > 0)
                        A[i + 1, j - 1]++;
                    if (j < m - 1)
                        A[i + 1, j + 1]++;
                }
                if (j > 0)
                    A[i, j - 1]++;
                if (j < m - 1)
                    A[i, j + 1]++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] < 0)
                        Console.Write("* ");
                    else
                        Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void N29()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int n = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                strs = str.Split();
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(strs[j]);
                }
            }

            int[,] newArr = new int[m, n];

            for (int i = 0, k = n - 1; i < n; i++, k--)
            {
                for (int j = 0; j < m; j++)
                {
                    newArr[j, k] = A[i, j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", newArr[i, j], " ");
                }
                Console.WriteLine();
            }
        }
        public static void N30()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[n, n];

            int i = 0, j = 0, k = 0;
                        
            while (k < n)
            {
                for (; i >= 0 + k; i--)
                {
                    A[i, j] = 1;
                }
                i = k;
                for (; j < n - k; j++)
                {
                    A[i, j] = 1;
                }
                j--;
                for (; i < n - k; i++)
                {
                    A[i, j] = 1;
                }
                i--;
                for (; j >= 0 + k; j--)
                {
                    A[i, j] = 1;
                }
                j++;
                k += 2;
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j]);
                }
                Console.WriteLine();
            }
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
            //N27();
            //N28();
            //N29();
            //N30();
        }
    }
}
