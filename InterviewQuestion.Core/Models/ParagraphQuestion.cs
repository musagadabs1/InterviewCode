using Newtonsoft.Json;

namespace InterviewQuestion.Core.Models
{
    public class ParagraphQuestion
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; } = string.Empty;
    }
}
