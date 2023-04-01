using System;

public class Event
{

    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;


    public Event()
    {

    }

    Address address = new Address();

    public string GetStandardDetails()
    {
        string _fullAddress = address.GetAddress();
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date} - Time: {_time}");
        Console.WriteLine($"Address: {_fullAddress}");
    }


}