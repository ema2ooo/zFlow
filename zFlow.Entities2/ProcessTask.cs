using System;

namespace zFlow.Entities
{
    public class ProcessTask : IEntityBase
    {
        public int ID { get; set; }
        public string AssignedToUserID { get; set; }
        public DateTime TaskCreationDate { get; set; }
        public DateTime TaskAssignmentDate { get; set; }
        public DateTime EscalationDateTime { get; set; }
        public string TaskFinishDate { get; set; }
        public string OutCome { get; set; }
        public string AdditionalData { get; set; }
        public bool IsClosed { get; set; }
        public bool IsCancelled { get; set; }
        public string CurrentStep { get; set; }
        public string StepID { get; set; }
        public string Orginator { get; set; }
        public string Category { get; set; }
        public string DispatchingType { get; set; }
        public string GroupName { get; set; }

    }
}