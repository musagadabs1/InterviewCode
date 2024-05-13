using InterviewQuestion.Core.Enumerations;
using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IGenericQuestionRepository
    {
        Task<GenericQuestion> AddGenericQuestionAsync(GenericQuestion mode);
        Task<GenericQuestion> UpdateGenericQuestionAsync(GenericQuestion model);
        Task<GenericQuestion> DeleteGenericQuestionAsync(int id);
        Task<GenericQuestion> GetGenericQuestionByIdAsync(int id);
        Task<List<GenericQuestion>> GetGenericQuestionsAsync();
        Task<List<GenericQuestion>> GetGenericQuestionsByTypeAsync(QuestionType questionType);
    }
}
