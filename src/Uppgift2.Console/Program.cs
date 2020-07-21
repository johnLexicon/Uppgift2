
using System;

namespace Uppgift2.Console
{
    class Program
    {

        /// <summary>
        /// Changes the foreground color in the terminal
        /// </summary>
        /// <param name="color">The color to change to</param>
        private static void ChangeForeGroundColor(ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
        }

        /// <summary>
        /// Retrieves the user input.
        /// </summary>
        /// <param name="prompt">The prompt for the user</param>
        /// <returns>A string containing the user input</returns>
        private static string AskForString(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine();
        }

        static void Main(string[] args)
        {
            ChangeForeGroundColor(ConsoleColor.Green);

            var menuTitle = "********** Head Menu **********";
            var center = System.Console.WindowWidth / 2; //The center of the terminal window.
            var menuTitleAlignment = center + menuTitle.Length / 2; //Alignment for menu title
            var menuOptions = "0. Quit\n1: Buy movie tickets\n2. Iterate input ten times\n3. The third word";

            System.Console.WriteLine($"{{0, {menuTitleAlignment}}}", menuTitle);
            System.Console.WriteLine(menuOptions);

            var keepGoing = true;

            do
            {
                ChangeForeGroundColor(ConsoleColor.Yellow);
                var userOption = AskForString("Option: ");
                ChangeForeGroundColor(ConsoleColor.Green);

                switch (userOption)
                {
                    case "0":
                        System.Console.WriteLine("You chose to quit the application");
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
                        ChangeForeGroundColor(ConsoleColor.Red);
                        System.Console.WriteLine("Wrong input: the value {0} is not a valid option", userOption);
                        ChangeForeGroundColor(ConsoleColor.Green);
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
