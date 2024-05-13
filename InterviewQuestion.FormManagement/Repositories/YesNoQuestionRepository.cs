using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class YesNoQuestionRepository : IYesNoQuestionRepository
    {
        private EmployeeDbContext _dbContext;
        public YesNoQuestionRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<YesNoQuestion> AddYesNoQuestionAsync(YesNoQuestion model)
        {
            try
            {
                //model.CreatedOn = DateTime.Now;
                //model.UpdatedOn = DateTime.Now;

                var result = _dbContext.YesNoQuestions.Add(model);
                await _dbContext.SaveChangesAsync();

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<YesNoQuestion> DeleteYesNoQuestionAsync(int id)
        {
            try
            {
                var result = await GetYesNoQuestionByIdAsync(id);
                if (result != null)
                {
                    _dbContext.YesNoQuestions.Remove(result);
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

        public async Task<YesNoQuestion> GetYesNoQuestionByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.YesNoQuestions.FirstOrDefaultAsync(x => (int)x.Type == id);

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

        public async Task<List<YesNoQuestion>> GetYesNoQuestionsAsync()
        {
            try
            {
                var result = await _dbContext.YesNoQuestions.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<YesNoQuestion> UpdateYesNoQuestionAsync(YesNoQuestion model)
        {
            try
            {
                var yesNo = await GetYesNoQuestionByIdAsync((int)model.Type);

                return yesNo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
