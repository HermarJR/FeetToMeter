internal class Program
{
    private static void Main(string[] args)
    {
        // Convert Feet to Meter Program

        bool repeat = true;
        double feet, meters;

        while (repeat)
        {
            Console.Write("Enter the length of the feet: ");

            try
            {
                feet = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;  // Repeat the loop
            }

            meters = feet * 0.3048;

            Console.WriteLine($"{feet} feet is equal to {meters} meters.");

            Console.WriteLine("Would you like to try again? (Y/N) ");
            string again = Console.ReadLine();
            again = again.ToUpper();

            if (again != "Y")
            {
                repeat = false;
                Console.WriteLine("Thank you! Use it again soon.");
            }
            else
            {
                repeat = true;
            }
        }



        Console.ReadKey();
    }
}