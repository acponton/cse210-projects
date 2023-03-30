using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    public List<Comment> _comments = new List<Comment>();
    public List<Video> _videos = new List<Video>();


    public Video()
    {

    }

    public void DisplayVideosDetails()
    {
        Console.WriteLine($"'{_title}' ({_lengthSeconds} seconds) - {_author}");
        GetNumberComments();
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentDetails();
        }
    }


    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideosDetails();
        }
    }


    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentDetails();
        }
    }


    public void GetNumberComments()
    {
        Console.WriteLine($"{_comments.Count} comments."); 
    }

}