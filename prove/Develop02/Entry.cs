using System;
using System.Collections.Generic;

public class Entry 
{

    public string _date;
    
    // List<string> _entries = new List<string>();

    public string SetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();

        return _date;
    }

}