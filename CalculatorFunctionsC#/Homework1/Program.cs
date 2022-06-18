using System;
namespace Luanda
{
    class Homework1
    {
        public static int compute (int n,int m)
        {
            int sum = 0;
            for (int i=n; i <= m; i++)
            {
                sum=sum+i;
            }
            return sum;
        }
        public static int power( int n, int x)
        {
            int sum = 1;
            if (n == 0)
            {
                return sum;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                     sum = sum *x;
                }
                return sum;
            }
        }
        public static int product(int n, int m)
        {
            int sum = 1;
            for (int i = n; i <= m; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
        public static void miNmaX( int num1, int num2)
        {
            int min = 0 ;
            int max = min;

            if (num1 > num2)
            {
                max = num1;
                min = num2;
                Console.WriteLine("Max is {0} , Min is {1}" , max,min);
            } else
            {
                max = num2;
                min = num1;
                Console.WriteLine("Max is {0} , Min is {1}", max, min);
            }

        }
        public static void Main()
        {
            //exercise 1
            Console.WriteLine("Enter initial number: ");
            int x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(compute(x, y));

            //exercise 2
            Console.WriteLine("Enter your number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power number: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(power(p, m));

            // exercise 3
            Console.WriteLine("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            miNmaX(n1, n2);

            //exercise 3
            Console.WriteLine("Enter initial number: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(product(f, k));
        }
    }
}

