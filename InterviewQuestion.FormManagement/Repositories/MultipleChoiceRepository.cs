using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class MultipleChoiceRepository : IMultipleChoiceRepository
    {
        private EmployeeDbContext _dbContext;
        public MultipleChoiceRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<MultipleChoice> AddMultipleChoiceAsync(MultipleChoiceDto model)
        {
            try
            {
                var choice = new MultipleChoice
                {
                    //CreatedOn = DateTime.Now,
                    //UpdatedOn = DateTime.Now,
                    //MultipleChoiceTemplateId = model.MultipleChoiceTemplateId,
                    Choice = model.Choice
                };

                var result = _dbContext.MultipleChoices.Add(choice);
                await _dbContext.SaveChangesAsync();
                //
                return choice;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public async Task<MultipleChoice> DeleteMultipleChoiceAsync(int id)
        //{
        //    try
        //    {
        //        var result = await GetMultipleChoiceByIdAsync(id);
        //        if (result != null)
        //        {
        //            _dbContext.MultipleChoices.Remove(result);
        //            await _dbContext.SaveChangesAsync();
        //            return result;
        //        }
        //        return result;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public async Task<MultipleChoice> GetMultipleChoiceByIdAsync(int id)
        //{
        //    try
        //    {
        //        var result = await _dbContext.MultipleChoices.FirstOrDefaultAsync(x => x.T == id);

        //        if (result != null)
        //        {
        //            return result;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public async Task<List<MultipleChoice>> GetMultipleChoicesAsync()
        {
            try
            {
                var result = await _dbContext.MultipleChoices.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public async Task<MultipleChoice> UpdateMultipleChoiceAsync(MultipleChoiceDto model)
        //{
        //    try
        //    {
        //        var yesNo = await GetMultipleChoiceByIdAsync(model.T);
        //        if (yesNo != null)
        //        {
        //            //yesNo.MultipleChoiceTemplateId = model.MultipleChoiceTemplateId;
        //            //yesNo.UpdatedOn = DateTime.Now;
        //            yesNo.Choice = model.Choice;

        //            await _dbContext.SaveChangesAsync();
        //        }

        //        return yesNo;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
