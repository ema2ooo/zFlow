using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a ProcessDefinitionVersion.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProcessDefinitionVersion : IEntityBase
    {
        public int ID { get; set; }
        public string Revision { get; set; }
        public byte[] XamlFile { get; set; }
        public int ProcessDefID { get; set; }
        public string XamlFileName { get; set; }
        public bool CurrentVersion { get; set; }
    }
}      
