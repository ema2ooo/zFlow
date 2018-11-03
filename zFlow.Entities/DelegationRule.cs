using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a DelegationRule.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class DelegationRule : IEntityBase
    {
        public int ID { get; set; }
        public bool? IsActive { get; set; }
        public string Scope { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ProcessDefinitionID { get; set; }
        public string StepID { get; set; }
        public string OwnerID { get; set; }
        public string OwnerName { get; set; }
        public string DelegatedToID { get; set; }
        public string DelegatedToName { get; set; }
    }
}      
