namespace Logics_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logics logics = new Logics();

            Console.WriteLine("Enter Value : ");
            int a = int.Parse(Console.ReadLine());

            logics.Star1(a);
            logics.SquareStar(a);
            logics.LeftStar(a);
            logics.RightStar(a);
            logics.TriangleStar(a);
            logics.StarLetter(a);
            logics.Series(a);
            logics.AdditionSeries(a);
            logics.OddSeries(a);
            logics.EvenSeries(a);
            logics.FibonachiSeries(a);
        }
    }
}
