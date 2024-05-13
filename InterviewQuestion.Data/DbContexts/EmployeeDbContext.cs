using InterviewQuestion.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InterviewQuestion.Data.DbContexts
{
    public class EmployeeDbContext : IdentityDbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<YesNoQuestion> YesNoQuestions { get; set; }
        public DbSet<ParagraphQuestion> ParagraphQuestions { get; set; }
        public DbSet<DateQuestion> DateQuestions { get; set; }
        public DbSet<NumericQuestion> NumericQuestions { get; set; }
        public DbSet<GenericQuestion> GenericQuestions { get; set; }
        public DbSet<ApplicationProgram> ApplicationPrograms { get; set; }
        public DbSet<MultipleChoiceTemplate> MultipleChoiceTemplates { get; set; }
        public DbSet<MultipleChoice> MultipleChoices { get; set; }
    }
}
