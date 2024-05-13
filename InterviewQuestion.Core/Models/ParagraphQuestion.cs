using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Models
{
    public class ParagraphQuestion
    {
        //public int ParagraphQuestionId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
