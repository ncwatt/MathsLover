class Menu
{

    public static void SelectChallenge()
    {
        

        bool redraw = true;
        bool exit = false;

        while (exit == false)
        {
            if (redraw == true)
            {
                Console.Clear();
                Console.WriteLine("Hi Jack! Welcome to Maths Lover.\n");
                Console.WriteLine("Please select a challenge:\n");
                Console.WriteLine("  1. Times Tables");
                Console.WriteLine("  X. Exit\n");
                redraw = false;
            }

            Console.Write("Enter a value: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Menu.TimesTables();
                    redraw = true;
                    break;
                case "X" or "x":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("The value you entered is invalid. Please try again.\n");
                    break;
            }
        }
    }

    public static void TimesTables()
    {
        bool redraw = true;
        bool exit = false;

        while (exit == false)
        {
            if (redraw == true)
            {
                Console.Clear();
                Console.WriteLine("Times Table Challenge\n");
                Console.WriteLine("Please select which times table you want to test:\n");
                Console.WriteLine("  1. \"1\" times table");
                Console.WriteLine("  2. \"2\" times table");
                Console.WriteLine("  3. \"3\" times table");
                Console.WriteLine("  4. \"4\" times table");
                Console.WriteLine("  5. \"5\" times table");
                Console.WriteLine("  6. \"6\" times table");
                Console.WriteLine("  7. \"7\" times table");
                Console.WriteLine("  8. \"8\" times table");
                Console.WriteLine("  9. \"9\" times table");
                Console.WriteLine("  10. \"10\" times table");
                Console.WriteLine("  11. \"11\" times table");
                Console.WriteLine("  12. \"11\" times table");
                Console.WriteLine("  R. Return to main menu\n");
                redraw = false;
            }

            Console.Write("Enter a value: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    redraw = true;
                    break;
                case "R" or "r":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("The value you entered is invalid. Please try again.\n");
                    break;
            }
        }
    }

}