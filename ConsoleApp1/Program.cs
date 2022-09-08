namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine(number1);
            if (number1 <= 10 && number1 >= 1)
            {
                Console.WriteLine("valid");
            } else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}