public class MessageService
{
    public void onVideoEncode(object obj,videoEventArgs video)
    {
        Console.WriteLine("This line is for message service:" + video.Video2.Video1);
    }
}
