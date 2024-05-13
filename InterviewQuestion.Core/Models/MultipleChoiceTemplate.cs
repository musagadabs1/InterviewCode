using Newtonsoft.Json;

namespace InterviewQuestion.Core.Models
{
    public class MultipleChoiceTemplate
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public int MaxChoiceAllowed { get; set; }
        public MultipleChoice[] MultipleChoices { get; set; }
    }
}
