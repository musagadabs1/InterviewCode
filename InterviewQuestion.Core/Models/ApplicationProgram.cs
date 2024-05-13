namespace InterviewQuestion.Core.Models
{
    public class ApplicationProgram : ModelBase
    {
        public int ApplicationProgramId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid EmployeeId { get; set; }
        public int ParagraphQuestionId { get; set; }
        public int NumericQuestionId { get; set; }
        public int DateQuestionId { get; set; }
        public int YesNoQuestionId { get; set; }
        public int MultipleChoiceTemplateId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual YesNoQuestion YesNoQuestion { get; set; }
        public virtual DateQuestion DateQuestion { get; set; }
        public virtual NumericQuestion NumericQuestion { get; set; }
        public virtual MultipleChoiceTemplate MultipleChoiceTemplate { get; set; }
        public virtual ParagraphQuestion ParagraphQuestion { get; set; }
    }
}
