class Listing : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };
    private List<int> promptsIndexes = new List<int>();



    public void RunActivity()
    {
        StartMessage();
        int count = 0;
        int index;
        do
        {
            index = rnd.Next(prompts.Count);
        }
        while (promptsIndexes.Contains(index));

        promptsIndexes.Add(index);
        if (promptsIndexes.Count == prompts.Count)
            promptsIndexes.Clear();
        Console.WriteLine("List as many response as you can to the following prompt :");
        Console.WriteLine(prompts[index]);
        Console.WriteLine("You may begin in:");
        Timer(5);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string userIput = Console.ReadLine();
            count  ++;

        }

        Console.WriteLine($" You listed {count} Items");
        EndMessage();
    }
}