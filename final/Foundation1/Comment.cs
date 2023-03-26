using System;
using System.Collections;

class Comment
{
    public string _vidTitle;
    public string _commentor;
    public string _comment;


public Comment()
{

}

public Comment(string title, string commentor, string comment)
{
    _vidTitle = title;
    _commentor = commentor;
    _comment = comment;
}
public string newComment()
{
    Console.WriteLine("Comment by: ");
    _commentor = Console.ReadLine();
    Console.WriteLine("Comment: ");
    _comment = Console.ReadLine();
    return "";
}

}