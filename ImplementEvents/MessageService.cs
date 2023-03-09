namespace ImplementEvents
{
    public class MessageService
    {
        //Process in subscriber class with execute code to the moment that registers the event.
        public void OnVideoEncoded(object? sender, VideoEncoder.VideoEventArgs videoEventArgs)
        {
            Console.WriteLine($"MessageService: Send Message...{videoEventArgs.Video.Title}");
        }
    }
}