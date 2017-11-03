namespace BinaryFog.Messenger.Send
{
    using Newtonsoft.Json;

    public class ShareButton
    {
        public ShareButton()
        {
            this.Type = "element_share";
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"type: {this.Type}";
        }

    }
}