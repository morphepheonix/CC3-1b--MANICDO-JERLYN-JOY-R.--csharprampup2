namespace CSHARP_Ramp_Up_2_PART_2;

class Program
{
    static void Main()
    {
        // PART 2 - 1ST NUMBER PATTERN
        Console.Write("Input: ");
        string one = Console.ReadLine();            // reads the user's input as a string, and it is stored in the variable [one].

        if (int.TryParse(one, out int n) && n > 0) // attempts to convert the user's input to an integer.
                                                   //[&&] A BOOLEAN- LOGICAL OPERATOR *Returns True if both statements are true*
        {
            for (int i = 1; i <= n; i++)        // OUTER LOOP - controls the number of rows.
            {
                for (int j = 1; j <= i; j++)    // INNER LOOP - Controls the number of columns in each row.
                                                // [++] A INCREMENT- ARITHMETIC OPERATOR *Increases the value of a variable by 1*
                {
                    Console.Write(j);
                    if (j < i)
                        Console.Write(" ");     // Each row is followed by a newline 
                }
                Console.WriteLine();            // if the input is valid, the program enters a nested loop structure to print a pattern of numbers.
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a positive integer."); //ERROR HANDLING, WOULD OCCUR WHEN THE USER's INPUT WAS INCORRECT [O AND NONPOSITIVE INTEGERS WILL BE INCORRECT)
        }
        Console.WriteLine("========================="); //USED FOR SEPARATING NUMBER PATTERNS

        // PART 2 - 2ND NUMBER PATTERN
        Console.Write("Input: ");
        string three = Console.ReadLine(); // reads the user's input as a string, and it is stored in the variable [three].

        if (int.TryParse(three, out int t) && t > 0) //[int.TryParse(three, out int t)] attempts to convert the user's input to an integer.
        {                                            //&& t > 0 condition checks if the conversion is successful (TryParse returns true) and if the resulting integer is greater than 0.
            int sum = 0; // sum variable accumulates the sum of the numbers.

            Console.Write("Formula: ");
            for (int i = 1; i <= n; i++) // a block of code that will repeat itself over and over again until a given condition is true

            {
                sum += i;

                // Print the number and the formula
                Console.Write(i);
                if (i < t)
                    Console.Write("+"); // The program prints the formula as it calculates the sum, separating each number with a "+" sign.
                else                    // After printing the formula, the program prints the total sum.
                    Console.Write("\n");
            }

            Console.WriteLine("Output: " + sum); // if the input is valid, the program enters a loop to calculate the sum of numbers up to the entered integer.

        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a positive integer."); //ERROR HANDLING, WOULD OCCUR WHEN THE USER's INPUT WAS INCORRECT [O AND NONPOSITIVE INTEGERS WILL BE INCORRECT)

        }
        Console.WriteLine("========================="); //USED FOR SEPARATING NUMBER PATTERNS

        // PART 2 - 3RD NUMBER PATTERN
        Console.Write("Input: ");
        string two = Console.ReadLine(); //reads the user's input as a string, and it is stored in the variable two.

        if (int.TryParse(two, out int k) && k > 0) // [tryparse] attempts to convert the user's input to an integer.
                                                   // [&& k > 0] condition checks if the conversion is successful (TryParse returns true) and if the resulting integer is greater than 0.
        {
            for (int i = k; i >= 1; i--)           // controls the number of rows.          
                                                   // [--] A DECREMENT-ARITHMETIC OPERATOR* Decreases the value of a variable by 1 *


            {
                for (int j = 1; j <= i; j++)       // controls the number of columns in each row.
                {
                    Console.Write(j);
                    if (j < i)
                        Console.Write(" ");        // Numbers are printed, and a space is added between them unless it's the last number in a row.
                }
                Console.WriteLine()                // If the input is valid, the program enters a nested loop structure to print a pattern of numbers in descending order.
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUTt. Please enter a positive integer."); //ERROR HANDLING, WOULD OCCUR WHEN THE USER's INPUT WAS INCORRECT [O AND NONPOSITIVE INTEGERS WILL BE INCORRECT)
        }
        Console.ReadLine();
    }
}
