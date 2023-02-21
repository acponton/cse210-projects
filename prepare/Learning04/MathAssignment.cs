public class MathAssignment : Assignment
{
    // Add the attributes as private member variables. Make sure that you do not 
    // create new member variables for the ones you inherited from the base class.
    private string _textbookSection;
    private string _problems;

    // Create a constructor for your class that accepts all four parameters, have it 
    // call the base class constructor to set the base class attributes that way.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Add the GetHomeworkList() method.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}