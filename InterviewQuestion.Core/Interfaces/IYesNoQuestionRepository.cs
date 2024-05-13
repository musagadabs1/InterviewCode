using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IYesNoQuestionRepository
    {
        Task<YesNoQuestion> AddYesNoQuestionAsync(YesNoQuestion model);
        Task<YesNoQuestion> UpdateYesNoQuestionAsync(YesNoQuestion model);
        Task<YesNoQuestion> DeleteYesNoQuestionAsync(int id);
        Task<YesNoQuestion> GetYesNoQuestionByIdAsync(int id);
        Task<List<YesNoQuestion>> GetYesNoQuestionsAsync();
    }
}
