namespace ImplementEvents;

public interface IVideoEncoder
{
    // This uses a Generic Handler
    public event EventHandler<VideoEncoder.VideoEventArgs> VideoEncoded;
    
    // This uses an Explicit delegate
    // public event VideoEncoder.VideoEncodedEventHandler VideoEncoded;
    public void Encode(Video video);
    
}