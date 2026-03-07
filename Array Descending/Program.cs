namespace Array_Descending
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

            Console.WriteLine("Descending Order : ");
            for (int i = 0;i < b.Length; i++)
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (b[j] < b[j + 1])
                    {
                        b[j] = b[j] + b[j + 1];
                        b[j + 1] = b[j] - b[j + 1];
                        b[j] = b[j] - b[j + 1];
                    }
                }
            }
            for (int i = 0; i < b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
