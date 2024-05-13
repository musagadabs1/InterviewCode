using Newtonsoft.Json;

namespace InterviewQuestion.Core.Models
{
    public class AppProgram
    {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Employee Employee { get; set; }
        public ParagraphQuestion ParagraphQuestion { get; set; }
        public NumericQuestion NumericQuestion { get; set; }
        public DateQuestion DateQuestion { get; set; }
        public YesNoQuestion YesNoQuestion { get; set; }
        public MultipleChoiceTemplate MultipleChoiceTemplate { get; set; }
    }
}
