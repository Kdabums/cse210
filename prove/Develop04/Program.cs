using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing();
        Listing listing = new Listing();
        Reflecting reflecting = new Reflecting();
        List<string> menu = new List<string>
        {
            "Menu Option",  
            "   1. Start Breathing   Activity",
            "   2. Sart  Reflecting  Activity",
            "   3. Start Listing     Activity",
            "   4. Quit",
            "Select a choice from the menu"
        };
        int userInput = 0;

        while (userInput!= 4)
        {
             foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                
                case 1:
                    breathing.RunActivity();
                    break;
                case 2:
                    reflecting.RunActivity();
                    break;
                case 3:
                    listing.RunActivity();
                    break;

            }

        }
    }
}