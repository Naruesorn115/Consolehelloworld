namespace Consolehelloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.Write("Please, input you full name (eng) :");
            name = Console.ReadLine();

            Console.WriteLine("Hello, World!" + name);

            Console.WriteLine("please fill in you height(cm) :");
            height = Convert.ToInt16(Console.ReadLine());
            int weight = height - 100;

            Console.WriteLine("You ideal weight is " + weight.ToString());

            Console.WriteLine();
            Console.WriteLine("press any key to end program");
        }
    }
}
