namespace BinaryFog.Messenger.Send
{
    using Newtonsoft.Json;

    public class Attachment
    {
        public Attachment()
        {
            this.Type = "template";
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("payload")]
        public dynamic Payload { get; set; }

        //make sure ToString converts the payload
        public override string ToString()
        {
            return this.Payload.ToString();
        }
    }
}