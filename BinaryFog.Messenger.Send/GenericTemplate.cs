namespace BinaryFog.Messenger.Send
{
    using Newtonsoft.Json;

    public class GenericTemplate
    {
        public GenericTemplate()
        {
            this.TemplateType = "generic";
        }

        [JsonProperty("template_type")]
        public string TemplateType { get; set; }

        [JsonProperty("elements")]
        public object[] Elements { get; set; }
    }
}