using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("2 Nephi", 2, 6, 7);
        Scripture scripture = new Scripture( reference, "Wherefore, redemption cometh in and through the holy Messiah; for he is full of grace and truth. Behold , he offereth himself a sacrifice for sin, to answer the ends of the law, unto all those who have a broken heart and a contrite spirit; and unto none else can the ends of the law be answered. ");
                                            
        
        while (userInput!= "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(" ");
            
            Console.WriteLine("Press Enter to continue or type 'quit' to finish ");
            userInput = Console.ReadLine();

            if(scripture.IsCompletelyHidden())
                break;

            for(int i = 0; i < 3; i++)
            {
                scripture.HideWords();
                if(scripture.IsCompletelyHidden())
                    break;
            }
        }
    }
}