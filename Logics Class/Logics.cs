using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics_Class
{
    internal class Logics
    {
        public void Star1 (int a)
        {
            for (int i=0;i<a;i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void SquareStar (int a)
        {
            for(int i=0;i<a; i++)
            {
                for (int j=0; j<a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void LeftStar (int a)
        {
            for (int i=0 ;i<a ;i++)
            {
                for (int j = 0 ;j<=i ;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void RightStar (int a)
        {
            int b = 5,c= 1;
            for ( int i=0 ;i<a ; i++)
            {
                for (int j=0 ;j<b ;j++)
                {
                    Console.Write(" ");
                }
                b = b - 1;
                for (int k=0 ;k<c ;k++)
                {
                    Console.Write("*");
                }
                c = c + 1;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void TriangleStar (int a)
        {
            int b = 5, c = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                b = b - 1;
                for (int k = 0; k < c; k++)
                {
                    Console.Write(" *");
                }
                c = c + 1;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void StarLetter (int a)
        {
            int b = 5, c = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                b = b - 1;
                for (int k = 0; k < c; k++)
                {
                    if (c == 3 && k == 1)
                    {
                        Console.Write(" a");
                    }
                    else if (c == 4 && k == 2)
                    {
                        Console.Write(" b");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                c = c + 1;
                Console.WriteLine();
            }
        }
        public void Series(int a)
        {
                int b = 1;
                Console.Write("Series : ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write(" " + b);
                    b = b + 1;
                }
                Console.WriteLine();
        }
        public void AdditionSeries(int a)
        {
            int b = 0;
            int c = 0;
            for (int i = 0; i < a; i++)
            {
                c = c + 1;
                b = b + c;
            }
            Console.Write("Addition Series : " + b);
            Console.WriteLine();
        }
        public void OddSeries(int a)
        {
            int b = 0;
            Console.Write("Odd Series : ");
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(" " + b);
                }
                b = b + 1;
            }
            Console.WriteLine();
        }
        public void EvenSeries(int a)
        {
            a = a / 2;
            int b = 2;
            Console.Write("Even Series : ");
            for (int i = 0; i < a; i++)
            {
                Console.Write(" " + b);
                b = b + 2;
            }
            Console.WriteLine();
        }
        public void FibonachiSeries(int a)
        {
            int b = 0, c = 1;
            Console.Write("Fibonachi Series : " + b + " ");
            for (int i = 0; i < a; i++)
            {
                c = c + b;
                b = b + c;
                if (c <= a)
                {
                    Console.Write(c + " ");
                }
                if (b <= a)
                {
                    Console.Write(b + " ");
                }
                else
                {
                    a = i;
                }
            }
            Console.WriteLine();
        }
    }
}
