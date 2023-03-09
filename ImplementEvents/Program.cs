namespace ImplementEvents
{
    internal abstract class Program
    {
        private static void Main(string[] arg)
        {
            IVideoEncoder videoEncoder = new VideoEncoder(); //Event Publisher
            var video = new Video() { Title = "The Killer" }; 
            
            var mailService = new MailService(); // Event Subscriber
            var messageService = new MessageService(); // Event Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Activating Subscription
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // Activating Subscription
            
            videoEncoder.Encode(video);
        }
    }
}
 