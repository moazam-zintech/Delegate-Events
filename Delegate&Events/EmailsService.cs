public class EmailsService
{
    public void onVideoEncode(object sourse,videoEventArgs args )
    {
        
        Console.WriteLine("This line is for Emails service:" + args.Video2.Video1);
    }
}
