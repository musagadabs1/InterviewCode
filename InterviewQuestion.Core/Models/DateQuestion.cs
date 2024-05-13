using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Models
{
    public class DateQuestion
    {
        //public int DateQuestionId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; } = string.Empty;
    }
}
