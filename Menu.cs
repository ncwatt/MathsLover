class Menu
{

    public static void SelectChallenge()
    {
        Console.Clear();
        Console.WriteLine("Hi Jack! Welcome to Maths Lover.\n");
        Console.WriteLine("Please select a challenge:\n");
        Console.WriteLine("  1. Times Tables");
        Console.WriteLine("  X. Exit\n");

        bool exit = false;

        while (exit == false)
        {
            Console.Write("Enter a value: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
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

    

}