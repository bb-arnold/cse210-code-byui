using System;
using System.Dynamic;

class Assignment
{
    public Assignment (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    private string _studentName = "";
    private string _topic = "";

    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}