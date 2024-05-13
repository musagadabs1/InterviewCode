using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Models
{
    public class MultipleChoiceTemplate
    {
        //public int MultipleChoiceTemplateId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public int MaxChoiceAllowed { get; set; }
        public MultipleChoice[] MultipleChoices { get; set; }
    }
}
