using InterviewQuestion.Core.Enumerations;

namespace InterviewQuestion.Core.Models
{
    public class DropdownTemplate : ModelBase
    {
        public int DropdownTemplateId { get; set; }
        public QuestionType Type { get; set; }
        public string Question { get; set; }
        public virtual ICollection<DropdownChoice> DropdownChoices { get; set; }
    }


}
