using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a SavedRequest.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class SavedRequest : IEntityBase
    {

        public int SavedRequestID { get; set; }
        public int DefinitionID { get; set; }
        public string UserID { get; set; }
        public byte[] SavedRequestXml { get; set; }
        public DateTime RequestDate { get; set; }
        public int ID { get; set; }
    }
}      
