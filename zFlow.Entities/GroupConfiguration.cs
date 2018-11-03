using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a GroupConfiguration.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class GroupConfiguration : IEntityBase
    {
        public int ID { get; set; }
        public int GroupConfigurationID { get; set; }
        public string UserID { get; set; }
        public string TaskCategory { get; set; }
        public string GroupName { get; set; }
        public int? TasksCount { get; set; }
        public int? TaskCountCapability { get; set; }
    }
}      
