using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public float _length;
    public List<Comment> _comments;

    //Creates a function that counts the number of comments for each videos.
    public int GetCommentCount()
    {
        return _comments.Count;
    } 
}