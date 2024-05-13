using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface INumericQuestionRepository
    {
        Task<NumericQuestion> AddNumericQuestionAsync(NumericQuestion model);
        Task<NumericQuestion> UpdateNumericQuestionAsync(NumericQuestion model);
        Task<NumericQuestion> DeleteNumericQuestionAsync(int id);
        Task<NumericQuestion> GetNumericQuestionByIdAsync(int id);
        Task<List<NumericQuestion>> GetNumericQuestionsAsync();
    }
}
