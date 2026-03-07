namespace Array_Ascending
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

            Console.WriteLine("Ascending Order : ");
            for (int j = 0; j < b.Length; j++)
            {
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        b[i] = b[i] + b[i + 1];
                        b[i + 1] = b[i] - b[i + 1];
                        b[i] = b[i] - b[i + 1];
                    }
                }       
            }
            for (int i = 0;i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
