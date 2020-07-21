
namespace Uppgift2.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var menuTitle = "********** Head Menu **********";
            var center = System.Console.WindowWidth / 2; //The center of the terminal window.
            var menuTitleAlignment = center + menuTitle.Length / 2; //Alignment for menu title
            var menuOptions = "0. Quit\n1: Buy movie tickets\n2. Iterate input ten times\n3. The third word";

            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine($"{{0, {menuTitleAlignment}}}", menuTitle);
            System.Console.WriteLine(menuOptions);

            string menuOption = System.Console.ReadLine();
        }
    }
}
