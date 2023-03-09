namespace ImplementEvents
{
    public class MailService
    {
        //Process in subscriber class with execute code to the moment that registers the event.
        public void OnVideoEncoded(object? sender, VideoEncoder.VideoEventArgs videoEventArgs)
        {
            Console.WriteLine($"EmailService: Send Email...{videoEventArgs.Video.Title}");
        }
    }
}