namespace Array_Not_Repeated
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
            Console.WriteLine("Not Repeated Values : ");

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if ( i==j || b[i] != b[j])
                    {
                        d = d + 1;
                    }
                    else
                    {
                        j = l;

                    }
                }
                if (d==l)
                {
                    Console.Write(" "+ b[i]);
                }
                d= 0;
                l = b.Length;
                n = n + 1;
                if (n < l)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (n < l)
                        {
                            if (b[j] == b[n])
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
}
