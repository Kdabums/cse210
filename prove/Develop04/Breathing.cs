class Breathing : Activity
{
    public Breathing()
    {
        name = "Breathing";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void RunActivity()
    {
        StartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in.....");
            Timer(5);
            Console.WriteLine("");
            Console.Write("Breathe out.....");
            Timer(5);
        }
        EndMessage();
    }
}