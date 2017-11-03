namespace BinaryFog.Messenger.Send
{ 
    using Newtonsoft.Json;

    public class ListTemplate
    {
        public ListTemplate()
        {
            this.TemplateType = "list";
        }

        [JsonProperty("template_type")]
        public string TemplateType { get; set; }

        [JsonProperty("top_element_style")]
        public string TopElementStyle { get; set; }

        [JsonProperty("elements")]
        public object[] Elements { get; set; }
    }
}