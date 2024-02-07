

public class MathAssignment : Assignment
{
    private string textBookSection;
    private string problems;

    
    public MathAssignment (string studentName,  string topic,string _textBookSection, string _problems) : base (studentName, topic)
    {
        textBookSection = _textBookSection;
        problems = _problems;
    }
    

     public string GetTextBookSection()
    {
        return textBookSection ;
    }
    public void SetTextBookSection(string _textBookSection)
    {
        textBookSection = _textBookSection ;
    }
     public string GetProblems()
    {
        return problems;
    }
      public void SetProblems(string _problems)
    {
        problems = _problems;
    }

                                                                                                                
    public string GetHomeWorkList()
    {
        return ($"{textBookSection} {problems}");
    }
}