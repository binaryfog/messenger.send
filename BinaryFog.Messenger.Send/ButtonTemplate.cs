namespace BinaryFog.Messenger.Send
{
    using Newtonsoft.Json;

    public class ButtonTemplate
    {
        public ButtonTemplate()
        {
            this.TemplateType = "button";
            this.Text = "This is default text.";
        }
        public ButtonTemplate(string text)
        {
            this.TemplateType = "button";
            this.Text = text;
        }

        [JsonProperty("template_type")]
        public string TemplateType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("buttons")]
        public PostbackButton[] Buttons { get; set; }

        public override string ToString()
        {
            return $"template_type: {this.TemplateType}\ntext: {this.Text}\nbuttons:\n\t {this.Buttons}";
        }
    }
}