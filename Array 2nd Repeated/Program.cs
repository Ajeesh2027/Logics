using System;

namespace Array_2nd_Repeated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name or Number : ");
            string a = Console.ReadLine();

            char[] b = a.ToCharArray();
            int l = b.Length;
            int n = 0;
            int d = 0;

            for (int i = n + 1; i < l - 1; i++)
            {
                for (int j = n + 1; j < l; j++)
                {
                    if (b[n] == b[j])
                    {
                        d = d + 1;
                        l = j;
                        if (d == 2)
                        {
                            Console.WriteLine("2nd Repeated Value is : "+ b[n]);
                        }
                    }
                }
                l = b.Length;
                n = n + 1;
                if (n < l - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (b[j] == b[n] && n < l - 1)
                        {
                            n = n + 1;
                            j = -1;
                        }
                    }
                }

            }
        }
    }
}
