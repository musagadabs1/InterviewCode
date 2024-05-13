using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IGenericQuestion
    {
        QuestionType Type { get; set; }
        string Question { get; set; }
        string Answer { get; set; }
    }
}
