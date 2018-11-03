using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a Configuration.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Configuration : IEntityBase
    {
        public int ID { get; set; }
        public string ConfigurationKey { get; set; }
        public int ConfigurationEnvironmentID { get; set; }
        public string Value { get; set; }
    }
}      
