using System;

public class Comment
{
    public string _name;
    public string _text;
    public string _title;
    public List<string> _comments = new List<string>();

    public Comment()
    {

    }

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
    

}