namespace CSHARP_Ramp_Up_2_PART_2;

class Program
{
    static void Main()
    {
        // PART 2 - 1ST NUMBER PATTERN
        Console.Write("Input: ");
        string one = Console.ReadLine();

        if (int.TryParse(one, out int n) && n > 0) //[&&] A BOOLEAN- LOGICAL OPERATOR *Returns True if both statements are true*
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++) //[++] A INCREMENT- ARITHMETIC OPERATOR *Increases the value of a variable by 1*
                {
                    Console.Write(j);
                    if (j < i)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a positive integer."); //ERROR HANDLING, WOULD OCCUR WHEN THE USER's INPUT WAS INCORRECT [O AND NONPOSITIVE INTEGERS WILL BE INCORRECT)
        }
        Console.WriteLine("========================="); //USED FOR SEPARATING NUMBER PATTERNS

        // PART 2 - 2ND NUMBER PATTERN
        Console.Write("Input: ");
        string three = Console.ReadLine();

        if (int.TryParse(three, out int t) && t > 0) //[&&] A BOOLEAN- LOGICAL OPERATOR *Returns True if both statements are true*
        {
            int sum = 0;

            Console.Write("Formula: ");
            for (int i = 1; i <= n; i++) //[++] A INCREMENT- ARITHMETIC OPERATOR *Increases the value of a variable by 1*

            {
                sum += i;

                // Print the number and the formula
                Console.Write(i);
                if (i < t)
                    Console.Write("+");
                else
                    Console.Write("\n");
            }

            Console.WriteLine("Output: " + sum);

        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a positive integer."); //ERROR HANDLING, WOULD OCCUR WHEN THE USER's INPUT WAS INCORRECT [O AND NONPOSITIVE INTEGERS WILL BE INCORRECT)

        }
        Console.WriteLine("========================="); //USED FOR SEPARATING NUMBER PATTERNS

        // PART 2 - 3RD NUMBER PATTERN
        Console.Write("Input: ");
        string two = Console.ReadLine();

        if (int.TryParse(two, out int k) && k > 0)
        {
            for (int i = k; i >= 1; i--) // [--] A DECREMENT-ARITHMETIC OPERATOR* Decreases the value of a variable by 1 *


            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    if (j < i)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUTt. Please enter a positive integer."); //ERROR HANDLING, WOULD OCCUR WHEN THE USER's INPUT WAS INCORRECT [O AND NONPOSITIVE INTEGERS WILL BE INCORRECT)
        }
        Console.ReadLine();
    }
}


