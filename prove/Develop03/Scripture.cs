public class Scripture
{
    Random random = new Random();
    private Reference reference;
    private List<Word> words;

    public  Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();
        List<string> allWords = _text.Split(' ').ToList();
        foreach (string slpitWord in allWords)
        {
            Word wordList = new Word(slpitWord);
            words.Add(wordList);
        }
    }
    

    public  void HideWords()
    {
        int index;
        do
        {
            index = random.Next(words.Count);            
        } while (words[index].GetIsHidden());
        words[index].Hide();
    }
    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }


        }

        return ($"{reference.GetDisplayText()} {scriptureText}") ;
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in words)
        {
            if(!word.GetIsHidden())
                return false;
        }
        return true;
    }

}