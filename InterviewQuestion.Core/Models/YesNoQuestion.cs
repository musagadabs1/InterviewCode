using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Models
{
    public class YesNoQuestion
    {
        //public int YesNoQuestionId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
