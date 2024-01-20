using System.IO;

class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry( Entry  newEntry )
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }
    public void Save()
    {      
        Console.WriteLine("Enter the filename: ");
        string filename = Console.ReadLine();
        Console.WriteLine(" Saving....... ");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
                {
                    
                    outputFile.WriteLine($"{entry.date}-{entry.promptText}-{entry.entryText}");
                   
                }  
        }
        Console.WriteLine("");
        Console.WriteLine("Your data has been saved");
        Console.WriteLine(" ");
        


    }
    public void Load()
    {
        Console.WriteLine("Enter the file name");
        string filename = Console.ReadLine();
        Console.WriteLine(" Loading....... ");
        List<string> records = File.ReadAllLines(filename).ToList();
        foreach (string record in records)
        {
            string[] newList = record.Split('-');
            Entry entry = new Entry(newList[0], newList[1], newList[2]);
            entries.Add(entry);
        }
        
        Console.WriteLine(" ");
    }


}