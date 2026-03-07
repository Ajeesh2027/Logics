namespace Array_Repeted_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name or Number : ");
            string a = Console.ReadLine();

            char [] b = a.ToCharArray();
            int l = b.Length;
            int n = 0;
            Console.WriteLine("Repeated Values are : ");

            for (int i = n+1; i < l; i++)
            {
                for (int j = n+1; j < l; j++)
                {
                    if (b[n] == b[j])
                    {
                        Console.Write(" "+ b[n]);
                        l = j;
                    }  
                }
                l = b.Length;
                n = n + 1;
                if (n<l-1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (b[j] == b[n] && n<l-1)
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
