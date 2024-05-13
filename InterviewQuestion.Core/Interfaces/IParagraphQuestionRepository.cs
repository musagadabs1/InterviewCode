using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IParagraphQuestionRepository
    {
        Task<ParagraphQuestion> AddParagraphQuestionAsync(ParagraphQuestion model);
        Task<ParagraphQuestion> UpdateParagraphQuestionAsync(ParagraphQuestion model);
        Task<ParagraphQuestion> DeleteParagraphQuestionAsync(int id);
        Task<ParagraphQuestion> GetParagraphQuestionByIdAsync(int id);
        Task<List<ParagraphQuestion>> GetParagraphQuestionsAsync();
    }
}
