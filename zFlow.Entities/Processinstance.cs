using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a Processinstance.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Processinstance : IEntityBase
    {
        public int ID { get; set; }
        public string ProcessNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string OriginatorID { get; set; }
        public string BeneficiaryID { get; set; }
        public int? ProcessDefinitionID { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsCancelled { get; set; }
        public string AdditionalData { get; set; }
        public string WFI { get; set; }
        public string DepartmentID { get; set; }
    }
}      
