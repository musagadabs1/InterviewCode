using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class MultipleChoiceTemplateRepository : IMultipleChoiceTemplateRepository
    {
        private EmployeeDbContext _dbContext;
        public MultipleChoiceTemplateRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<MultipleChoiceTemplate> AddMultipleChoiceTemplateAsync(MultipleChoiceTemplateDto model)
        {
            try
            {
                var multiple = new MultipleChoiceTemplate
                {
                    //CreatedOn = DateTime.Now,
                    //UpdatedOn = DateTime.Now,
                    Question = model.Question,
                    MaxChoiceAllowed = model.MaxChoiceAllowed,
                    Type = model.Type,
                };

                var result = _dbContext.MultipleChoiceTemplates.Add(multiple);
                await _dbContext.SaveChangesAsync();

                return multiple;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<MultipleChoiceTemplate> DeleteMultipleChoiceTemplateAsync(int id)
        {
            try
            {
                var result = await GetMultipleChoiceTemplateByIdAsync(id);
                if (result != null)
                {
                    _dbContext.MultipleChoiceTemplates.Remove(result);
                    await _dbContext.SaveChangesAsync();
                    return result;
                }
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<MultipleChoiceTemplate> GetMultipleChoiceTemplateByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.MultipleChoiceTemplates
                    .Include(x => x.MultipleChoices)
                    .FirstOrDefaultAsync(x => (int)x.Type == id);

                if (result != null)
                {
                    return result;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<MultipleChoiceTemplate>> GetMultipleChoiceTemplatesAsync()
        {
            try
            {
                var result = await _dbContext.MultipleChoiceTemplates
                    .Include(x => x.MultipleChoices)
                    .ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<MultipleChoiceTemplate> UpdateMultipleChoiceTemplateAsync(MultipleChoiceTemplateDto model)
        {
            try
            {
                var yesNo = await GetMultipleChoiceTemplateByIdAsync(model.MultipleChoiceTemplateId);
                if (yesNo != null)
                {
                    //yesNo.UpdatedOn = DateTime.Now;
                    yesNo.Question = model.Question;
                    yesNo.Type = model.Type;

                    await _dbContext.SaveChangesAsync();
                }

                return yesNo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
