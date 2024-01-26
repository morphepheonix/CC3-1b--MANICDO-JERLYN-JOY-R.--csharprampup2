using System.Reflection;

namespace CSHARP_Ramp_Up_2_PART_2;

class Program
{
    static void Main()
    {
        // PART 2 - 1ST NUMBER PATTERN
        Console.Write("Input: ");
        string one = Console.ReadLine();            // reads the user's input as a string, and it is stored in the variable [one].

        if (int.TryParse(one, out int n) && n > 0)  // [int.TryParse(three, out int t)] attempts to convert the user's input to an integer.
                                                    // && t > 0 checks if the conversion is successful
                                                    // (TryParse returns true) and if the resulting integer is greater than 0.
        {
            for (int i = 1; i <= n; i++)            // [i] - controls the number of rows.
            {
                for (int j = 1; j <= i; j++)        // [j] - Controls the number of columns in each row.
                                                    
                {
                    Console.Write(j);
                    if (j < i)                  // prints the value of j followed by a space(if j is less than i), creating a triangular pattern of numbers.
                        Console.Write(" ");     // Each row is followed by a newline 
                }
                Console.WriteLine();            
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a positive integer."); 
        }
            Console.WriteLine("========================="); 

        // PART 2 - 2ND NUMBER PATTERN
        Console.Write("Input: ");
        string three = Console.ReadLine(); 

        if (int.TryParse(three, out int t) && t > 0) 
        {                                            
            int sum = 0;                             // sum variable accumulates the sum of the numbers.

            Console.Write("Formula: ");
            for (int i = 1; i <= n; i++)             // A for loop iterates from 1 to the entered integer t.

            {
                sum += i;                           // The sum is updated by adding the current value of i.


        // Print the number and the formula
                Console.Write(i);
                if (i < t)                          // If i is less than t, a "+" sign is printed to separate numbers in the formula.
                    Console.Write("+");             // The program prints the formula as it calculates the sum, separating each number with a "+" sign.
                else                                // After printing the formula, the program prints the total sum.
                    Console.Write("\n"); 
                                                    // If i is equal to t, a newline character(\n) is printed to move to the next line after the formula.
            }

            Console.WriteLine("Output: " + sum);    // if the input is valid, the program enters a loop to calculate the sum of numbers up to the entered integer.

        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a positive integer."); 
        }
            Console.WriteLine("========================="); 

        // PART 2 - 3RD NUMBER PATTERN
        Console.Write("Input: ");
        string two = Console.ReadLine();

        if (int.TryParse(two, out int k) && k > 0) 
        {
            for (int i = k; i >= 1; i--)           //  (i) controls the number of rows in descending order.         
                                                   // [--] A DECREMENT-ARITHMETIC OPERATOR* Decreases the value of a variable by 1 *


            {
                for (int j = 1; j <= i; j++)       //  (j) controls the number of columns in each row.
                {
                    Console.Write(j);
                    if (j < i)                     // prints the value of j followed by a space(if j is less than i), creating a descending order.
                        Console.Write(" ");        // Each row is followed by a newline 
                }
                Console.WriteLine();              
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUTt. Please enter a positive integer."); 
        }
            Console.Read(); 
    }
}
