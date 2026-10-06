using System;

class MathAssignment : Assignment
{
    string _problems = "";
    string _textBookSection = "";
    public MathAssignment(string studentName, string topic, string textBookSecton, string problems) : base(studentName, topic)
    {
        _problems = problems;
        _textBookSection = textBookSecton;
    }

    public string GetHomeworkList()
    {
        return $"{_textBookSection} {_problems}";
    }
}