using InterviewQuestion.Core.Enumerations;
using InterviewQuestion.Core.Models;

namespace InterviewQuestion.Core.DTOs
{
    public class ApplicationProgramDto
    {
        public int ApplicationProgramId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Choice { get; set; }
        public ParagraphQuestion ParagraphQuestion { get; set; }
        public NumericQuestion NumericQuestion { get; set; }
        public DateQuestion DateQuestion { get; set; }
        public YesNoQuestion YesNoQuestion { get; set; }
        public MultipleChoiceTemplate MultipleChoiceTemplate { get; set; }
    }
}
