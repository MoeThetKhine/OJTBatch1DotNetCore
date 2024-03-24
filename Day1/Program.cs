public class Program
{
 

    public static void Main(string[] args)
    {
        
        /* Program 1 for break and continue */
       
        /*
        Console.WriteLine("Example 1: Using break statement");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Encountered 6. Exiting loop...");
                break;
            }
            Console.WriteLine(i);
        }

       
        Console.WriteLine("\nExample 2: Using continue statement");
        for (int j = 1; j <= 10; j++)
        {
            if (j % 2 == 1)
            {
                // Skip even numbers
                continue;
            }
            Console.WriteLine(j);
        }

        Console.ReadLine();

        */
        /* Program 2 for break and continue */

        int sum = 0;

        Console.WriteLine("Enter a positive sequence of numbers (0 to stop):");

        while (true)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                break; // exit the loop if 0 is entered
            }
            else if (number < 0)
            {
                continue; // skip negative numbers
            }

            sum += number; // add positive numbers to the sum
        }

        Console.WriteLine($"The sum of positive numbers entered is: {sum}");

    }
}
