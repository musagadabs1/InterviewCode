using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IQuestionRepository
    {
        Task<DateQuestion> AddDateQuestionAsync(DateQuestion model);
        Task<ParagraphQuestion> AddParagraphQuestionAsync(ParagraphQuestion model);
        Task<MultipleChoiceTemplate> AddMultipleChoiceQuestionAsync(MultipleChoiceTemplate model);
        Task<NumericQuestion> AddNumericQuestionAsync(NumericQuestion model);
        Task<YesNoQuestion> AddYesNoQuestionAsync(YesNoQuestion model);
        //Task<DateQuestion> UpdateDateQuestionAsync(DateQuestion model);
        //Task<DateQuestion> DeleteDateQuestionAsync(int id);
        //Task<DateQuestion> GetDateQuestionByIdAsync(int id);
        //Task<List<DateQuestion>> GetDateQuestionsAsync();
    }
}
