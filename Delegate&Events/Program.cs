
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
class Program
{
    public static void Main(string[] args)
    {
        MessageService messageService = new MessageService();
        EmailsService emailsService = new EmailsService();
        VideoEncoder videoEncoder = new VideoEncoder();
        Video video = new Video();
        video.Video1 = "Video 123";
        videoEncoder.videoEncoded +=messageService.onVideoEncode;
        videoEncoder.videoEncoded += emailsService.onVideoEncode;

        videoEncoder.Encode(video);
    }
}
