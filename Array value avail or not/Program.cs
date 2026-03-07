namespace Array_value_avail_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value : ");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[6];
            b[0] = 10;b[1] = 40;b[2] = 60;
            b[3] = 70;b[4] = 67;b[5] = 90;
            int l = b.Length;
            int i;
            for (i = 0; i < l; i++)
            {
                if (b[i] == a)
                {
                    l = i;
                    Console.WriteLine("Value is available");
                }
                else if (i == l - 1)
                {
                    Console.WriteLine("Value is not available");
                }
            }
        }
    }
}
