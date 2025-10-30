using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();

    public Video()
    {
        _title = "unknow";
        _author = "Anonymous";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void SetVideoComment(string name, string comment)
    {
        Comment commentary = new Comment(name, comment);
        comments.Add(commentary);
    }
    
    public void displayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {comments.Count()}");
        Console.WriteLine($"Comments:");
        foreach (Comment comment in comments)
        {
            comment.displayComment();
        }
    }
}