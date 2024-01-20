using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator PromptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Console.WriteLine("You are highly welcome to my Journal Program");
        int menuItems = 0;
        List<string> menu = new List<string>{
            "Please choose from the following choices from 1 to 5 ",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "Please tell me what you would like to do"
        };
        while (menuItems !=5)
        {
            foreach(string items in menu)
            {
                Console.WriteLine(items);
            }
            menuItems = int.Parse(Console.ReadLine());
            switch(menuItems)
            {
                case 1:
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write(">");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("dd MM,yyyy");
                    Entry entry =new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                journal.DisplayAll();
                    break;
                case 3:
                journal.Load();
                    break;
                case 4:
                journal.Save();
                    break;

            }
        }

    }
}