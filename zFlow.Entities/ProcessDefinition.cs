using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a ProcessDefinition.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProcessDefinition : IEntityBase
    {
        public int ID { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string URL { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public int? DepartmentID { get; set; }
    }
}      
