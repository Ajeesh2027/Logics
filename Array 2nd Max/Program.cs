namespace Array_2nd_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size : ");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            Console.WriteLine("Enter Values : ");
            for (int i = 0; i < a; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (b[j] < b[j+1])
                    {
                        b[j] = b[j] + b[j+1];
                        b[j + 1] = b[j] - b[j + 1];
                        b[j] = b[j]-b[j+1];
                    }
                }
            }
            Console.WriteLine("2nd Max value is : " + b[1]);
        }
    }
}
