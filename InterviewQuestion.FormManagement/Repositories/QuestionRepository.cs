using GeneralUitl.Models;
using InterviewQuestion.Core.Enumerations;
using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Core.Models;
using InterviewQuestion.Data.DbContexts;
using Microsoft.Azure.Cosmos;

namespace InterviewQuestion.FormManagement.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private EmployeeDbContext _dbContext;
        public QuestionRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private static Container ContainerClient()
        {
            var comosDbClient = new CosmosClient(CosmosUtil.CosmosDBAccountUri, CosmosUtil.CosmosAccountPrimaryKey);
            var containerClient = comosDbClient.GetContainer(CosmosUtil.CosmosQuestionsDbName, CosmosUtil.CosmosQuestionsContainerName);
            return containerClient;

        }
        public async Task<DateQuestion> AddDateQuestionAsync(DateQuestion model)
        {
            try
            {
                var container = ContainerClient();

                //var property = await container.ReadContainerAsync();
                //var PartitonKeyPath = property.Resource.PartitionKeyPath;
                //var partitionKeyPath=property.

                var dateQuestion = new DateQuestion
                {
                    Type = QuestionType.Date.ToString(),
                    Question = model.Question,
                    Id = Guid.NewGuid().ToString(),
                    Answer = model.Answer,
                };

                var response = await container.CreateItemAsync(dateQuestion, new PartitionKey(dateQuestion.Type.ToString()));
                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<MultipleChoiceTemplate> AddMultipleChoiceQuestionAsync(MultipleChoiceTemplate model)
        {
            try
            {
                var container = ContainerClient();

                //var property = await container.ReadContainerAsync();
                //var PartitonKeyPath = property.Resource.PartitionKeyPath;
                //var partitionKeyPath=property.

                var dateQuestion = new MultipleChoiceTemplate
                {
                    Type = QuestionType.MultipleChoice.ToString(),
                    Question = model.Question,
                    Id = Guid.NewGuid().ToString(),
                    MaxChoiceAllowed = model.MaxChoiceAllowed,
                    MultipleChoices = model.MultipleChoices,
                };

                var response = await container.CreateItemAsync(dateQuestion, new PartitionKey(dateQuestion.Type.ToString()));
                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<NumericQuestion> AddNumericQuestionAsync(NumericQuestion model)
        {
            try
            {
                var container = ContainerClient();

                //var property = await container.ReadContainerAsync();
                //var PartitonKeyPath = property.Resource.PartitionKeyPath;
                //var partitionKeyPath=property.

                var dateQuestion = new NumericQuestion
                {
                    Type = QuestionType.Numeric.ToString(),
                    Question = model.Question,
                    Id = Guid.NewGuid().ToString(),
                    Answer = model.Answer,
                };

                var response = await container.CreateItemAsync(dateQuestion, new PartitionKey(dateQuestion.Type.ToString()));
                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ParagraphQuestion> AddParagraphQuestionAsync(ParagraphQuestion model)
        {
            try
            {
                var container = ContainerClient();

                //var property = await container.ReadContainerAsync();
                //var PartitonKeyPath = property.Resource.PartitionKeyPath;
                //var partitionKeyPath=property.
                //var type=
                var dateQuestion = new ParagraphQuestion
                {

                    Type = QuestionType.Paragraph.ToString(),
                    Question = model.Question,
                    Id = Guid.NewGuid().ToString(),
                    Answer = model.Answer,
                };

                var response = await container.CreateItemAsync(dateQuestion, new PartitionKey(dateQuestion.Type.ToString()));
                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<YesNoQuestion> AddYesNoQuestionAsync(YesNoQuestion model)
        {
            try
            {
                var container = ContainerClient();

                //var property = await container.ReadContainerAsync();
                //var PartitonKeyPath = property.Resource.PartitionKeyPath;
                //var partitionKeyPath=property.

                var dateQuestion = new YesNoQuestion
                {
                    Type = QuestionType.YesNo.ToString(),
                    Question = model.Question,
                    Id = Guid.NewGuid().ToString(),
                    Answer = model.Answer,
                };

                var response = await container.CreateItemAsync(dateQuestion, new PartitionKey(dateQuestion.Type.ToString()));
                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public async Task<DateQuestion> DeleteDateQuestionAsync(int id)
        //{
        //    try
        //    {
        //        var result = await GetDateQuestionByIdAsync(id);
        //        if (result != null)
        //        {
        //            _dbContext.DateQuestions.Remove(result);
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

        //public async Task<DateQuestion> GetDateQuestionByIdAsync(int id)
        //{
        //    try
        //    {
        //        var result = await _dbContext.DateQuestions.FirstOrDefaultAsync(x => (int)x.Type == id);

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

        //public async Task<List<DateQuestion>> GetDateQuestionsAsync()
        //{
        //    try
        //    {
        //        var result = await _dbContext.DateQuestions.ToListAsync();
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public async Task<DateQuestion> UpdateDateQuestionAsync(DateQuestion model)
        //{
        //    try
        //    {
        //        var yesNo = await GetDateQuestionByIdAsync((int)model.Type);

        //        return yesNo;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
