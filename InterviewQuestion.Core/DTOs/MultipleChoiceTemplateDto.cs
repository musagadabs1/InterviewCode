using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.DTOs
{
    public class MultipleChoiceTemplateDto
    {
        public int MultipleChoiceTemplateId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public int MaxChoiceAllowed { get; set; }
    }
}
