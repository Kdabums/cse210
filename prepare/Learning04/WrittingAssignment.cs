

public class WrittingAssignment : Assignment
{
    private string title;
     public  WrittingAssignment (string studentName,  string topic, string _title) : base (studentName, topic)
    {
        title = _title;
    }
    public string GetTitle()
    {
        return title ;
    }
     public void SetTitle(string _title)
    {
        title = _title;
    }



    public string GetWrittingInformation()
    {
        return($"{title}  By {studentName}");
    }
}