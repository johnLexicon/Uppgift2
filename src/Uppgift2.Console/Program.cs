
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
                        BuyMovieTickets();
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

        private static void BuyMovieTickets()
        {
            throw new NotImplementedException();
        }
    }
}
