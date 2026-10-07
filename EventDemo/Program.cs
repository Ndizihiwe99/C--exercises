using System;
class Channel
{
    public event Action? NewVideo;
    

    public void uploadVideo()
    {
        Console.WriteLine("I am uploading a channel video");
        NewVideo?.Invoke();
    }
}

public class program
{
    static void Main (string[] args)
    {
        Channel channel = new Channel();
        channel.NewVideo += () => Console.WriteLine("I will subscribe");
        channel.NewVideo += () => Console.WriteLine("I will Like the video");
        channel.uploadVideo();
    }
}