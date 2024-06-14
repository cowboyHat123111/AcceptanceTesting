namespace Find_the_odd_int
{
    internal class Program
    {
        public static int find_it(int[] seq) => seq.Where(c => seq.Where(x => x == c).Count() % 2 == 1).FirstOrDefault();

        static void Main(string[] args)
        {
            Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}