


public class Assignment
{
    protected string studentName, topic;

    public Assignment(string _studentName, string _topic)
    {
        studentName = _studentName;
        topic = _topic;

    }

    public string GetStudentName()
    {
        return studentName;
    }
    public void SetStudentName(string _studentName)
    {
        studentName = _studentName;
    }


    public string GetTopic()
    {
        return topic;
    }
    public void SetTopic( string _topic)
    {
        topic = _topic;
    }



    public string GetSummary()
    {
        return ($"{studentName} - {topic}");
    }

}