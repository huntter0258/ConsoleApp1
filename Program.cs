using System;
using System.Diagnostics;   //Stopwatch include

namespace ConsoleApp1
{
    class Program
    {
        static void lecture1()
        {
            const int aa = 1;
            int a = int.MaxValue;
            int b = 1;
            int c = 15;
            double f = 123.125;
            Console.WriteLine("{0:0.0}", f);
            Console.WriteLine("|{0}|", aa);
        }
        static void swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void mySwap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void lectureSwap()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("before : a={0}, b={1}", a, b);
            swap(a, b);
            Console.WriteLine("swap   : a={0}, b={1}", a, b);
            mySwap(ref a, ref b);
            Console.WriteLine("mySwap : a={0}, b={1}", a, b);
        }

        static int sum(int a, int b)
        {
            return a + b;
        }

        static double sum(double a, double b)
        {
            return a + b;
        }

        static void lectureOverloading()
        {
            double a = 1.1;
            double b = 2.2;
            int c = 3;
            int d = 4;

            Console.WriteLine("{0} + {1} = {2:0.0}", a,b,sum(a,b));
            Console.WriteLine("{0} + {1} = {2}", c, d, sum(c, d));
        }

        static int myFactorial(int n)
        {
            //Console.WriteLine("myFactorial : n = {0}", n);
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n*myFactorial(n - 1);
            }
        }

        static int myFactorialLoop(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            int result = 1;
            for(int i=n; i>1; i--)
            {
                result *= i;
                //Console.WriteLine("i = {0} , result = {1}", i, result);
            }
            return result;
        }

        static void lectureRecursive()
        {
            int n = 10;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("myFactorial     :  {0}! = {1}", n, myFactorial(n));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString() + "ms");
            sw.Reset();
            sw.Start();
            Console.WriteLine("myFactorialLoop :  {0}! = {1}", n, myFactorialLoop(n));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString() + "ms");

        }

            static void lecture2()
        {
            //lectureSwap();
            //lectureOverloading();
            lectureRecursive();
        }

        static void Main(string[] args)
        {
            lecture1();
            //lecture2();
        }
    }
}
