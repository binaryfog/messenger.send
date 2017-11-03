namespace BinaryFog.Messenger.Send
{
    using Newtonsoft.Json;

    public class GenericTemplateContent
    {
        public GenericTemplateContent()
        {
            this.Title = "This is a title.";
            this.Subtitle = "This is a subtitle.";
            this.ImageUrl = "";
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("buttons")]
        public object[] Buttons { get; set; }
    }
}