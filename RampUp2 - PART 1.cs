using System;

namespace CSHARP_Ramp_Up_2_PART_1;

class Program
{
    static void Main()
    {
        // PART 1 - POUNDS TO KILOGRAMS
        Console.Write("Weight in Pounds (lbs): ");
        string weightInput = Console.ReadLine(); // reads user's input [string] and stores [weightInput variable].

        if (double.TryParse(weightInput, out double weightInPounds)) // [tryparse] deals w/ the user input, where it may not always be in a valid numeric format. 
        {
            double weightInKilograms = weightInPounds * 0.453592;
            Console.WriteLine($"Weight converted to Kilograms (kg): {weightInKilograms:F2}"); // ($) Interpolated strings provide a concise and readable way to embed expressions within strings.
                                                                                              // also when you want to create string by combining static text with the values of variables.
        }                                                                                     // :F2 formats the output to two decimal places.
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid weight."); // CHECKING IF THE USER INPUT WAS INCORRECT
        }

        Console.WriteLine("========================================"); // used for partioning parts


        // PART 1 - MILES TO KILOMETERS
        Console.Write("Length in Miles (mi): ");
        string lengthInput = Console.ReadLine();

        if (double.TryParse(lengthInput, out double lengthInMiles))
        {
            double lengthInKilometers = lengthInMiles * 1.60934;
            Console.WriteLine($"Length in Kilometers (km): {lengthInKilometers:F2}");
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid len.");
        }


        Console.WriteLine("========================================");


        // PART 1 - FAHRENHEIT TO CELSIUS
        Console.Write("Temperature in Fahrenheit (°F): ");
        string tempInput = Console.ReadLine();

        if (double.TryParse(tempInput, out double tempInFahrenheit))
        {
            double tempInCelsius = (tempInFahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius (°C): {tempInCelsius:F2}");
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid temparature.");
        }

        Console.WriteLine("========================================");


        // PART 1 - STUDENT AGE's AVERAGE


        int numberOfStudents = 10;  //set to 10, indicating the number of students for which you want to collect ages.
        int sumOfAges = 0;          //initialized to 0, and it will be used to calculate the total sum of valid ages.

        for (int i = 1; i <= numberOfStudents; i++) // used to iterate through each student, from 1 to the specified numberOfStudents.
        {
            Console.Write($"Age of Student {i}: "); // ask user to enter the age of each student.
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age) && age >= 0) // [int.TryParse] converts user's input to an integer (age).
                                                                 // If successful ([&&] - returns true) and the age is greater than or equal to 0, the age is considered valid.
            {
                sumOfAges += age; // if the age input is valid, it is added to the running total of ages (sumOfAges)
            }
            else
            {
                Console.WriteLine("INVALLID INPUT. Please enter a valid age.");
            }

            double averageAge = (double)sumOfAges / numberOfStudents;
            Console.WriteLine($"The average age of the students is: {averageAge:F1}"); // :F1 formats the output to one decimal places.
                                                                                       // ($) Interpolated strings provide a concise and readable way to embed expressions within strings.
            Console.WriteLine("========================================");

            // PART 1 - SHORT STORY W/ 5 CHARACTERS
            // CHARACTER INFO.
            string Artifact = "ice-crafted weapons"; // represents various aspects of the characters and their attributes
            string Protagonist = "Lorna Frostblade";
            string Antagonist = "Shadowblade";
            string Weaponry = "icy blades";
            string Ability = "flash";

            // This string used an interpolated string ($"...") where variables are injected into the string using curly braces {}.
            // - The values of those variables will replace the placeholders in the string.
            string story = $"In the desolate wastelands, Captain {Protagonist}, a relentless bounty hunter with {Artifact}, pursued her nemesis, the elusive rogue known only as {Antagonist}. Their bitter rivalry echoed through the abandoned ruins as Captain {Protagonist} closed in, determined to bring justice to the lands. With a {Ability} of {Weaponry}, she cornered {Antagonist}, ending the tale of their enmity in a frozen showdown beneath the pale moonlight.";
            Console.WriteLine(story);
            Console.Read(); //used to keep the console window open until a key is pressed, allowing the user to read the story before the program exits.
        }
    }
}
