namespace Static_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls the executes each method in the Calculate class with integer values.
            Console.WriteLine("Integer Methods");
            Console.WriteLine("5 + 10 = " + Calculate.Add(5, 10));
            Console.WriteLine("4 - 9 = " + Calculate.Subtract(4, 9)); 
            Console.WriteLine("12 * 7 = " + Calculate.Multiply(12, 7)); 
            Console.WriteLine("3 / 8 = " + Calculate.Divide(3, 8));

            // Calls the executes each method in the Calculate class with float values.
            Console.WriteLine("\nFloat methods");
            Console.WriteLine("5.65 + 10.732 = " + Calculate.Add(5.65f, 10.732f));
            Console.WriteLine("4.9 - 9.25 = " + Calculate.Subtract(4.9f, 9.25f));
            Console.WriteLine("12.82 * 7.19 = " + Calculate.Multiply(12.82f, 7.19f));
            Console.WriteLine("3.003 / 8.59 = " + Calculate.Divide(3.003f, 8.59f));
        }
    }
}
