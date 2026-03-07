namespace Array_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Swaping

            Console.Write("Enter Array Length : ");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            int l = b.Length;
            for (int i = 0; i < l; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < l; i++)
            {
                l = l - 1;
                if (b[i] != b[l])
                {
                    b[i] = b[i] + b[l];
                    b[l] = b[i] - b[l];
                    b[i] = b[i] - b[l];
                }
            }
            Console.WriteLine("Reverse : ");

            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine(b[j]);
            }

            //2. Creat new array

            //Console.Write("Enter Array Length : ");
            //int a = int.Parse(Console.ReadLine());
            //int[] b = new int[a];
            //int[] c = new int[a];
            //int l = b.Length;
            //for (int i = 0; i < l; i++)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < b.Length; i++)
            //{
            //    l = l - 1;
            //    c[i] = b[l];
            //}

            //Console.WriteLine("Reverse : ");
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}
        }
    }
}
