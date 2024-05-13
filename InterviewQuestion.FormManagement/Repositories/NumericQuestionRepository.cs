using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class NumericQuestionRepository : INumericQuestionRepository
    {
        private EmployeeDbContext _dbContext;
        public NumericQuestionRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<NumericQuestion> AddNumericQuestionAsync(NumericQuestion model)
        {
            try
            {
                //model.CreatedOn = DateTime.Now;
                //model.UpdatedOn = DateTime.Now;

                var result = _dbContext.NumericQuestions.Add(model);
                await _dbContext.SaveChangesAsync();

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<NumericQuestion> DeleteNumericQuestionAsync(int id)
        {
            try
            {
                var result = await GetNumericQuestionByIdAsync(id);
                if (result != null)
                {
                    _dbContext.NumericQuestions.Remove(result);
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

        public async Task<NumericQuestion> GetNumericQuestionByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.NumericQuestions.FirstOrDefaultAsync(x => (int)x.Type == id);

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

        public async Task<List<NumericQuestion>> GetNumericQuestionsAsync()
        {
            try
            {
                var result = await _dbContext.NumericQuestions.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<NumericQuestion> UpdateNumericQuestionAsync(NumericQuestion model)
        {
            try
            {
                var yesNo = await GetNumericQuestionByIdAsync((int)model.Type);

                return yesNo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
