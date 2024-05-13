using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class ParagraphQuestionRepository : IParagraphQuestionRepository
    {
        private EmployeeDbContext _dbContext;
        public ParagraphQuestionRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ParagraphQuestion> AddParagraphQuestionAsync(ParagraphQuestion model)
        {
            try
            {
                //model.CreatedOn = DateTime.Now;
                //model.UpdatedOn = DateTime.Now;

                var result = _dbContext.ParagraphQuestions.Add(model);
                await _dbContext.SaveChangesAsync();

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ParagraphQuestion> DeleteParagraphQuestionAsync(int id)
        {
            try
            {
                var result = await GetParagraphQuestionByIdAsync(id);
                if (result != null)
                {
                    _dbContext.ParagraphQuestions.Remove(result);
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

        public async Task<ParagraphQuestion> GetParagraphQuestionByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.ParagraphQuestions.FirstOrDefaultAsync(x => (int)x.Type == id);

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

        public async Task<List<ParagraphQuestion>> GetParagraphQuestionsAsync()
        {
            try
            {
                var result = await _dbContext.ParagraphQuestions.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ParagraphQuestion> UpdateParagraphQuestionAsync(ParagraphQuestion model)
        {
            try
            {
                var yesNo = await GetParagraphQuestionByIdAsync((int)model.Type);

                return yesNo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
