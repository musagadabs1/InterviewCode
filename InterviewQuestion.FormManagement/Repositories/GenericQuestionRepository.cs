using InterviewQuestion.Core.Enumerations;
using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class GenericQuestionRepository(EmployeeDbContext dbContext) : IGenericQuestionRepository
    {
        private EmployeeDbContext _dbContext = dbContext;

        public async Task<GenericQuestion> AddGenericQuestionAsync(GenericQuestion model)
        {
            try
            {
                model.CreatedOn = DateTime.Now;
                model.UpdatedOn = DateTime.Now;

                var result = _dbContext.GenericQuestions.Add(model);
                await _dbContext.SaveChangesAsync();

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<GenericQuestion> DeleteGenericQuestionAsync(int id)
        {
            try
            {
                var result = await GetGenericQuestionByIdAsync(id);
                if (result != null)
                {
                    _dbContext.GenericQuestions.Remove(result);
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

        public async Task<GenericQuestion> GetGenericQuestionByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.GenericQuestions.FirstOrDefaultAsync(x => x.GenericQuestionId == id);

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

        public async Task<List<GenericQuestion>> GetGenericQuestionsAsync()
        {
            try
            {
                var result = await _dbContext.GenericQuestions.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<GenericQuestion>> GetGenericQuestionsByTypeAsync(QuestionType questionType)
        {
            try
            {
                var result = await _dbContext.GenericQuestions.Where(x => x.Type == questionType).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<GenericQuestion> UpdateGenericQuestionAsync(GenericQuestion model)
        {
            try
            {
                model.UpdatedOn = DateTime.Now;
                var yesNo = await GetGenericQuestionByIdAsync(model.GenericQuestionId);
                yesNo.UpdatedOn = DateTime.Now;
                yesNo.Answer = model.Answer;
                yesNo.Question = model.Question;
                await _dbContext.SaveChangesAsync();
                return yesNo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
