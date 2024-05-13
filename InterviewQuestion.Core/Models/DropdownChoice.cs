namespace InterviewQuestion.Core.Models
{
    public class DropdownChoice : ModelBase
    {
        public int DropdownChoiceId { get; set; }
        public string Choice { get; set; }
        public int DropdownTemplateId { get; set; }

        public virtual DropdownTemplate DropdownTemplate { get; set; }
    }
}
