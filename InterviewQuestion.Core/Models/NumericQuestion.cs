using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Models
{
    public class NumericQuestion
    {
        //public int NumericQuestionId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
