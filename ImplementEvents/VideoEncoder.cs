namespace ImplementEvents
{
    public sealed class VideoEncoder : IVideoEncoder
    {
        public class VideoEventArgs : EventArgs
        {
            public VideoEventArgs(Video video)
            {
                Video = video;
            }

            public Video Video { get; set; }
        }
        
        // This uses an Explicit delegate
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // public event VideoEncodedEventHandler? VideoEncoded;

        // This uses a Generic Handler
        public event EventHandler<VideoEventArgs>? VideoEncoded; 

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding Video...{video.Title}");
            Thread.Sleep(3000);
            OnVideoEncoded(video); // Raise the Event
        }

        private void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs(video));
        }
    }
}