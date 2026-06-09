using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many things as you can.")
    {
        _prompts = new List<string>();
    }

    public void Run()
    {
    }

    public string GetRandomPrompt()
    {
        return "";
    }
}