using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
    }

    public void DisplayEndingMessage()
    {
    }

    public void ShowSpinner(int seconds)
    {
    }

    public void ShowCountDown(int seconds)
    {
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }
}