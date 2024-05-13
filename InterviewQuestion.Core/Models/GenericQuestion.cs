using InterviewQuestion.Core.Enumerations;
using InterviewQuestion.Core.Interfaces;

namespace InterviewQuestion.Core.Models
{
    public class GenericQuestion : ModelBase, IGenericQuestion
    {
        public int GenericQuestionId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
