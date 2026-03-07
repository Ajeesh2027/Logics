namespace Max_value_in_Repeated_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Values : ");
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int l = a.Length;
            int b = int.MinValue;
            for (int i = 0; i < l; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    if (i < l && a[k] == a[i])
                    {
                        i++;
                        k = -1;
                    }
                }
                for (int j = i+1; j < l; j++)
                {
                    if (a[i] == a[j] && b < a[i])
                    {
                        b = a[i];
                    }
                }
            }
            Console.WriteLine("Answer is : "+b);
        }
    }
}
