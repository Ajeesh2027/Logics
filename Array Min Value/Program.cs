namespace Array_Min_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Length : ");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            int c = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < c)
                {
                    c = b[i];
                }
            }
            Console.WriteLine("Min Value is " + c);
        }
    }
}
