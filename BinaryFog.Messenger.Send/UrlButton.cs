using System;
using Newtonsoft.Json;

namespace BinaryFog.Messenger.Send
{
    public class UrlButton
    {
        public UrlButton()
        {
            this.Type = "web_url";
            this.Title = "Url Title";
            this.Url = "Url";
        }

        public UrlButton(string title, string url)
        {
            this.Type = "postback";
            this.Title = title;
            this.Url = url;
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return $"type: {this.Type}";
        }

    }
}
