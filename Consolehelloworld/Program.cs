namespace Consolehelloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "", gender = ""; int height = 0;

            Console.WriteLine("Hey!!!\n");

            while (name.Length < 4)
            {
                Console.Write("Please fill in your full name: ");
                name = Console.ReadLine();
                if (name.Length < 4) Console.WriteLine("Invalid!\n");
            }

            while (gender != "male" && gender != "female")
            {
                Console.Write("Please enter your gender (male/female): ");
                gender = Console.ReadLine().ToLower();
                if (gender != "male" && gender != "female") Console.WriteLine("Invalid!\n");
            }

            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Please enter your height (cm): ");
                Console.WriteLine("Invalid number!\n");
               
            }

            int weight = (gender == "male") ? height - 100 : height - 110;
            Console.WriteLine("\nIdeal weight: " + weight + " kg");
        }
    }
}
