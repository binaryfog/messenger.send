using System;
using Newtonsoft.Json;

namespace BinaryFog.Messenger.Send
{
    public class PostbackButton
    {
        public PostbackButton()
        {
            this.Type = "postback";
            this.Title = "Postback Title";
            this.Payload = "Postback Payload";
        }

        public PostbackButton(string title, string payload)
        {
            this.Type = "postback";
            this.Title = title;
            this.Payload = payload;
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        public override string ToString()
        {
            return $"type: {this.Type}";
        }

    }
}
