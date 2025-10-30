using System;

class Comment
{
    private string _person;
    private string _commentary;

    public Comment()
    {
        _person = "Anonymous";
        _commentary = "...";
    }

    public Comment(string person, string commentary)
    {
        _person = person;
        _commentary = commentary;
    }
    
    public void displayComment()
    {
        Console.WriteLine($"{_person}: ");
        Console.WriteLine($"Comment: {_commentary}"); 
    }
}