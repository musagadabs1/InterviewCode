using GeneralUitl.Models;
using InterviewQuestion.Core.DTOs;
using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class ApplicationProgramRepository : IApplicationProgramRepository
    {
        private EmployeeDbContext _dbContext;
        public ApplicationProgramRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private static Container ContainerClient()
        {
            var comosDbClient = new CosmosClient(CosmosUtil.CosmosDBAccountUri, CosmosUtil.CosmosAccountPrimaryKey);
            var containerClient = comosDbClient.GetContainer(CosmosUtil.CosmosDbName, CosmosUtil.CosmosContainerName);
            return containerClient;

        }
        public async Task<ItemResponse<AppProgram>> AddApplicationProgramAsync(ApplicationProgramDto model)
        {
            try
            {
                var container = ContainerClient();

                var property = await container.ReadContainerAsync();

                //var partitionKeyPath=property.

                var appProgram = new AppProgram
                {
                    Title = model.Title,
                    Description = model.Description,
                    InterviewId = "InterviewId",
                    Id = Guid.NewGuid().ToString(),
                    Employee = new Employee
                    {
                        FirstName = model.FirstName,
                        Email = model.Email,
                        //EmployeeId = Guid.NewGuid(),
                        LastName = model.LastName,
                        Gender = model.Gender,
                        CurrentResidence = model.CurrentResidence,
                        Nationality = model.Nationality,
                        DateOfBirth = model.DateOfBirth,
                        IdNumber = model.IdNumber,
                        Phone = model.Phone,

                    },
                    YesNoQuestion = model.YesNoQuestion,
                    ParagraphQuestion = model.ParagraphQuestion,
                    MultipleChoiceTemplate = model.MultipleChoiceTemplate,
                    NumericQuestion = model.NumericQuestion,
                    DateQuestion = model.DateQuestion,

                };

                var response = await container.CreateItemAsync(appProgram, new PartitionKey(appProgram.InterviewId));
                //var result = _dbContext.ApplicationPrograms.Add(appProgram);
                //await _dbContext.SaveChangesAsync();
                return response;
                //retu//rn model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ApplicationProgram> DeleteApplicationProgramAsync(int id)
        {
            try
            {
                var result = await GetApplicationProgramByIdAsync(id);
                if (result != null)
                {
                    _dbContext.ApplicationPrograms.Remove(result);
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
        public async Task<ApplicationProgram> DeleteApplicationProgramAsync(int id, string partitionKey)
        {
            try
            {

                var container = ContainerClient();
                var response = await container.DeleteItemAsync<ApplicationProgram>(id.ToString(), new PartitionKey(partitionKey));
                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ApplicationProgram> GetApplicationProgramByIdAsync(int id)
        {
            try
            {
                var result = await _dbContext.ApplicationPrograms
                    .Include(x => x.Employee)
                    .Include(x => x.MultipleChoiceTemplate)
                    .Include(x => x.DateQuestion)
                    .Include(x => x.ParagraphQuestion)
                    .Include(x => x.NumericQuestion)
                    .Include(x => x.YesNoQuestion)
                    .FirstOrDefaultAsync(x => x.ApplicationProgramId == id);

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
        public async Task<ApplicationProgram> GetApplicationProgramByIdAsync(int id, string partitionKey)
        {
            try
            {
                var container = ContainerClient();
                ItemResponse<ApplicationProgram> response = await container.ReadItemAsync<ApplicationProgram>(id.ToString(), new PartitionKey(partitionKey));
                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<ApplicationProgram>> GetApplicationProgramsAsync()
        {
            try
            {
                var container = ContainerClient();
                var sqlQuery = "SELECT * from ApllicationProgram";

                var queryDefinition = new QueryDefinition(sqlQuery);
                var queryResultSelector = container.GetItemQueryIterator<ApplicationProgram>(queryDefinition);

                var appPrograms = new List<ApplicationProgram>();
                while (queryResultSelector.HasMoreResults)
                {
                    var currentResultSet = await queryResultSelector.ReadNextAsync();
                    foreach (var item in currentResultSet)
                    {
                        appPrograms.Add(item);
                    }
                }

                //var result = await _dbContext.ApplicationPrograms
                //    .Include(x => x.Employee)
                //    .Include(x => x.MultipleChoiceTemplate)
                //    .Include(x => x.DateQuestion)
                //    .Include(x => x.ParagraphQuestion)
                //    .Include(x => x.NumericQuestion)
                //    .Include(x => x.YesNoQuestion)
                //    .ToListAsync();
                //return result;
                return appPrograms;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ItemResponse<AppProgram>> UpdateApplicationProgramAsync(ApplicationProgramDto model, string partitionKey)
        {
            try
            {
                var container = ContainerClient();
                ItemResponse<AppProgram> res = await container.ReadItemAsync<AppProgram>(model.ApplicationProgramId.ToString(), new PartitionKey(partitionKey));
                //Get Existing Item
                var existingItem = res.Resource;
                //Replace existing item values with new values
                existingItem.Title = model.Title;
                existingItem.YesNoQuestion = model.YesNoQuestion;
                existingItem.NumericQuestion = model.NumericQuestion;
                existingItem.ParagraphQuestion = model.ParagraphQuestion;
                existingItem.MultipleChoiceTemplate = model.MultipleChoiceTemplate;

                var updateRes = await container.ReplaceItemAsync(existingItem, model.ApplicationProgramId.ToString(), new PartitionKey(partitionKey));
                return updateRes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<ApplicationProgram> UpdateApplicationProgramAsync(ApplicationProgramDto model)
        {
            try
            {
                var yesNo = await GetApplicationProgramByIdAsync(model.ApplicationProgramId);

                if (yesNo != null)
                {
                    yesNo.UpdatedOn = DateTime.Now;
                    yesNo.DateQuestionId = model.ApplicationProgramId;
                    yesNo.Description = model.Description;
                    //yesNo.YesNoQuestion = model.YesNoQuestion;
                    //yesNo.MultipleChoiceTemplateId = model.MultipleChoiceTemplateId;
                    //yesNo.ParagraphQuestionId = model.ParagraphQuestionId;
                    //yesNo.ParagraphQuestionId = model.ParagraphQuestionId;
                    //yesNo.NumericQuestionId = model.NumericQuestionId;
                    yesNo.Title = model.Title;

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
