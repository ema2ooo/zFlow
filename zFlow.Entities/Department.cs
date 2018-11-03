using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a Department.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Department : IEntityBase
    {
        public int ID { get; set; }
        public string DepartmentEn { get; set; }
        public string DepartmentAr { get; set; }
        public int? ParentID { get; set; }
    }
}      
