using System;
namespace zFlow.Entities
{
    /// <summary>
    /// Represents a Notification.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Notification : IEntityBase
    {
        public int ID { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }
        public int MessageType { get; set; }
        public DateTime DueDate { get; set; }
        public string TransactionID { get; set; }
        public int RetryCount { get; set; }
        public string StatusText { get; set; }
        public int StatusID { get; set; }
        public string BusinessObjectID { get; set; }
    }
}      
