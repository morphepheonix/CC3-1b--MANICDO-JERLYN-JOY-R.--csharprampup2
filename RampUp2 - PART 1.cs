namespace CSHARP_Ramp_Up_2_PART_1;

class Program
{
    static void Main()
    {
        // PART 1 - POUNDS TO KILOGRAMS
        Console.Write("Weight in Pounds (lbs): "); // USER INPUT VALUE
        string weightInput = Console.ReadLine(); // USED TO READ NEXT LINE

        if (double.TryParse(weightInput, out double weightInPounds)) // it attempts to convert the user's input to a double.
                                                                     // (tryparse) used when dealing with user input, where the input may not always be in a valid numeric format. 
        {                                                            // If the conversion is successful, the code within the if block is executed.
            double weightInKilograms = weightInPounds * 0.453592; // FORMULA FOR POUNDS TO KILOGRAMS // (*) USED ARITHMETIC OPERATOR 
            Console.WriteLine($"Weight converted to Kilograms (kg): {weightInKilograms:F2}"); // ($) Interpolated strings provide a concise and readable way to embed expressions within strings.
                                                                                              // used when you want to create string by combining static text with the values of variables.
        }                                                                                     // :F2 formats the output to two decimal places.
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid weight."); // CHECKING IF THE USER INPUT WAS INCORRECT
        }

        Console.WriteLine("========================================"); // USED FOR PARTITIONING CONVERSIONS.


        // PART 1 - MILES TO KILOMETERS
        Console.Write("Length in Miles (mi): ");
        string lengthInput = Console.ReadLine();

        if (double.TryParse(lengthInput, out double lengthInMiles))
        {
            double lengthInKilometers = lengthInMiles * 1.60934; // FORMULA FOR MILES TO KILOMETERS // (*) USED ARITHMETIC OPERATOR 
            Console.WriteLine($"Length in Kilometers (km): {lengthInKilometers:F2}");
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid len."); // CHECKING IF THE USER INPUT WAS INCORRECT
        }


        Console.WriteLine("========================================");


        // PART 1 - FAHRENHEIT TO CELSIUS
        Console.Write("Temperature in Fahrenheit (°F): ");
        string tempInput = Console.ReadLine();

        if (double.TryParse(tempInput, out double tempInFahrenheit))
        {
            double tempInCelsius = (tempInFahrenheit - 32) * 5 / 9; // FORMULA FOR FAHRENHEIT TO CELSIUS // (* & /) USED ARITHMETIC OPERATOR 
            Console.WriteLine($"Temperature in Celsius (°C): {tempInCelsius:F2}");
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid temparature."); // CHECKING IF THE USER INPUT WAS INCORRECT
        }

        Console.WriteLine("========================================");


        // PART 1 - STUDENT AGE's AVERAGE


        int numberOfStudents = 10;
        int sumOfAges = 0;

        for (int i = 1; i <= numberOfStudents; i++) // The program uses a for loop to iterate through 10 students 
        {
            Console.Write($"Age of Student {i}: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age) && age >= 0) // [int.TryParse(ageInput, out int age)] attempts to convert the user's input to an integer.
                                                                 // If the conversion is successful (TryParse returns true) and the age is greater than or equal to 0, the age is considered valid.
            {                                                    // (&&) Logical and: Returns True if both statements are true
                sumOfAges += age; // if the age input is valid, it is added to the running total of ages (sumOfAges)
            }
            else
            {
                Console.WriteLine("INVALLID INPUT. Please enter a valid age."); // CHECKING IF THE USER INPUT WAS INCORRECT
            }

        }


        double averageAge = (double)sumOfAges / numberOfStudents; // FORMULA FOR GETTING THE STUDENTS AGE AVERAGE // (+ & /) USED ARITHMETIC OPERATOR 
        Console.WriteLine($"The average age of the students is: {averageAge:F1}");

        Console.WriteLine("========================================");

        // PART 1 - SHORT STORY W/ 5 CHARACTERS
        // CHARACTER INFO.
        string Artifact = "ice-crafted weapons"; // Artifact, Protagonist, Antagonist, Weaponry, and Ability are strings representing various aspects of the characters and their attributes
        string Protagonist = "Lorna Frostblade";
        string Antagonist = "Shadowblade";
        string Weaponry = "icy blades";
        string Ability = "flash";

        //The story string is composed using an interpolated string ($@"...") where variables are injected into the string using curly braces {}.
        string story = $@"In the desolate wastelands, Captain {Protagonist}, a relentless bounty hunter with {Artifact}, pursued her nemesis, the elusive rogue known only as {Antagonist}. Their bitter rivalry echoed through the abandoned ruins as Captain {Protagonist} closed in, determined to bring justice to the lands. With a {Ability} of {Weaponry}, she cornered {Antagonist}, ending the tale of their enmity in a frozen showdown beneath the pale moonlight.";
        Console.WriteLine(story);
        Console.Read(); //used to keep the console window open until a key is pressed, allowing the user to read the story before the program exits.
    }
}
