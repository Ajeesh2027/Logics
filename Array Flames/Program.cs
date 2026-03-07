namespace Array_Flames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________New Flames___________________");
            Console.WriteLine("Enter name 1 : ");
            string a = Console.ReadLine().ToLower();
            char[] b = a.ToCharArray();

            Console.WriteLine("Enter name 2 : ");
            string c = Console.ReadLine().ToLower();
            char[] d = c.ToCharArray();

            int sameWordCount = 0;
            int length = b.Length + d.Length;
            char[] check = new char[length];

            for (int i = 0; i < b.Length; i++)
            {
                if(!check.Contains(b[i]))
                {
                    int count = 0;
                    for (int j = 0; j < d.Length; j++)
                    {
                        if (b[i] == d[j])
                        {
                            count = count + 1;
                            if (count == 1)
                            {
                                sameWordCount = sameWordCount + 2;
                            }
                            else
                            {
                                sameWordCount = sameWordCount + 1;
                            }
                        }
                    }
                    check[i] = b[i];
                }
                else if (check.Contains(b[i]) && d.Contains(b[i]))
                {
                    sameWordCount = sameWordCount + 1;
                }
            }
            var remaining = length - sameWordCount;
            char[] g = { 'F', 'L', 'A', 'M', 'E', 'S' };
            char[] delete= new char[5];
            var k = 0;
            var counts = 0;
            for (int i = 0; i<g.Length; i++)
            {
                if (delete.Contains(g[i]))
                {
                    if (i == g.Length - 1)
                    {
                        i = -1;
                        continue;
                    }
                }
                else
                {
                    counts++;

                    if (k == g.Length - 1 && counts == remaining)
                    {
                        Console.WriteLine("FLAMES Result is : " + g[i]);
                        Console.WriteLine("______________________________");
                        Main(args);
                    }
                    else if (counts == remaining)
                    {
                        delete[k] = g[i];
                        k++;
                        counts = 0;
                    }
                }
                if (i == g.Length-1)
                {
                    i=-1;
                }
            }
        }
    }
}
