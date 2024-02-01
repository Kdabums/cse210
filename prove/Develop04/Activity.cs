class Activity
{
    protected string name, description;
    protected int duration ;
    protected Random rnd = new Random();
    private List<char> spinner = new List<char>(){'\\', '|', '-', '/'};

    public Activity(){}
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {name} Activity\n ");
        Console.WriteLine($"{description}");
        Console.WriteLine("How long in seconds would you like your session");
        duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready......");
        Spinner(5);
        

    }
    public void EndMessage()
    {
        Console.WriteLine($"Well Done !!");
        Spinner(3);
        Console.WriteLine($"You have completed {duration} secconds of the {name}activity");
        Spinner(3);
    }
    public void Timer(int _duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(_duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _duration--;
        }
    }
    public void Spinner(int _duration )
    {

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            foreach ( char ch in spinner)
            {
                Console.Write(ch);
                Thread.Sleep(250);
                Console.Write("\b \b");
           
            }
            
        }
    }



}