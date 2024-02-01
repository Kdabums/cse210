class Reflecting : Activity
{
    private List<string> prompts  = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

    };
    private List<int> promptsIndexes = new List<int>();
    private List<int> questionIndexes = new List<int>();
    private List<string> questions  = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflecting()
    {
        name = "Reflecting";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    }

    public void  RunActivity()
    {
        StartMessage();
        Console.WriteLine("Consider The Following Prompt:");
        int index;
        do
        {
            index = rnd.Next(prompts.Count);
        }
        while(promptsIndexes.Contains(index));

        promptsIndexes.Add(index);
        if (promptsIndexes.Count == prompts.Count)
            promptsIndexes.Clear();

        Console.WriteLine(prompts[index]);
        Console.WriteLine("When you have something in mind press enter to continue");
        string userInput = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience");
        Console.WriteLine("You may begin in:");
        Timer(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(duration);        
        while (DateTime.Now < endTime)
        {
            do
            {
                index = rnd.Next(questions.Count);
            } 
            while (questionIndexes.Contains(index));
            questionIndexes.Add(index);
            if (questionIndexes.Count == questions.Count)
            {
                questionIndexes.Clear();
            }
            
            Console.WriteLine(questions[index]);
            Spinner(10);
        }
        EndMessage();
    }
}