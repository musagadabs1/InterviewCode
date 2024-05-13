using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IMultipleChoiceTemplateRepository
    {
        Task<MultipleChoiceTemplate> AddMultipleChoiceTemplateAsync(MultipleChoiceTemplateDto model);
        Task<MultipleChoiceTemplate> UpdateMultipleChoiceTemplateAsync(MultipleChoiceTemplateDto model);
        Task<MultipleChoiceTemplate> DeleteMultipleChoiceTemplateAsync(int id);
        Task<MultipleChoiceTemplate> GetMultipleChoiceTemplateByIdAsync(int id);
        Task<List<MultipleChoiceTemplate>> GetMultipleChoiceTemplatesAsync();
    }
}
