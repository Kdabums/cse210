public class Reference
{
    private int chapter,  verse, endVerse;
    private string book;

    public Reference(string _book, int _chapter, int _verse)
    {
        book    =_book;
        chapter = _chapter;
        verse   = _verse;
    }
    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        book     =_book;
        chapter  = _chapter;
        verse    = _startVerse;
        endVerse = _endVerse;
    }
    public string GetDisplayText()
    {
        string referenceToDisplay = "";

        if (endVerse != 0)
        {
            referenceToDisplay = $"{book} {chapter}:{verse}-{endVerse}";
        }
        else
        {
            referenceToDisplay = $"{book} {chapter}:{verse}";
        } 
        return referenceToDisplay;
    }
}