
using System;

namespace Uppgift2.Console
{
    class Program
    {

        /// <summary>
        /// Writes text on the console in given color.
        /// </summary>
        /// <param name="text">A string with the text to write</param>
        /// <param name="color">The color to write the text on</param>
        /// <param name="newLine">If it should include a line terminator after the text</param>
        private static void PrintMessage(string text, ConsoleColor color = ConsoleColor.Green, bool newLine = true)
        {
            System.Console.ForegroundColor = color;
            if (newLine)
            {
                System.Console.WriteLine(text);
            }
            else
            {
                System.Console.Write(text);
            }
        }

        /// <summary>
        /// Retrieves the user input.
        /// </summary>
        /// <param name="prompt">The prompt for the user</param>
        /// <returns>A string containing the user input</returns>
        private static string AskForString(string prompt)
        {
            PrintMessage(prompt, ConsoleColor.Yellow, newLine: false);
            return System.Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var menuTitle = "********** Head Menu **********";
            var center = System.Console.WindowWidth / 2; //The center of the terminal window.
            var menuTitleAlignment = center + menuTitle.Length / 2; //Alignment for menu title
            var menuOptions = "0. Quit\n1: Buy movie tickets\n2. Iterate input ten times\n3. The third word";

            PrintMessage(string.Format($"{{0, {menuTitleAlignment}}}", menuTitle));
            PrintMessage(menuOptions);

            var keepGoing = true;
            do
            {
                var userOption = AskForString("Option: ");

                switch (userOption)
                {
                    case "0":
                        PrintMessage("Bye");
                        keepGoing = false;
                        break;
                    case "1":
                        var numberOfTickets = AskForInt("How many tickets?: ");
                        BuyMovieTickets(numberOfTickets);
                        break;
                    case "2":
                        IterateInputTenTimes();
                        break;
                    case "3":
                        TheThirdWord();
                        break;
                    default:
                        PrintMessage(string.Format("Wrong input: the value {0} is not a valid option", userOption), ConsoleColor.Red);
                        break;
                }
            } while (keepGoing);

            System.Console.ReadKey();
        }

        private static void TheThirdWord()
        {
            throw new NotImplementedException();
        }

        private static void IterateInputTenTimes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asks the age for every ticket to be purchased and prints the total price.
        /// </summary>
        /// <param name="numberOfTickets">The number of ticket to be bought</param>
        private static void BuyMovieTickets(int numberOfTickets = 1)
        {
            double total = 0;
            for (var i = 0; i < numberOfTickets; i++)
            {
                int age = AskForAge($"Age for person {(i + 1)}: ");
                if (age < 20)
                {
                    PrintMessage($"Young adult: {80.ToString("C")}");
                    total += 80;
                }
                else if (age > 64)
                {
                    PrintMessage($"Senior: {90.ToString("C")}");
                    total += 90;
                }
                else
                {
                    PrintMessage($"Standard: {120.ToString("C")}");
                    total += 120;
                }
            }

            PrintMessage($"Number of persons: {numberOfTickets}\nTotal cost: {total.ToString("C")}");
        }

        /// <summary>
        /// Asks for age, continues asking until an integer is given as input.
        /// </summary>
        /// <param name="prompt">The text to show as output</param>
        /// <returns>The given age</returns>
        private static int AskForAge(string prompt)
        {
            while (true)
            {
                try
                {
                    int age = AskForInt(prompt);
                    return age;
                }
                catch (ArgumentException e)
                {
                    PrintMessage(e.Message, ConsoleColor.Red);
                }
            }
        }

        /// <summary>
        /// Prompts a message and converts the given input to an integer. Throws an ArgumentException if value cannot be parsed.
        /// </summary>
        /// <param name="prompt">The message to prompt</param>
        /// <returns>The parsed integer</returns>
        private static int AskForInt(string prompt)
        {
            var response = AskForString(prompt);
            var success = Int32.TryParse(response, out int number);
            if (success)
            {
                return number;
            }

            throw new ArgumentException($"Could not parse {response}", nameof(prompt));
        }
    }
}
