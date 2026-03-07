namespace Array_String_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string a = Console.ReadLine();
            char[] b = a.ToCharArray();
            int l = b.Length;
            char[] c = new char[l];

            int n = 0;
            for (int i = l - 1; i >= 0; i--)
            {
                c[n] = b[i];
                n = n + 1;
            }

            n = 0;
            for (int i = 0; i < l; i++)
            {
                if (b[i] == c[i])
                {
                    n=n+1;
                }
            }
            if (n == b.Length)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Not Success");
            }
        }
    }
}
