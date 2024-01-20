class PromptGenerator
{
    List<string> prompts = new List<string>
    {
        "What unexpected moment brought a smile to my face today?",
        "Who inspired me with their actions or words today?",
        "In what way did I challenge myself and grow today?",
        "What small act of kindness did I witness or participate in today?",
        "If I could express gratitude to someone today, who would it be and why?",
        "What accomplishment, no matter how small, made me proud today?",
        "How did I find joy in the midst of a busy or challenging day?",
        "What new thing did I learn about myself or the world around me today?",
        "If I could give a piece of advice to my past self based on today's experiences, what would it be?",
        "What moment allowed me to appreciate the beauty in the ordinary today?"
    };
     
    public PromptGenerator()
    {
       
    }


    public string  GetRandomPrompt()
    {
        string randomPrompts = "";
        Random rnd = new Random();
        int randomIndex = rnd.Next(prompts.Count);
        randomPrompts = prompts[randomIndex];
        return  randomPrompts;
    }

}