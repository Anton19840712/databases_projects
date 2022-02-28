using System;
using FireBaseNotification.Enums;

namespace FireBaseNotification.Models
{
    public class Developer
    {
        public Guid DeveloperId = Guid.NewGuid();
        public string Name { get; set; }
        public string Age { get; set; }
        public SalaryLevel HowMuchMoneyEarns { get; set; }
        public SkillLevel TechnicalLevelOfProgrammer { get; set; }
    }
}