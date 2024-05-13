using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IDateQuestionRepository
    {
        Task<DateQuestion> AddDateQuestionAsync(DateQuestion model);
        Task<DateQuestion> UpdateDateQuestionAsync(DateQuestion model);
        Task<DateQuestion> DeleteDateQuestionAsync(int id);
        Task<DateQuestion> GetDateQuestionByIdAsync(int id);
        Task<List<DateQuestion>> GetDateQuestionsAsync();
    }
}
