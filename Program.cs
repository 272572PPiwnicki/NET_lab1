namespace NET_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get data from the user
            Console.WriteLine("enter number of items: ");
            int numberOfItems = int.Parse(Console.ReadLine());

            Console.WriteLine("enter seed: ");
            int seed = int.Parse(Console.ReadLine());

            Console.WriteLine("enter capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            // generate instance
            Problem problem = new Problem(numberOfItems, seed);
            Console.WriteLine("\ngenerated items: ");
            Console.WriteLine(problem);

            // solve problem
            Result result = problem.Solve(capacity);

            // display
            Console.WriteLine("\nselection: ");
            Console.WriteLine(result);
        }
    }
}
