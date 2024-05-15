public class VideoEncoder
{
/*First Step*/

    public delegate void VideoEncodedEventHandler(object source, videoEventArgs args);
/*2nd Step*/
    public event VideoEncodedEventHandler videoEncoded;

    public void Encode(Video video)
    {
       /* MessageService messageService = new MessageService();
        messageService.MessageService1(video);
        EmailsService emailsService = new EmailsService();
        emailsService.MessageService1(video);*/

        /*3rd Invoke the message to subscriber Step*/
        onVideoEncode(video);
    }

    protected virtual void onVideoEncode(Video video)
    {
        if(videoEncoded!=null)
        {
            videoEncoded(this,new videoEventArgs() { Video2 = video});
        }
    }

}
