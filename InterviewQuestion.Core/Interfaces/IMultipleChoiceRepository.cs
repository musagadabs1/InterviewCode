using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.Interfaces
{
    public interface IMultipleChoiceRepository
    {
        Task<MultipleChoice> AddMultipleChoiceAsync(MultipleChoiceDto model);
        //Task<MultipleChoice> UpdateMultipleChoiceAsync(MultipleChoiceDto model);
        //Task<MultipleChoice> DeleteMultipleChoiceAsync(int id);
        //Task<MultipleChoice> GetMultipleChoiceByIdAsync(int id);
        Task<List<MultipleChoice>> GetMultipleChoicesAsync();
    }
}
