namespace BinaryFog.Messenger.Send
{
    using Newtonsoft.Json;

    public class ChannelData
    {
        [JsonProperty("attachment")]
        public Attachment Attachment
        {
            get;
            set;
        }
    }
}