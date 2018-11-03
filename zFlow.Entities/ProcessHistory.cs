using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a ProcessHistory.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProcessHistory : IEntityBase
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserComment { get; set; }
        public string UserAction { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? ProcessInstID { get; set; }
        public string StepName { get; set; }
    }
}      
