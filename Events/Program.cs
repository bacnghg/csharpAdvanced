namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailServices = new MailService(); //subscriber
            var messageService = new MessageService(); // subscriber

            //videoEncoder.VideoEncoded += mailServices.OnVideoEncoded(video);
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}