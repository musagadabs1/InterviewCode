using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class DateQuestionRepository : IDateQuestionRepository
    {
        private EmployeeDbContext _dbContext;
        public DateQuestionRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<DateQuestion> AddDateQuestionAsync(DateQuestion model)
        {
            try
            {
                //model.CreatedOn = DateTime.Now;
                //model.UpdatedOn = DateTime.Now;

                var result = _dbContext.DateQuestions.Add(model);
                await _dbContext.SaveChangesAsync();

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<DateQuestion> DeleteDateQuestionAsync(int id)
        {
            try
            {
                var result = await GetDateQuestionByIdAsync(id);
                if (result != null)
                {
                    _dbContext.DateQuestions.Remove(result);
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

        public async Task<DateQuestion> GetDateQuestionByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.DateQuestions.FirstOrDefaultAsync(x => (int)x.Type == id);

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

        public async Task<List<DateQuestion>> GetDateQuestionsAsync()
        {
            try
            {
                var result = await _dbContext.DateQuestions.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<DateQuestion> UpdateDateQuestionAsync(DateQuestion model)
        {
            try
            {
                var yesNo = await GetDateQuestionByIdAsync((int)model.Type);

                return yesNo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
