using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a ProcessTasks.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProcessTasks : IEntityBase
    {
        public int ID { get; set; }
        public string AssignedToUserID { get; set; }
        public DateTime? TaskCreationDate { get; set; }
        public DateTime? TaskAssignmentDate { get; set; }
        public DateTime? TaskFinishDate { get; set; }
        public int? ProcessinstanceID { get; set; }
        public string OutCome { get; set; }
        public string AdditionalData { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsCancelled { get; set; }
        public string CurrentStep { get; set; }
        public string StepID { get; set; }
        public string Orginator { get; set; }
        public string Category { get; set; }
        public int? Status { get; set; }
        public int? DispatchingType { get; set; }
        public string GroupName { get; set; }
    }
}      
